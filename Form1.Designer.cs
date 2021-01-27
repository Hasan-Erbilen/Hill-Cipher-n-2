namespace WindowsFormsApplication3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.senderMessage = new System.Windows.Forms.TextBox();
            this.btn_encrypt = new System.Windows.Forms.Button();
            this.btn_decrypt = new System.Windows.Forms.Button();
            this.dst_ip = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.key_edit = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.messageReceived = new System.Windows.Forms.TextBox();
            this.cipherTextLabel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(61, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "SENDER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(519, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "RECEIVER";
            // 
            // senderMessage
            // 
            this.senderMessage.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.senderMessage.Location = new System.Drawing.Point(45, 76);
            this.senderMessage.Margin = new System.Windows.Forms.Padding(2);
            this.senderMessage.Multiline = true;
            this.senderMessage.Name = "senderMessage";
            this.senderMessage.Size = new System.Drawing.Size(156, 85);
            this.senderMessage.TabIndex = 2;
            // 
            // btn_encrypt
            // 
            this.btn_encrypt.Location = new System.Drawing.Point(65, 179);
            this.btn_encrypt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_encrypt.Name = "btn_encrypt";
            this.btn_encrypt.Size = new System.Drawing.Size(113, 27);
            this.btn_encrypt.TabIndex = 4;
            this.btn_encrypt.Text = "Encrypt Messsage";
            this.btn_encrypt.UseVisualStyleBackColor = true;
            this.btn_encrypt.Click += new System.EventHandler(this.btn_encrypt_click);
            // 
            // btn_decrypt
            // 
            this.btn_decrypt.Location = new System.Drawing.Point(512, 179);
            this.btn_decrypt.Margin = new System.Windows.Forms.Padding(2);
            this.btn_decrypt.Name = "btn_decrypt";
            this.btn_decrypt.Size = new System.Drawing.Size(113, 27);
            this.btn_decrypt.TabIndex = 5;
            this.btn_decrypt.Text = "Decrypt Messsage";
            this.btn_decrypt.UseVisualStyleBackColor = true;
            this.btn_decrypt.Click += new System.EventHandler(this.btn_decrypt_click);
            // 
            // dst_ip
            // 
            this.dst_ip.Location = new System.Drawing.Point(72, 19);
            this.dst_ip.Name = "dst_ip";
            this.dst_ip.Size = new System.Drawing.Size(96, 20);
            this.dst_ip.TabIndex = 13;
            this.dst_ip.Text = "127.0.0.1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "IP Address";
            // 
            // btn_send
            // 
            this.btn_send.Location = new System.Drawing.Point(174, 17);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(56, 23);
            this.btn_send.TabIndex = 17;
            this.btn_send.Text = "Send";
            this.btn_send.UseVisualStyleBackColor = true;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.btn_send);
            this.groupBox1.Controls.Add(this.dst_ip);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(217, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 48);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Send to other";
            // 
            // key_edit
            // 
            this.key_edit.Location = new System.Drawing.Point(101, 51);
            this.key_edit.Name = "key_edit";
            this.key_edit.Size = new System.Drawing.Size(100, 20);
            this.key_edit.TabIndex = 19;
            this.key_edit.Text = "HI98";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Key : ";
            // 
            // messageReceived
            // 
            this.messageReceived.Location = new System.Drawing.Point(494, 76);
            this.messageReceived.Multiline = true;
            this.messageReceived.Name = "messageReceived";
            this.messageReceived.ReadOnly = true;
            this.messageReceived.Size = new System.Drawing.Size(147, 85);
            this.messageReceived.TabIndex = 21;
            // 
            // cipherTextLabel
            // 
            this.cipherTextLabel.Location = new System.Drawing.Point(265, 76);
            this.cipherTextLabel.Multiline = true;
            this.cipherTextLabel.Name = "cipherTextLabel";
            this.cipherTextLabel.ReadOnly = true;
            this.cipherTextLabel.Size = new System.Drawing.Size(162, 85);
            this.cipherTextLabel.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(296, 51);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Encrypted message";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 241);
            this.Controls.Add(this.cipherTextLabel);
            this.Controls.Add(this.messageReceived);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.key_edit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_decrypt);
            this.Controls.Add(this.btn_encrypt);
            this.Controls.Add(this.senderMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox senderMessage;
        private System.Windows.Forms.Button btn_encrypt;
        private System.Windows.Forms.Button btn_decrypt;
        private System.Windows.Forms.TextBox dst_ip;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox key_edit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox messageReceived;
        private System.Windows.Forms.TextBox cipherTextLabel;
        private System.Windows.Forms.Label label5;
    }
}

