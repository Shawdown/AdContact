namespace AdContact
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_login = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.l_status = new System.Windows.Forms.Label();
            this.l_login = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.b_Connect = new System.Windows.Forms.Button();
            this.tb_customMessage = new System.Windows.Forms.TextBox();
            this.dgv_emailList = new System.Windows.Forms.DataGridView();
            this.b_LoadEmailFile = new System.Windows.Forms.Button();
            this.b_LoadCustomMessageFile = new System.Windows.Forms.Button();
            this.b_Send = new System.Windows.Forms.Button();
            this.l_SenderName = new System.Windows.Forms.Label();
            this.l_senderEmail = new System.Windows.Forms.Label();
            this.tb_senderName = new System.Windows.Forms.TextBox();
            this.tb_senderEmail = new System.Windows.Forms.TextBox();
            this.l_emailSubject = new System.Windows.Forms.Label();
            this.tb_emailSubject = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emailList)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_login
            // 
            this.tb_login.Location = new System.Drawing.Point(52, 13);
            this.tb_login.Name = "tb_login";
            this.tb_login.Size = new System.Drawing.Size(137, 20);
            this.tb_login.TabIndex = 0;
            this.tb_login.Text = "shou.aa00";
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(254, 13);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '•';
            this.tb_password.Size = new System.Drawing.Size(137, 20);
            this.tb_password.TabIndex = 2;
            this.tb_password.Text = "Leet1337@=1";
            // 
            // l_status
            // 
            this.l_status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.l_status.Location = new System.Drawing.Point(485, 9);
            this.l_status.Name = "l_status";
            this.l_status.Size = new System.Drawing.Size(549, 32);
            this.l_status.TabIndex = 3;
            this.l_status.Text = "\r\n";
            // 
            // l_login
            // 
            this.l_login.AutoSize = true;
            this.l_login.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_login.Location = new System.Drawing.Point(13, 16);
            this.l_login.Name = "l_login";
            this.l_login.Size = new System.Drawing.Size(37, 13);
            this.l_login.TabIndex = 5;
            this.l_login.Text = "Login";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(199, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Password";
            // 
            // b_Connect
            // 
            this.b_Connect.Location = new System.Drawing.Point(397, 9);
            this.b_Connect.Name = "b_Connect";
            this.b_Connect.Size = new System.Drawing.Size(80, 32);
            this.b_Connect.TabIndex = 7;
            this.b_Connect.Text = "Connect";
            this.b_Connect.UseVisualStyleBackColor = true;
            this.b_Connect.Click += new System.EventHandler(this.b_Connect_Click);
            // 
            // tb_customMessage
            // 
            this.tb_customMessage.Location = new System.Drawing.Point(12, 59);
            this.tb_customMessage.Multiline = true;
            this.tb_customMessage.Name = "tb_customMessage";
            this.tb_customMessage.Size = new System.Drawing.Size(465, 406);
            this.tb_customMessage.TabIndex = 8;
            this.tb_customMessage.Text = resources.GetString("tb_customMessage.Text");
            // 
            // dgv_emailList
            // 
            this.dgv_emailList.BackgroundColor = System.Drawing.Color.LightGray;
            this.dgv_emailList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_emailList.Location = new System.Drawing.Point(485, 59);
            this.dgv_emailList.Name = "dgv_emailList";
            this.dgv_emailList.Size = new System.Drawing.Size(549, 406);
            this.dgv_emailList.TabIndex = 9;
            // 
            // b_LoadEmailFile
            // 
            this.b_LoadEmailFile.Location = new System.Drawing.Point(714, 471);
            this.b_LoadEmailFile.Name = "b_LoadEmailFile";
            this.b_LoadEmailFile.Size = new System.Drawing.Size(116, 32);
            this.b_LoadEmailFile.TabIndex = 10;
            this.b_LoadEmailFile.Text = "Load Email File";
            this.b_LoadEmailFile.UseVisualStyleBackColor = true;
            this.b_LoadEmailFile.Click += new System.EventHandler(this.b_LoadEmailFile_Click);
            // 
            // b_LoadCustomMessageFile
            // 
            this.b_LoadCustomMessageFile.Location = new System.Drawing.Point(159, 473);
            this.b_LoadCustomMessageFile.Name = "b_LoadCustomMessageFile";
            this.b_LoadCustomMessageFile.Size = new System.Drawing.Size(159, 32);
            this.b_LoadCustomMessageFile.TabIndex = 11;
            this.b_LoadCustomMessageFile.Text = "Load Custom Message File";
            this.b_LoadCustomMessageFile.UseVisualStyleBackColor = true;
            this.b_LoadCustomMessageFile.Click += new System.EventHandler(this.b_LoadCustomMessageFile_Click);
            // 
            // b_Send
            // 
            this.b_Send.Enabled = false;
            this.b_Send.Location = new System.Drawing.Point(954, 562);
            this.b_Send.Name = "b_Send";
            this.b_Send.Size = new System.Drawing.Size(80, 32);
            this.b_Send.TabIndex = 12;
            this.b_Send.Text = "Send!";
            this.b_Send.UseVisualStyleBackColor = true;
            this.b_Send.Click += new System.EventHandler(this.b_Send_Click);
            // 
            // l_SenderName
            // 
            this.l_SenderName.AutoSize = true;
            this.l_SenderName.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_SenderName.Location = new System.Drawing.Point(381, 572);
            this.l_SenderName.Name = "l_SenderName";
            this.l_SenderName.Size = new System.Drawing.Size(73, 13);
            this.l_SenderName.TabIndex = 16;
            this.l_SenderName.Text = "Sender Name";
            // 
            // l_senderEmail
            // 
            this.l_senderEmail.AutoSize = true;
            this.l_senderEmail.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_senderEmail.Location = new System.Drawing.Point(153, 572);
            this.l_senderEmail.Name = "l_senderEmail";
            this.l_senderEmail.Size = new System.Drawing.Size(79, 13);
            this.l_senderEmail.TabIndex = 15;
            this.l_senderEmail.Text = "Sender Email";
            // 
            // tb_senderName
            // 
            this.tb_senderName.Location = new System.Drawing.Point(456, 569);
            this.tb_senderName.Name = "tb_senderName";
            this.tb_senderName.Size = new System.Drawing.Size(137, 20);
            this.tb_senderName.TabIndex = 14;
            this.tb_senderName.Text = "Паразайт";
            // 
            // tb_senderEmail
            // 
            this.tb_senderEmail.Location = new System.Drawing.Point(234, 569);
            this.tb_senderEmail.Name = "tb_senderEmail";
            this.tb_senderEmail.Size = new System.Drawing.Size(137, 20);
            this.tb_senderEmail.TabIndex = 13;
            this.tb_senderEmail.Text = "shou.aa00@yandex.ru";
            // 
            // l_emailSubject
            // 
            this.l_emailSubject.AutoSize = true;
            this.l_emailSubject.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_emailSubject.Location = new System.Drawing.Point(606, 572);
            this.l_emailSubject.Name = "l_emailSubject";
            this.l_emailSubject.Size = new System.Drawing.Size(85, 13);
            this.l_emailSubject.TabIndex = 18;
            this.l_emailSubject.Text = "Email Subject";
            // 
            // tb_emailSubject
            // 
            this.tb_emailSubject.Location = new System.Drawing.Point(693, 569);
            this.tb_emailSubject.Name = "tb_emailSubject";
            this.tb_emailSubject.Size = new System.Drawing.Size(255, 20);
            this.tb_emailSubject.TabIndex = 17;
            this.tb_emailSubject.Text = "Рекламное сотрудничество с Паразайт";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 606);
            this.Controls.Add(this.l_emailSubject);
            this.Controls.Add(this.tb_emailSubject);
            this.Controls.Add(this.l_SenderName);
            this.Controls.Add(this.l_senderEmail);
            this.Controls.Add(this.tb_senderName);
            this.Controls.Add(this.tb_senderEmail);
            this.Controls.Add(this.b_Send);
            this.Controls.Add(this.b_LoadCustomMessageFile);
            this.Controls.Add(this.b_LoadEmailFile);
            this.Controls.Add(this.dgv_emailList);
            this.Controls.Add(this.tb_customMessage);
            this.Controls.Add(this.b_Connect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.l_login);
            this.Controls.Add(this.l_status);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_login);
            this.Name = "Form1";
            this.Text = "AdContact";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_emailList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_login;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label l_status;
        private System.Windows.Forms.Label l_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_Connect;
        private System.Windows.Forms.TextBox tb_customMessage;
        private System.Windows.Forms.DataGridView dgv_emailList;
        private System.Windows.Forms.Button b_LoadEmailFile;
        private System.Windows.Forms.Button b_LoadCustomMessageFile;
        private System.Windows.Forms.Button b_Send;
        private System.Windows.Forms.Label l_SenderName;
        private System.Windows.Forms.Label l_senderEmail;
        private System.Windows.Forms.TextBox tb_senderName;
        private System.Windows.Forms.TextBox tb_senderEmail;
        private System.Windows.Forms.Label l_emailSubject;
        private System.Windows.Forms.TextBox tb_emailSubject;
    }
}

