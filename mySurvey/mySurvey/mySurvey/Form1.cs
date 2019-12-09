using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mySurvey
{
    public partial class Form1 : Form
    {
        public static string theHeadline = "Life Mate Survey - totally anonymous";
        private DateTime _start;
        public Form1()
        {
            InitializeComponent();

        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            {
                Form1 NewForm = new Form1();
                NewForm.Show();
                this.Dispose(false);
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string path = @"c:\Test\";
            string pathWithFileExtention = "";
            if (Directory.Exists(path))
            {
                 pathWithFileExtention = path + DateTime.Now.ToString("ddMMyyhhmmss") + ".txt";
            }
            else
            {
                DirectoryInfo di = Directory.CreateDirectory(path);
                pathWithFileExtention = path + DateTime.Now.ToString("ddMMyyhhmmss") + ".txt";
            }
            using (FileStream fs = new FileStream(pathWithFileExtention, FileMode.CreateNew))
            {
                RadioButton rb = null;
                using (TextWriter tw = new StreamWriter(fs))
                {
                    tw.WriteLine("first name:" + fNameBox.Text);
                    tw.WriteLine("last name:" + lNameBox.Text);
                    tw.WriteLine("email:" + emailBox.Text);
                    tw.WriteLine("number" + mobileBox.Text);

                    if (maleButton.Checked == true)
                    {
                        rb = maleButton;
                    }
                    else if (femaleButton.Checked == true)
                    {
                        rb = femaleButton;
                    }
                    tw.WriteLine("gender:" + rb.Text);
                    if (kindCheck.Checked == true)
                        tw.WriteLine("kind:" + kindCheck.Text);
                    if (carryCheck.Checked == true)
                        tw.WriteLine("carry:" + carryCheck.Text);
                    if (motivatedCheck.Checked == true)
                        tw.WriteLine("motivated:" + motivatedCheck.Text);
                    if (jelousCheck.Checked == true)
                        tw.WriteLine("jelous:" + jelousCheck.Text);
                    if (annoyingCheck.Checked == true)
                        tw.WriteLine("annoying:" + annoyingCheck.Text);
                    if (lazyCheck.Checked == true)
                        tw.WriteLine("lazy:" + lazyCheck.Text);
                    if (crazyCheck.Checked == true)
                        tw.WriteLine("crazy:" + crazyCheck.Text);
                    tw.WriteLine("dateLocation:" + ListDateLocation.Text);
                    tw.WriteLine("food:" + ComboFood.SelectedItem.ToString());
                    tw.WriteLine("theday:" + comboDay.SelectedItem.ToString());
                }

                Form1 NewForm = new Form1();
                NewForm.Show();
                this.Dispose(false);

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            _start = DateTime.Now;
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan duration = DateTime.Now - _start;
            clockBox.Text = duration.ToString("hh");
            clockBox.AppendText(":");
            clockBox.AppendText(duration.ToString("mm"));
            clockBox.AppendText(":");
            clockBox.AppendText(duration.ToString("ss"));
        }

        private void emailBox_Validating(object sender, CancelEventArgs e)
        {

            System.Text.RegularExpressions.Regex rEMail = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (emailBox.Text.Length > 0)

            {

                if (!rEMail.IsMatch(emailBox.Text))

                {

                    MessageBox.Show("E-Mail expected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    emailBox.SelectAll();

                    e.Cancel = true;

                }

            }

        }

        private void mobileBox_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void ComboFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filepath = @"C:\Test\" + ComboFood.SelectedItem.ToString().Trim() + ".jpg";
            if (File.Exists(filepath))
            {
                foodPicBox.ImageLocation = filepath;
                foodPicBox.Load(filepath);
                foodPicBox.Update();
                foodPicBox.Refresh();
                foodPicBox.Visible = true;
            }
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            varification myForm = new varification();
            myForm.Show();
        }
    }
}
