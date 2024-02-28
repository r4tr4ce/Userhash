namespace Userhash
{
    partial class FormContent
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonPswdChange = new System.Windows.Forms.Button();
            this.labelUser = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Userhash.Properties.Resources.obama_obamium;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 295);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonPswdChange
            // 
            this.buttonPswdChange.Location = new System.Drawing.Point(12, 316);
            this.buttonPswdChange.Name = "buttonPswdChange";
            this.buttonPswdChange.Size = new System.Drawing.Size(75, 23);
            this.buttonPswdChange.TabIndex = 1;
            this.buttonPswdChange.Text = "změň heslo";
            this.buttonPswdChange.UseVisualStyleBackColor = true;
            this.buttonPswdChange.Click += new System.EventHandler(this.buttonPswdChange_Click);
            // 
            // labelUser
            // 
            this.labelUser.AccessibleName = "labelUser";
            this.labelUser.Location = new System.Drawing.Point(166, 321);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(146, 13);
            this.labelUser.TabIndex = 2;
            this.labelUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 351);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.buttonPswdChange);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormContent";
            this.ShowIcon = false;
            this.Text = "Obamium";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormContent_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPswdChange;
        public System.Windows.Forms.Label labelUser;
    }
}