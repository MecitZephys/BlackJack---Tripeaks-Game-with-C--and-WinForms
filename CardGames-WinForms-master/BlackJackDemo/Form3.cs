using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace BlackJackDemo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Bitmap bm = new Bitmap(Properties.Resources.imlec);
            Cursor = new Cursor(bm.GetHicon());

        }
        private void theme_music_play()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "theme_music.wav";
            player.Play();
        }
        private void theme_music_stop()
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = "theme_music.wav";
            player.Stop();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            theme_music_play();
            Bitmap bm = new Bitmap(Properties.Resources.imlec);
            foreach (Control control in Controls)
                control.Cursor = new Cursor(bm.GetHicon());
        }
       
        private void pixtureBox14_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void pictureBox14_MouseLeave(object sender, EventArgs e)
        {
            pictureBox15.Visible = true;
        }

        private void pictureBox15_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox15.Visible = false;
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            Form form1 = new Form1();
            form1.Show();
            this.Hide();
            theme_music_stop();
        }

        private void pictureBox16_MouseLeave(object sender, EventArgs e)
        {
            pictureBox17.Visible = true;
        }

        private void pictureBox17_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox17.Visible = false;
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
