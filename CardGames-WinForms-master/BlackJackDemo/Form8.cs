using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackDemo
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }
        public Form8(bool IsWın,int a,int b)
        {
            InitializeComponent();
            if (IsWın)
                pictureBox1.Image= Properties.Resources.kazandınız;
            else
                pictureBox1.Image = Properties.Resources.kaybettiniz;

            label4.Text = a.ToString();

            label3.Text = b.ToString();
        }

        private void pictureBox34_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox34.Visible = false;
        }

        private void pictureBox35_MouseLeave(object sender, EventArgs e)
        {
            pictureBox34.Visible = true;
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();            
            Form1 form1 = new Form1();
            form1.Enabled = true;
            form1.Close();

        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Visible = false;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Close();
        }
    }
}
