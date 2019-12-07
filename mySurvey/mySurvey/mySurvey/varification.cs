using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mySurvey
{
    public class varification : Form
    {
        private Label userLabel;
        private Label passwordLabel;
        private TextBox usernameBox;
        private Button approveButton;
        private TextBox passwordBox;

        public varification()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.userLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.approveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLabel.ForeColor = System.Drawing.Color.Red;
            this.userLabel.Location = new System.Drawing.Point(12, 9);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(126, 29);
            this.userLabel.TabIndex = 0;
            this.userLabel.Text = "username:";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.Red;
            this.passwordLabel.Location = new System.Drawing.Point(12, 74);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(124, 29);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "password:";
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(17, 42);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(100, 20);
            this.usernameBox.TabIndex = 2;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(17, 116);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(100, 20);
            this.passwordBox.TabIndex = 3;
            // 
            // approveButton
            // 
            this.approveButton.BackColor = System.Drawing.Color.Green;
            this.approveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approveButton.ForeColor = System.Drawing.Color.White;
            this.approveButton.Location = new System.Drawing.Point(176, 42);
            this.approveButton.Name = "approveButton";
            this.approveButton.Size = new System.Drawing.Size(100, 50);
            this.approveButton.TabIndex = 4;
            this.approveButton.Text = "O.K";
            this.approveButton.UseVisualStyleBackColor = false;
            this.approveButton.Click += new System.EventHandler(this.approveButton_Click);
            // 
            // varification
            // 
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(344, 181);
            this.Controls.Add(this.approveButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userLabel);
            this.Name = "varification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void approveButton_Click(object sender, EventArgs e)
        {
            string username = usernameBox.Text;
            string password = passwordBox.Text;
            //password in order to get manager priviliges
           if ((this.usernameBox.Text == "admin") && (this.passwordBox.Text == "admin"))
            {
                manager myFormManager = new manager();
                myFormManager.Show();
                this.Dispose(false);
            }
            else
            {
                MessageBox.Show("wrong username / password!\n");
            }
            
        }
    }
}
