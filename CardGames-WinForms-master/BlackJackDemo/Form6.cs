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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            Bitmap bm = new Bitmap(Properties.Resources.imlec);
            Cursor = new Cursor(bm.GetHicon());
            pictureBox6.Visible = false;

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Bitmap bm = new Bitmap(Properties.Resources.imlec);
            foreach (Control control in Controls)
                control.Cursor = new Cursor(bm.GetHicon());
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Close();
        }

        private void pictureBox34_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox34.Visible = false;
        }

        private void pictureBox35_MouseLeave(object sender, EventArgs e)
        {
            pictureBox34.Visible = true;
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4();
            form.Show();
            this.Close();
        }

        private void pictureBox37_MouseLeave(object sender, EventArgs e)
        {
            pictureBox36.Visible = true;
        }

        private void pictureBox36_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox36.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
