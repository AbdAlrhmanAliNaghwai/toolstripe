using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5th_homework
{
    public partial class Form1 : Form
    {
        public int Size = 8;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            this.lblText.Text = toolStripTextBox1.Text;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

            this.lblText.Font = new Font("microsoft sans", Size);
            Size += 4;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (Size == 0)
            {
                Size = 8;
            }

            this.lblText.Font = new Font("microsoft sans", Size);
            Size -= 4;
        }
    }
}
