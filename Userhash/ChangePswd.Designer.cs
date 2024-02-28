namespace Userhash
{
    partial class ChangePswd
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
            this.textBoxOldPswd = new System.Windows.Forms.TextBox();
            this.textBoxNewPswd2 = new System.Windows.Forms.TextBox();
            this.textBoxNewPswd = new System.Windows.Forms.TextBox();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxOldPswd
            // 
            this.textBoxOldPswd.Location = new System.Drawing.Point(12, 25);
            this.textBoxOldPswd.Name = "textBoxOldPswd";
            this.textBoxOldPswd.Size = new System.Drawing.Size(245, 20);
            this.textBoxOldPswd.TabIndex = 0;
            // 
            // textBoxNewPswd2
            // 
            this.textBoxNewPswd2.Location = new System.Drawing.Point(12, 103);
            this.textBoxNewPswd2.Name = "textBoxNewPswd2";
            this.textBoxNewPswd2.Size = new System.Drawing.Size(245, 20);
            this.textBoxNewPswd2.TabIndex = 1;
            // 
            // textBoxNewPswd
            // 
            this.textBoxNewPswd.Location = new System.Drawing.Point(12, 64);
            this.textBoxNewPswd.Name = "textBoxNewPswd";
            this.textBoxNewPswd.Size = new System.Drawing.Size(245, 20);
            this.textBoxNewPswd.TabIndex = 2;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(182, 136);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(75, 23);
            this.buttonConfirm.TabIndex = 3;
            this.buttonConfirm.Text = "potvrdit";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            this.buttonConfirm.Click += new System.EventHandler(this.buttonConfirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "aktuální heslo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "nové heslo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "nové heslo znovu:";
            // 
            // ChangePswd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 171);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxNewPswd);
            this.Controls.Add(this.textBoxNewPswd2);
            this.Controls.Add(this.textBoxOldPswd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ChangePswd";
            this.ShowIcon = false;
            this.Text = "Změna hesla";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChangePswd_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxOldPswd;
        private System.Windows.Forms.TextBox textBoxNewPswd2;
        private System.Windows.Forms.TextBox textBoxNewPswd;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}