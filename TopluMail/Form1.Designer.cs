namespace TopluMail
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSendMail = new System.Windows.Forms.Button();
            this.lblSent = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.tbxMessage = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSenderMail = new System.Windows.Forms.TextBox();
            this.tbxSenderPassword = new System.Windows.Forms.TextBox();
            this.lblAddEmail = new System.Windows.Forms.Label();
            this.tbxAddEmail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDeleteEmail = new System.Windows.Forms.Button();
            this.Emails = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(153, 404);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(314, 34);
            this.btnSendMail.TabIndex = 0;
            this.btnSendMail.Text = "Send Mail";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // lblSent
            // 
            this.lblSent.AutoSize = true;
            this.lblSent.Location = new System.Drawing.Point(44, 206);
            this.lblSent.Name = "lblSent";
            this.lblSent.Size = new System.Drawing.Size(45, 13);
            this.lblSent.TabIndex = 2;
            this.lblSent.Text = "Postalar";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(51, 183);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(38, 13);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Başlık:";
            // 
            // tbxTitle
            // 
            this.tbxTitle.Location = new System.Drawing.Point(95, 180);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(314, 20);
            this.tbxTitle.TabIndex = 3;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(36, 310);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(53, 13);
            this.lblMessage.TabIndex = 6;
            this.lblMessage.Text = "Mesajınız:";
            // 
            // tbxMessage
            // 
            this.tbxMessage.Location = new System.Drawing.Point(95, 307);
            this.tbxMessage.Multiline = true;
            this.tbxMessage.Name = "tbxMessage";
            this.tbxMessage.Size = new System.Drawing.Size(499, 89);
            this.tbxMessage.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Gönderen E-Posta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Gönderen Parola:";
            // 
            // tbxSenderMail
            // 
            this.tbxSenderMail.Location = new System.Drawing.Point(188, 12);
            this.tbxSenderMail.Name = "tbxSenderMail";
            this.tbxSenderMail.Size = new System.Drawing.Size(314, 20);
            this.tbxSenderMail.TabIndex = 10;
            // 
            // tbxSenderPassword
            // 
            this.tbxSenderPassword.Location = new System.Drawing.Point(188, 38);
            this.tbxSenderPassword.Name = "tbxSenderPassword";
            this.tbxSenderPassword.PasswordChar = '*';
            this.tbxSenderPassword.Size = new System.Drawing.Size(314, 20);
            this.tbxSenderPassword.TabIndex = 11;
            // 
            // lblAddEmail
            // 
            this.lblAddEmail.AutoSize = true;
            this.lblAddEmail.Location = new System.Drawing.Point(85, 100);
            this.lblAddEmail.Name = "lblAddEmail";
            this.lblAddEmail.Size = new System.Drawing.Size(56, 13);
            this.lblAddEmail.TabIndex = 13;
            this.lblAddEmail.Text = "Email Ekle";
            // 
            // tbxAddEmail
            // 
            this.tbxAddEmail.Location = new System.Drawing.Point(88, 116);
            this.tbxAddEmail.Name = "tbxAddEmail";
            this.tbxAddEmail.Size = new System.Drawing.Size(314, 20);
            this.tbxAddEmail.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteEmail
            // 
            this.btnDeleteEmail.Location = new System.Drawing.Point(415, 206);
            this.btnDeleteEmail.Name = "btnDeleteEmail";
            this.btnDeleteEmail.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteEmail.TabIndex = 15;
            this.btnDeleteEmail.Text = "Sil";
            this.btnDeleteEmail.UseVisualStyleBackColor = true;
            this.btnDeleteEmail.Click += new System.EventHandler(this.btnDeleteEmail_Click);
            // 
            // Emails
            // 
            this.Emails.FormattingEnabled = true;
            this.Emails.Location = new System.Drawing.Point(95, 206);
            this.Emails.Name = "Emails";
            this.Emails.Size = new System.Drawing.Size(314, 95);
            this.Emails.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteEmail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblAddEmail);
            this.Controls.Add(this.tbxAddEmail);
            this.Controls.Add(this.tbxSenderPassword);
            this.Controls.Add(this.tbxSenderMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Emails);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.tbxMessage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.lblSent);
            this.Controls.Add(this.btnSendMail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Label lblSent;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox tbxTitle;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox tbxMessage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSenderMail;
        private System.Windows.Forms.TextBox tbxSenderPassword;
        private System.Windows.Forms.Label lblAddEmail;
        private System.Windows.Forms.TextBox tbxAddEmail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDeleteEmail;
        private System.Windows.Forms.ListBox Emails;
    }
}

