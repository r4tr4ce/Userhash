namespace Userhash
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
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.signButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(82, 12);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(155, 20);
            this.usernameBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(82, 38);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '•';
            this.passwordBox.Size = new System.Drawing.Size(155, 20);
            this.passwordBox.TabIndex = 1;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // signButton
            // 
            this.signButton.Location = new System.Drawing.Point(162, 64);
            this.signButton.Name = "signButton";
            this.signButton.Size = new System.Drawing.Size(75, 23);
            this.signButton.TabIndex = 2;
            this.signButton.Text = "prihlasit";
            this.signButton.UseVisualStyleBackColor = true;
            this.signButton.Click += new System.EventHandler(this.signButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "heslo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(249, 111);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button signButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

