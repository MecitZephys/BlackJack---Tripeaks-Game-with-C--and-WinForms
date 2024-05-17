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
    public partial class Form10 : Form
    {

        
        public Form10()
        {
            InitializeComponent();
        }

        private void pictureBox34_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox34.Visible = false;
        }

        private void pictureBox35_MouseLeave(object sender, EventArgs e)
        {
            pictureBox34.Visible = true;

        }        

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            

            if (Form4.zincir > Form4.yüksekZincir)
            {
                Form4.yüksekZincir = Form4.zincir;
            }

            if (Form4.skor > Form4.yüksekSkor)
            {
                Form4.yüksekSkor = Form4.skor;
            }

            if (Form4.silinenKartlar > Form4.yüksekSilinenKartlar)
            {
                Form4.yüksekSilinenKartlar = Form4.silinenKartlar;
            }

            Form4 form4 = new Form4();
            form4.Show();
            this.Close();
        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {

            if (Form4.zincir > Form4.yüksekZincir)
            {
                Form4.yüksekZincir = Form4.zincir;
            }

            if (Form4.skor > Form4.yüksekSkor)
            {
                Form4.yüksekSkor = Form4.skor;
            }

            if (Form4.silinenKartlar > Form4.yüksekSilinenKartlar)
            {
                Form4.yüksekSilinenKartlar = Form4.silinenKartlar;
            }
            Form2 form2 = new Form2();
            form2.Show();
            this.Close();
            
        }

        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox2.Visible = false;
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            
            label8.Text = Form4.skor.ToString();
            label5.Text = Form4.silinenKartlar.ToString();
        }

       
    }
}
