using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_1_Assignment_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            imgGood.Visible = false;
            imgBad.Visible = false;
        }

        private void btnGood_Click(object sender, EventArgs e)
        {
            imgGood.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            imgBad.Visible = true;  
        }
    }
}
