using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mySurvey
{
    public partial class query : Form
    {
        public query()
        {
            InitializeComponent();
        }
        public query(string take)
        {
            InitializeComponent();
            queryBox.Text = take;
           primaryLabel.Text = Form1.theHeadline;
        }

        public void SetQueryBoxText(string take)
        {
           queryBox.Text = take;
        }
    }
}
