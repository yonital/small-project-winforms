namespace mySurvey
{
    partial class query
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
            this.queryLabel = new System.Windows.Forms.Label();
            this.queryBox = new System.Windows.Forms.TextBox();
            this.myLabel = new System.Windows.Forms.Label();
            this.primaryLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // queryLabel
            // 
            this.queryLabel.AutoSize = true;
            this.queryLabel.Location = new System.Drawing.Point(72, 22);
            this.queryLabel.Name = "queryLabel";
            this.queryLabel.Size = new System.Drawing.Size(56, 13);
            this.queryLabel.TabIndex = 0;
            this.queryLabel.Text = "the names";
            // 
            // queryBox
            // 
            this.queryBox.Location = new System.Drawing.Point(75, 56);
            this.queryBox.Name = "queryBox";
            this.queryBox.Size = new System.Drawing.Size(364, 20);
            this.queryBox.TabIndex = 1;
            // 
            // myLabel
            // 
            this.myLabel.AutoSize = true;
            this.myLabel.Location = new System.Drawing.Point(72, 133);
            this.myLabel.Name = "myLabel";
            this.myLabel.Size = new System.Drawing.Size(81, 13);
            this.myLabel.TabIndex = 2;
            this.myLabel.Text = "survey headline";
            // 
            // primaryLabel
            // 
            this.primaryLabel.Location = new System.Drawing.Point(75, 171);
            this.primaryLabel.Name = "primaryLabel";
            this.primaryLabel.Size = new System.Drawing.Size(364, 20);
            this.primaryLabel.TabIndex = 3;
            // 
            // query
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.primaryLabel);
            this.Controls.Add(this.myLabel);
            this.Controls.Add(this.queryBox);
            this.Controls.Add(this.queryLabel);
            this.Name = "query";
            this.Text = "query";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label queryLabel;
        private System.Windows.Forms.TextBox queryBox;
        private System.Windows.Forms.Label myLabel;
        private System.Windows.Forms.TextBox primaryLabel;
    }
}