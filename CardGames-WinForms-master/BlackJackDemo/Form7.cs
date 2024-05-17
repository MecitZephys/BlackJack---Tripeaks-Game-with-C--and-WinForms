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
    public partial class Form7 : Form
    {

        public static int Deste = 20;
        public static int dakika = 1;

        public Form7()
        {
            InitializeComponent();
            Bitmap bm = new Bitmap(Properties.Resources.imlec);
            foreach (Control control in Controls)
                control.Cursor = new Cursor(bm.GetHicon());
        }

        private void pictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.Visible = false;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Visible = true;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Close();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox1.Visible = false;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }       

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            
        }              
                

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            dakika = 2;
            pictureBox13.Visible = false;
            pictureBox11.Visible = false;
            pictureBox14.Visible = true;
        }        

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            dakika = 0;
            pictureBox14.Visible = false;
            pictureBox11.Visible = false;
            pictureBox13.Visible = true;
        }

        
        private void Form7_Load(object sender, EventArgs e)
        {
            if(dakika == 2)
            {
                dakika = 2;
                pictureBox13.Visible = false;
                pictureBox11.Visible = false;
                pictureBox14.Visible = true;
            }
            else if(dakika == 1)
            {                

                if (pictureBox14.Visible == false && pictureBox13.Visible == true && pictureBox11.Visible == false)
                {

                    dakika = 1;
                    pictureBox11.Visible = true;
                    pictureBox14.Visible = true;
                    pictureBox13.Visible = true;

                }
                else if (pictureBox14.Visible == true && pictureBox13.Visible == false && pictureBox11.Visible == false)
                {

                    dakika = 1;
                    pictureBox11.Visible = true;
                    pictureBox14.Visible = true;
                    pictureBox13.Visible = true;

                }
            }
            else
            {
                dakika = 0;
                pictureBox14.Visible = false;
                pictureBox11.Visible = false;
                pictureBox13.Visible = true;
            }

            if(Deste == 25)
            {
                Deste = 25;
                pictureBox18.Visible = false;
                pictureBox20.Visible = false;
                pictureBox16.Visible = true;
            }
            else if (Deste == 20)
            {
                if (pictureBox18.Visible == false && pictureBox20.Visible == false && pictureBox16.Visible == true)
                {
                    Deste = 20;
                    pictureBox20.Visible = true;
                    pictureBox16.Visible = true;
                    pictureBox18.Visible = true;
                }
                else if (pictureBox18.Visible == true && pictureBox20.Visible == false && pictureBox16.Visible == false)
                {
                    Deste = 20;
                    pictureBox20.Visible = true;
                    pictureBox16.Visible = true;
                    pictureBox18.Visible = true;

                }
            }
            else
            {
                Deste = 15;
                pictureBox16.Visible = false;
                pictureBox20.Visible = false;
                pictureBox18.Visible = true;
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (pictureBox14.Visible == false && pictureBox13.Visible == true && pictureBox11.Visible == false)
            {

                dakika = 1;
                pictureBox11.Visible = true;
                pictureBox14.Visible = true;
                pictureBox13.Visible = true;

            }
            else if (pictureBox14.Visible == true && pictureBox13.Visible == false && pictureBox11.Visible == false)
            {

                dakika = 1;
                pictureBox11.Visible = true;
                pictureBox14.Visible = true;
                pictureBox13.Visible = true;

            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            if (pictureBox18.Visible == false && pictureBox20.Visible == false && pictureBox16.Visible == true)
            {
                Deste = 20;
                pictureBox20.Visible = true;
                pictureBox16.Visible = true;
                pictureBox18.Visible = true;
            }else if (pictureBox18.Visible == true && pictureBox20.Visible == false && pictureBox16.Visible == false)
            {
                Deste = 20;
                pictureBox20.Visible = true;
                pictureBox16.Visible = true;
                pictureBox18.Visible = true;

            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            Deste = 25;
            pictureBox18.Visible = false;
            pictureBox20.Visible = false;
            pictureBox16.Visible = true;
            
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Deste = 15;
            pictureBox16.Visible = false;
            pictureBox20.Visible = false;
            pictureBox18.Visible = true;
        }
    }
}
