namespace mySurvey
{
    partial class take
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
            this.takeLabel = new System.Windows.Forms.Label();
            this.takebox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // takeLabel
            // 
            this.takeLabel.AutoSize = true;
            this.takeLabel.Location = new System.Drawing.Point(38, 71);
            this.takeLabel.Name = "takeLabel";
            this.takeLabel.Size = new System.Drawing.Size(86, 13);
            this.takeLabel.TabIndex = 0;
            this.takeLabel.Text = "just to show you:";
            // 
            // takebox
            // 
            this.takebox.Location = new System.Drawing.Point(164, 63);
            this.takebox.Name = "takebox";
            this.takebox.Size = new System.Drawing.Size(100, 20);
            this.takebox.TabIndex = 1;
            // 
            // take
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.takebox);
            this.Controls.Add(this.takeLabel);
            this.Name = "take";
            this.Text = "take";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label takeLabel;
        private System.Windows.Forms.TextBox takebox;
    }
}