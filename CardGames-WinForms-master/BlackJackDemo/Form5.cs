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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            Bitmap bm = new Bitmap(Properties.Resources.imlec);
            Cursor = new Cursor(bm.GetHicon());
          
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Bitmap bm = new Bitmap(Properties.Resources.imlec);
            foreach (Control control in Controls)
                control.Cursor = new Cursor(bm.GetHicon());

            label1.Text = Form4.yüksekZincir.ToString();
            label3.Text = Form4.yüksekSkor.ToString();
            label2.Text = Form4.yüksekSilinenKartlar.ToString();
        }

        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox6.Visible = false;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
