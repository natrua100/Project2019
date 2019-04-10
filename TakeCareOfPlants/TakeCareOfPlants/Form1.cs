using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakeCareOfPlants
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 223)
            {
                panel1.Visible = false;
                panel1.Width = 68;
                bunifuTransition1.ShowSync(panel1);
            }
            else
            {
                panel1.Visible = true;
                panel1.Width = 223;
                bunifuTransition1.ShowSync(panel1);
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 223)
            {
                panel1.Visible = false;
                panel1.Width = 68;
                bunifuTransition1.ShowSync(panel1);
            }
            else
            {
                panel1.Visible = true;
                panel1.Width = 223;
                bunifuTransition1.ShowSync(panel1);
            }
        }
    }
}
