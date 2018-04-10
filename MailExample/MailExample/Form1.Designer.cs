namespace MailExample
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.servertxt = new System.Windows.Forms.TextBox();
            this.Usertxt = new System.Windows.Forms.TextBox();
            this.Passwordtxt = new System.Windows.Forms.TextBox();
            this.Mailtxt = new System.Windows.Forms.TextBox();
            this.Subjecttxt = new System.Windows.Forms.TextBox();
            this.Messagetxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Attachmenttxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SenderMailtxt = new System.Windows.Forms.TextBox();
            this.SenderMaillbl = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Attachmentchk = new System.Windows.Forms.CheckBox();
            this.Sendbtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.Porttxt = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail server:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Subject:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Message:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 219);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Attachment:";
            // 
            // servertxt
            // 
            this.servertxt.Location = new System.Drawing.Point(3, 16);
            this.servertxt.Name = "servertxt";
            this.servertxt.Size = new System.Drawing.Size(183, 20);
            this.servertxt.TabIndex = 7;
            this.servertxt.Text = "smtp.gmail.com";
            // 
            // Usertxt
            // 
            this.Usertxt.Location = new System.Drawing.Point(5, 139);
            this.Usertxt.Name = "Usertxt";
            this.Usertxt.Size = new System.Drawing.Size(183, 20);
            this.Usertxt.TabIndex = 8;
            this.Usertxt.Text = "example@gmail.com";
            // 
            // Passwordtxt
            // 
            this.Passwordtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passwordtxt.Location = new System.Drawing.Point(5, 178);
            this.Passwordtxt.Name = "Passwordtxt";
            this.Passwordtxt.PasswordChar = '*';
            this.Passwordtxt.Size = new System.Drawing.Size(183, 20);
            this.Passwordtxt.TabIndex = 9;
            this.Passwordtxt.Text = "password";
            // 
            // Mailtxt
            // 
            this.Mailtxt.Location = new System.Drawing.Point(3, 16);
            this.Mailtxt.Name = "Mailtxt";
            this.Mailtxt.Size = new System.Drawing.Size(266, 20);
            this.Mailtxt.TabIndex = 10;
            this.Mailtxt.Text = "mail@example.com";
            // 
            // Subjecttxt
            // 
            this.Subjecttxt.Location = new System.Drawing.Point(3, 55);
            this.Subjecttxt.Name = "Subjecttxt";
            this.Subjecttxt.Size = new System.Drawing.Size(266, 20);
            this.Subjecttxt.TabIndex = 11;
            this.Subjecttxt.Text = "my subject";
            // 
            // Messagetxt
            // 
            this.Messagetxt.BackColor = System.Drawing.Color.White;
            this.Messagetxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Messagetxt.Location = new System.Drawing.Point(3, 94);
            this.Messagetxt.Multiline = true;
            this.Messagetxt.Name = "Messagetxt";
            this.Messagetxt.Size = new System.Drawing.Size(266, 122);
            this.Messagetxt.TabIndex = 12;
            this.Messagetxt.Text = "My message";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(271, 156);
            this.label8.TabIndex = 13;
            this.label8.Text = resources.GetString("label8.Text");
            // 
            // Attachmenttxt
            // 
            this.Attachmenttxt.Enabled = false;
            this.Attachmenttxt.Location = new System.Drawing.Point(3, 258);
            this.Attachmenttxt.Name = "Attachmenttxt";
            this.Attachmenttxt.ReadOnly = true;
            this.Attachmenttxt.Size = new System.Drawing.Size(266, 20);
            this.Attachmenttxt.TabIndex = 15;
            this.Attachmenttxt.Text = "Attachment path";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Porttxt);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.SenderMailtxt);
            this.panel1.Controls.Add(this.SenderMaillbl);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.servertxt);
            this.panel1.Controls.Add(this.Usertxt);
            this.panel1.Controls.Add(this.Passwordtxt);
            this.panel1.Location = new System.Drawing.Point(22, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 200);
            this.panel1.TabIndex = 16;
            // 
            // SenderMailtxt
            // 
            this.SenderMailtxt.Location = new System.Drawing.Point(3, 55);
            this.SenderMailtxt.Name = "SenderMailtxt";
            this.SenderMailtxt.Size = new System.Drawing.Size(183, 20);
            this.SenderMailtxt.TabIndex = 11;
            this.SenderMailtxt.Text = "example@gmail.com";
            // 
            // SenderMaillbl
            // 
            this.SenderMaillbl.AutoSize = true;
            this.SenderMaillbl.Location = new System.Drawing.Point(3, 39);
            this.SenderMaillbl.Name = "SenderMaillbl";
            this.SenderMaillbl.Size = new System.Drawing.Size(34, 13);
            this.SenderMaillbl.TabIndex = 10;
            this.SenderMaillbl.Text = "email:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.Attachmentchk);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.Attachmenttxt);
            this.panel2.Controls.Add(this.Mailtxt);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Subjecttxt);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.Messagetxt);
            this.panel2.Location = new System.Drawing.Point(296, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(283, 284);
            this.panel2.TabIndex = 17;
            // 
            // Attachmentchk
            // 
            this.Attachmentchk.AutoSize = true;
            this.Attachmentchk.Location = new System.Drawing.Point(3, 235);
            this.Attachmentchk.Name = "Attachmentchk";
            this.Attachmentchk.Size = new System.Drawing.Size(123, 17);
            this.Attachmentchk.TabIndex = 15;
            this.Attachmentchk.Text = "Include attachment?";
            this.Attachmentchk.UseVisualStyleBackColor = true;
            this.Attachmentchk.CheckedChanged += new System.EventHandler(this.Attachmentchk_CheckedChanged);
            // 
            // Sendbtn
            // 
            this.Sendbtn.Location = new System.Drawing.Point(300, 313);
            this.Sendbtn.Name = "Sendbtn";
            this.Sendbtn.Size = new System.Drawing.Size(266, 23);
            this.Sendbtn.TabIndex = 18;
            this.Sendbtn.Text = "Send mail";
            this.Sendbtn.UseVisualStyleBackColor = true;
            this.Sendbtn.Click += new System.EventHandler(this.Sendbtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Port:";
            // 
            // Porttxt
            // 
            this.Porttxt.Location = new System.Drawing.Point(3, 94);
            this.Porttxt.Name = "Porttxt";
            this.Porttxt.Size = new System.Drawing.Size(183, 20);
            this.Porttxt.TabIndex = 13;
            this.Porttxt.Text = "587";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 382);
            this.Controls.Add(this.Sendbtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Name = "Form1";
            this.Text = "Mail example";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox servertxt;
        private System.Windows.Forms.TextBox Usertxt;
        private System.Windows.Forms.TextBox Passwordtxt;
        private System.Windows.Forms.TextBox Mailtxt;
        private System.Windows.Forms.TextBox Subjecttxt;
        private System.Windows.Forms.TextBox Messagetxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Attachmenttxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox Attachmentchk;
        private System.Windows.Forms.Button Sendbtn;
        private System.Windows.Forms.TextBox SenderMailtxt;
        private System.Windows.Forms.Label SenderMaillbl;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox Porttxt;
        private System.Windows.Forms.Label label9;
    }
}

