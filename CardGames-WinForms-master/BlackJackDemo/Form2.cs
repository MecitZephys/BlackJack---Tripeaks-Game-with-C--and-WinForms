using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace BlackJackDemo
{
    public partial class Form2 : Form
    {

        bool wakeupFox = false;
        public Form2()
        {
            InitializeComponent();
            Bitmap bm = new Bitmap(Properties.Resources.imlec);
            Cursor = new Cursor(bm.GetHicon());
            pictureBox6.Visible = false;
        }

        private void theme_music_play()
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.Legend_of_Zelda___Skyward_Sword___Main_Menu_Theme__mp3cut_net_);            
            player.Play();
        }

        private void theme_music_stop()
        {
            SoundPlayer player = new SoundPlayer(Properties.Resources.Legend_of_Zelda___Skyward_Sword___Main_Menu_Theme__mp3cut_net_);            
            player.Stop();
        } 
        
        private void Form2_Load(object sender, EventArgs e)
        {
            
            pictureBox13.Visible = false;//HighScore
            label4.Visible = false;
            label3.Visible = false;
            label2.Visible = false;
            label1.Visible = false;
            pictureBox11.Visible = false;
            this.WindowState = FormWindowState.Maximized;
            theme_music_play();
            Bitmap bm = new Bitmap(Properties.Resources.imlec);
            foreach (Control control in Controls)
                control.Cursor = new Cursor(bm.GetHicon());
        }  
        
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            theme_music_stop();
            pictureBox3.Visible = false;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            theme_music_play();
            pictureBox3.Visible = true;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Visible = true;
        }            
        private void pictureBox6_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox6.Visible=false;
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //buton sesi
            SoundPlayer player = new SoundPlayer(Properties.Resources.mc_buton);            
            player.Play();

            theme_music_stop(); //tema müziği sesi
            Form1 form = new Form1();
            form.Show();
            this.Hide();
            
        }

        private void pictureBox8_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox8.Visible=false;
            pictureBox13.Visible = true;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Visible=true;
            pictureBox13.Visible = false;
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            //buton sesi
            SoundPlayer player = new SoundPlayer(Properties.Resources.mc_buton);
            player.Play();
            //tema müziği durudrma
            theme_music_stop();

            Form4 form = new Form4();
            form.Show();
            this.Hide();
            
           
        }        

        private void pictureBox10_Click(object sender, EventArgs e)
        {

            label4.Visible = true;
            label3.Visible = true;
            label2.Visible = true;
            label1.Visible = true;
            pictureBox11.Visible = true;
            wakeupFox = true;            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form7 form = new Form7();                               
            form.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            label4.Visible = false;
            label3.Visible = false;
            label2.Visible = false;
            label1.Visible = false;
            pictureBox11.Visible = false;
            wakeupFox=false;
            pictureBox12.Visible = true;
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6();
            form6.Show();
            this.Hide();
        }

        private void pictureBox12_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox12.Visible = false;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            if(wakeupFox == false)
            {
                pictureBox12.Visible = true;
            }            
            
        }
        
        private void pictureBox13_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.setting_realbright;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.setting_bright;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
