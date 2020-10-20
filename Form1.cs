using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using MimeKit.Text;

namespace AdContact
{
    public partial class Form1 : Form
    {
        private static readonly string ArticleParamName = "{ARTICLE_URL}";
        private List<KeyValuePair<string, string>> _articleEmailPairs;
        private MailConnector _mc;

        public Form1()
        {
            InitializeComponent();
        }

        /*
         * Initialize.
         */
        private void Form1_Load(object sender, EventArgs e)
        {
            _mc = new MailConnector();

            dgv_emailList.ColumnCount = 2;
            dgv_emailList.Columns[0].Name = "Article URL";
            dgv_emailList.Columns[1].Name = "Email";

            dgv_emailList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dgv_emailList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_emailList.RowHeadersVisible = false;
            dgv_emailList.AllowUserToAddRows = false;
        }

        /*
         * Try to establish IMAP & SMTP connections.
         */
        private void b_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                _mc.ImapConnect(tb_login.Text, tb_password.Text);
                _mc.SmtpConnect(tb_login.Text, tb_password.Text);
                l_status.Text = "IMAP and SMTP connection established.";
                b_Send.Enabled = true;
            }
            catch (AuthenticationException ex)
            {
                l_status.Text = ex.Message;
                b_Send.Enabled = false;
            }
        }

        /*
         * Open and parse an email list file. The file should be in the following format:
         *
         * [ARTICLE URL] [RECIPIENT EMAIL]
         * [ARTICLE URL] [RECIPIENT EMAIL]
         * [ARTICLE URL] [RECIPIENT EMAIL]
         * ...
         */
        private void b_LoadEmailFile_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog { Filter = "Text files|*.txt", InitialDirectory = "C:\\\\" };

            if (ofd.ShowDialog() != DialogResult.OK) return;

            var sr = new StreamReader(ofd.OpenFile());
            _articleEmailPairs = new List<KeyValuePair<string, string>>();
            string line;

            dgv_emailList.Rows.Clear();

            while ((line = sr.ReadLine()) != null)
            {
                var split = line.Split(' ');

                if (split.Length > 1)
                {
                    _articleEmailPairs.Add(new KeyValuePair<string, string>(split[0], split[1]));

                    dgv_emailList.Rows.Add(split[0], split[1]);
                }
            }

            sr.Close();
        }

        /*
         * Send appropriate emails to the recipients. 
         */
        private void b_Send_Click(object sender, EventArgs e)
        {
            if (_articleEmailPairs == null || _articleEmailPairs.Count < 1)
            {
                l_status.Text = "Error: email list is empty.";
                return;
            }

            try
            {
                foreach (var kv in _articleEmailPairs)
                {
                    var mes = new MimeMessage();

                    mes.From.Add(new MailboxAddress(tb_senderName.Text, tb_senderEmail.Text));
                    mes.To.Add(new MailboxAddress("", kv.Value));
                    mes.Subject = tb_emailSubject.Text;
                    mes.Body = new TextPart(TextFormat.Text)
                    {
                        Text = tb_customMessage.Text.Replace(ArticleParamName, kv.Key)
                    };

                    _mc.Send(mes);
                }

                l_status.Text = $"Successfully sent {_articleEmailPairs.Count} messages.";
            }
            catch (SmtpCommandException ex)
            {
                l_status.Text = ex.Message;
            }
        }

        /*
         * Load message from a file.
         */
        private void b_LoadCustomMessageFile_Click(object sender, EventArgs e)
        {
            // TODO
        }
    }
}