using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace mySurvey
{
    public class manager : Form
    {
        private ListView listView1;
        private DirectoryInfo dir;
        private ColumnHeader nameCol;
        private ColumnHeader genderCol;
        private ColumnHeader favFoodCol;
        private Button updateButton;
        private ColumnHeader columnHeader1;
        private Button button1;
        private Label adminPriv;
        public static List<String> takeName = new List<String>();

        public manager()
        {
            InitializeComponent();
            query myQuery = new query();
        }

        private void InitializeComponent()

        {
            this.adminPriv = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genderCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.favFoodCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.updateButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adminPriv
            // 
            this.adminPriv.AutoSize = true;
            this.adminPriv.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPriv.Location = new System.Drawing.Point(13, 13);
            this.adminPriv.Name = "adminPriv";
            this.adminPriv.Size = new System.Drawing.Size(206, 31);
            this.adminPriv.TabIndex = 0;
            this.adminPriv.Text = "Admin Priviliges";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.nameCol,
            this.genderCol,
            this.favFoodCol});
            this.listView1.Location = new System.Drawing.Point(453, 23);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(320, 97);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // nameCol
            // 
            this.nameCol.Text = "name";
            this.nameCol.Width = 108;
            // 
            // genderCol
            // 
            this.genderCol.Text = "gender";
            this.genderCol.Width = 103;
            // 
            // favFoodCol
            // 
            this.favFoodCol.Text = "Fav Food";
            this.favFoodCol.Width = 105;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Navy;
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.Location = new System.Drawing.Point(279, 23);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(120, 23);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update Table";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(70, 147);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "query Names";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // manager
            // 
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(823, 329);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.adminPriv);
            this.Name = "manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //table
            //
            string contentss;
            dir = new DirectoryInfo(@"C:\Users\yoni\source\repos\mySurvey\mySurvey\submitted");
            foreach (FileInfo fi in dir.GetFiles())
            {
                String st2 = @"C:\Users\yoni\source\repos\mySurvey\mySurvey\submitted\" + fi.Name.ToString();
                var filestream = new System.IO.FileStream(st2,
                                             System.IO.FileMode.Open,
                                             System.IO.FileAccess.Read,
                                             System.IO.FileShare.ReadWrite);
                var file = new System.IO.StreamReader(filestream, System.Text.Encoding.UTF8, true, 128);
                ListViewItem temp;
                contentss = file.ReadLine();

                if (contentss != null) // for all rows 
                {

                    temp = new ListViewItem();
                    listView1.Items.Add(temp);
                    while (contentss != null) // scan one row 
                    {
                        if (contentss.Contains("first name:"))
                        {

                            string ext = contentss.Substring((contentss.IndexOf(":")) + 1);
                            temp.SubItems.Add(ext);
                            takeName.Add(ext);
                            //MessageBox.Show(takeName[i] + "  " + i);
                            //i++;
                        }
                        if (contentss.Contains("gender:"))
                        {
                            string ext = contentss.Substring((contentss.IndexOf(":")) + 1);
                            temp.SubItems.Add(ext);
                        }
                        if (contentss.Contains("food:"))
                        {
                            string ext = contentss.Substring((contentss.IndexOf(":")) + 1);
                            temp.SubItems.Add(ext);
                        }
                        contentss = file.ReadLine();
                    }
                }
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string st = "";
            foreach (string item in takeName)
            {
                st += item + "    ,";
            }
            query myQuery = new query(st);
            myQuery.Show();
        }
    }
}
