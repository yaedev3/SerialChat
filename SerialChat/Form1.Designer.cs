namespace SerialChat
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
            this.textBoxChat = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.pictureBoxFriend = new System.Windows.Forms.PictureBox();
            this.pictureBoxMe = new System.Windows.Forms.PictureBox();
            this.textBoxView = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxChat
            // 
            this.textBoxChat.Location = new System.Drawing.Point(12, 409);
            this.textBoxChat.Multiline = true;
            this.textBoxChat.Name = "textBoxChat";
            this.textBoxChat.Size = new System.Drawing.Size(386, 41);
            this.textBoxChat.TabIndex = 1;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(410, 409);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 41);
            this.buttonSend.TabIndex = 2;
            this.buttonSend.Text = "Enviar";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // pictureBoxFriend
            // 
            this.pictureBoxFriend.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxFriend.Name = "pictureBoxFriend";
            this.pictureBoxFriend.Size = new System.Drawing.Size(116, 116);
            this.pictureBoxFriend.TabIndex = 3;
            this.pictureBoxFriend.TabStop = false;
            // 
            // pictureBoxMe
            // 
            this.pictureBoxMe.Location = new System.Drawing.Point(12, 287);
            this.pictureBoxMe.Name = "pictureBoxMe";
            this.pictureBoxMe.Size = new System.Drawing.Size(116, 116);
            this.pictureBoxMe.TabIndex = 4;
            this.pictureBoxMe.TabStop = false;
            // 
            // textBoxView
            // 
            this.textBoxView.Location = new System.Drawing.Point(134, 12);
            this.textBoxView.Name = "textBoxView";
            this.textBoxView.ReadOnly = true;
            this.textBoxView.Size = new System.Drawing.Size(351, 391);
            this.textBoxView.TabIndex = 5;
            this.textBoxView.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(497, 462);
            this.Controls.Add(this.textBoxView);
            this.Controls.Add(this.pictureBoxMe);
            this.Controls.Add(this.pictureBoxFriend);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxChat);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Messenger";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxChat;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.PictureBox pictureBoxFriend;
        private System.Windows.Forms.PictureBox pictureBoxMe;
        private System.Windows.Forms.RichTextBox textBoxView;
    }
}

