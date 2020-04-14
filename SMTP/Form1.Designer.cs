namespace SMTP
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
            this.txt_Mail = new System.Windows.Forms.RichTextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.txt_To = new System.Windows.Forms.TextBox();
            this.txt_From = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.txt_Subject = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(273, 77);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(321, 195);
            this.txt_Mail.TabIndex = 0;
            this.txt_Mail.Text = "";
            // 
            // btn_Send
            // 
            this.btn_Send.Location = new System.Drawing.Point(181, 214);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(75, 23);
            this.btn_Send.TabIndex = 1;
            this.btn_Send.Text = "button1";
            this.btn_Send.UseVisualStyleBackColor = true;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // txt_To
            // 
            this.txt_To.Location = new System.Drawing.Point(12, 150);
            this.txt_To.Name = "txt_To";
            this.txt_To.Size = new System.Drawing.Size(244, 20);
            this.txt_To.TabIndex = 2;
            // 
            // txt_From
            // 
            this.txt_From.Location = new System.Drawing.Point(12, 51);
            this.txt_From.Name = "txt_From";
            this.txt_From.Size = new System.Drawing.Size(244, 20);
            this.txt_From.TabIndex = 3;
            // 
            // txt_Password
            // 
            this.txt_Password.Location = new System.Drawing.Point(12, 95);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(244, 20);
            this.txt_Password.TabIndex = 4;
            // 
            // txt_Subject
            // 
            this.txt_Subject.Location = new System.Drawing.Point(273, 51);
            this.txt_Subject.Name = "txt_Subject";
            this.txt_Subject.Size = new System.Drawing.Size(321, 20);
            this.txt_Subject.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 432);
            this.Controls.Add(this.txt_Subject);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_From);
            this.Controls.Add(this.txt_To);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.txt_Mail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_Mail;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox txt_To;
        private System.Windows.Forms.TextBox txt_From;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.TextBox txt_Subject;
    }
}

