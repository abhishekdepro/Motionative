using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Calculator;

namespace Motionative
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LblDateTime.Text = System.DateTime.Now.Date.ToString("dd-MMM-yyyy");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
              
        }
    }
}
