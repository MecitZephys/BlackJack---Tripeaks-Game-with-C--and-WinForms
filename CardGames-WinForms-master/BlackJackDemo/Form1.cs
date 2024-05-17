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
    public partial class Form1 : Form
    {
        List<Kartlar> OyuncuKartListesi = new List<Kartlar>()
        {
            new Kartlar() { deger  = 0, isim = "null", Resim = "null" }
        };
        List<Kartlar> BankaKartListesi = new List<Kartlar>()
        {
            new Kartlar() { deger  = 0, isim = "null", Resim = "null" }
        };
        //Deste oluşturduk (Listeye Resimleri attık)
        SoundPlayer sp = new SoundPlayer(Properties.Resources.dialogue_blip__mp3cut_net_);
        int oyuncuKartToplam = 0;
        int bankaKartToplam = 0;
        Random random = new Random();
        int tetikleme = 0;
        int oyuncucekilen = 0;
        int bankacekilen = 0;
        bool candrag = true;
        bool candragbank = true;
        List<Kartlar> Deste = new List<Kartlar>()
        {
                //MAÇA
                new Kartlar() { deger  = 2, isim = "Maça İki", Resim = "2_spade.png" },
                new Kartlar() { deger = 3, isim = "Maça Üç", Resim = "3_spade.png"},
                new Kartlar() { deger = 4, isim =  "Maça Dört", Resim = "4_spade.png"},
                new Kartlar() { deger = 5, isim = "Maça Beş", Resim = "5_spade.png" },
                new Kartlar() { deger = 6, isim = "Maça Altı", Resim = "6_spade.png" },
                new Kartlar() { deger = 7, isim = "Maça Yedi", Resim = "7_spade.png" },
                new Kartlar() { deger = 8, isim = "Maça Sekiz", Resim = "8_spade.png" },
                new Kartlar() { deger = 9, isim = "Maça Dokuz", Resim = "9_spade.png" },
                new Kartlar() { deger = 10, isim = "Maça On", Resim = "10_spade.png" },
                new Kartlar() { deger = 10, isim = "Maça Vale", Resim = "11_spade.png" },
                new Kartlar() { deger = 10, isim = "Maça Kız", Resim = "12_spade.png" },
                new Kartlar(){ deger = 10, isim = "Maça Kral", Resim = "13_spade.png" },
                new Kartlar(){ deger = 11, isim = "Maça As", Resim = "1_spade.png" },
                //KARO
                new Kartlar() { deger  = 2, isim = "Karo İki", Resim = "2_diamond.png" },
                new Kartlar() { deger = 3, isim = "Karo Üç", Resim = "3_diamond.png" },
                new Kartlar() { deger = 4, isim =  "Karo Dört", Resim = "4_diamond.png"},
                new Kartlar() { deger = 5, isim = "Karo Beş", Resim = "5_diamond.png" },
                new Kartlar() { deger = 6, isim = "Karo Altı", Resim = "6_diamond.png" },
                new Kartlar(){ deger = 7, isim = "Karo Yedi", Resim = "7_diamond.png" },
                new Kartlar() { deger = 8, isim = "Karo Sekiz", Resim = "8_diamond.png" },
                new Kartlar() { deger = 9, isim = "Karo Dokuz", Resim = "9_diamond.png" },
                new Kartlar() { deger = 10, isim = "Karo On", Resim = "10_diamond.png" },
                new Kartlar() { deger = 10, isim = "Karo Vale", Resim = "11_diamond.png" },
                new Kartlar() { deger = 10, isim = "Karo Kız", Resim = "12_diamond.png" },
                new Kartlar(){ deger = 10, isim = "Karo Kral", Resim = "13_diamond.png" },
                new Kartlar(){ deger = 11, isim = "Karo As", Resim = "1_diamond.png" },
                //SİNEK
                new Kartlar() { deger  = 2, isim = "Sinek İki", Resim = "2_club.png" },
                new Kartlar() { deger = 3, isim = "Sinek Üç", Resim = "3_club.png" },
                new Kartlar() { deger = 4, isim =  "Sinek Dört", Resim = "4_club.png"},
                new Kartlar() { deger = 5, isim = "Sinek Beş", Resim = "5_club.png" },
                new Kartlar() { deger = 6, isim = "Sinek Altı", Resim = "6_club.png" },
                new Kartlar(){ deger = 7, isim = "Sinek Yedi", Resim = "7_club.png" },
                new Kartlar() { deger = 8, isim = "Sinek Sekiz", Resim = "8_club.png" },
                new Kartlar() { deger = 9, isim = "Sinek Dokuz", Resim= "9_club.png" },
                new Kartlar() { deger = 10, isim = "Sinek On", Resim = "10_club.png" },
                new Kartlar() { deger = 10, isim = "Sinek Vale", Resim = "11_club.png" },
                new Kartlar() { deger = 10, isim = "Sinek Kız", Resim = "12_club.png" },
                new Kartlar(){ deger = 10, isim = "Sinek Kral", Resim = "13_club.png" },
                new Kartlar(){ deger = 11, isim = "Sinek As", Resim = "1_club.png" },
                //KUPA
                new Kartlar() { deger  = 2, isim = "Kupa İki", Resim = "2_heart.png" },
                new Kartlar() { deger = 3, isim = "Kupa Üç", Resim = "3_heart.png" },
                new Kartlar() { deger = 4, isim =  "Kupa Dört", Resim = "4_heart.png"},
                new Kartlar() { deger = 5, isim = "Kupa Beş", Resim = "5_heart.png" },
                new Kartlar() { deger = 6, isim = "Kupa Altı", Resim = "6_heart.png" },
                new Kartlar(){ deger = 7, isim = "Kupa Yedi", Resim = "7_heart.png" },
                new Kartlar() { deger = 8, isim = "Kupa Sekiz", Resim = "8_heart.png" },
                new Kartlar() { deger = 9, isim = "Kupa Dokuz", Resim = "9_heart.png" },
                new Kartlar() { deger = 10, isim = "Kupa On", Resim = "10_heart.png" },
                new Kartlar() { deger = 10, isim = "Kupa Vale", Resim = "11_heart.png" },
                new Kartlar() { deger = 10, isim = "Kupa Kız", Resim = "12_heart.png" },
                new Kartlar(){ deger = 10, isim = "Kupa Kral", Resim = "13_heart.png" },
                new Kartlar(){ deger = 11, isim = "Kupa As", Resim = "1_heart.png" }
        };
        List<int> kullanılmışKartlar = new List<int>(); 
        public Form1()
        {
            InitializeComponent();
            //Formu büyütme
            this.WindowState = FormWindowState.Maximized;
            //Picture boyutlandırma
            pictureBox4.Location = new Point(pictureBox7.Location.X + 104, pictureBox7.Location.Y);
            pictureBox5.Location = new Point(pictureBox7.Location.X + 208, pictureBox7.Location.Y);
            pictureBox5.Size = new Size(90, 120);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.Size = new Size(90, 120);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.Size = new Size(90, 120);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.Size = new Size(90, 120);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Size = new Size(90, 120);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.Size = new Size(90, 120);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            Bitmap bm = new Bitmap(Properties.Resources.imlec);
            Cursor = new Cursor(bm.GetHicon());
            pictureBox6.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox16.Visible = false;
            pictureBox6.Visible = false;

            //Kurpiyer
            pictureBox14.Visible = false;
            pictureBox13.Visible = false;
            label6.Visible = false;
            

            int rastgele1 = RastgeleDeste();            
            int rastgele2 = RastgeleDeste();
            int rastgele3 = RastgeleDeste();
            while (kullanılmışKartlar.Contains(rastgele2))
            {
                rastgele2 = RastgeleDeste();
            }
            while (kullanılmışKartlar.Contains(rastgele3))
            {
                rastgele3 = RastgeleDeste();
            }
            kullanılmışKartlar.Add(rastgele1);
            kullanılmışKartlar.Add(rastgele2);
            kullanılmışKartlar.Add(rastgele3);
            //Oyuncu kartı
            Kartlar kart1 = Deste[rastgele1];            
            Kartlar kart2 = Deste[rastgele2]; 
            //Banka kartı
            Kartlar kart3 = Deste[rastgele3];
            OyuncuKartListesi.Add(kart1);
            OyuncuKartListesi.Add(kart2);
            BankaKartListesi.Add(kart3);
            //Başlangıç Kartları
            pictureBox4.Image = Image.FromFile(Application.StartupPath + "\\" + kart1.Resim);         
            pictureBox5.Image = Image.FromFile(Application.StartupPath + "\\" + kart2.Resim);
            pictureBox3.Image = Image.FromFile(Application.StartupPath + "\\" + kart3.Resim);
            //Oyuncu sayısı kaç olduğu
            label4.Text = (Convert.ToString(Oyuncuhesapla()));
            //Banka sayısı kaç olduğu
            label5.Text = (Convert.ToString(BankaHesapla()));
            Bitmap bm = new Bitmap(Properties.Resources.imlec);
            foreach (Control control in Controls)
                control.Cursor = new Cursor(bm.GetHicon());
            
        }
        public int BankaHesapla()
        {
            bankaKartToplam = 0;
            for (int i = 0; i < BankaKartListesi.Count; i++)
            {
                bankaKartToplam += BankaKartListesi[i].deger;
            }
            //Ası 1/11 yapma
            if (bankaKartToplam > 21
                && BankaKartListesi.Any(o => o.isim.Contains("As")))
            {
                List<Kartlar> aslar = BankaKartListesi.Where(o => o.isim.Contains("As")).ToList();
                bankaKartToplam -= (10 * aslar.Count());
            }
            return bankaKartToplam;
        }
        public int Oyuncuhesapla()
        {
            oyuncuKartToplam = 0;
            for (int i = 0; i < OyuncuKartListesi.Count; i++)
            {
                oyuncuKartToplam += OyuncuKartListesi[i].deger;
            }
            //Ası 1/11 yapma
            if (oyuncuKartToplam > 21
                && OyuncuKartListesi.Any(o => o.isim.Contains("As")))
            {
                List<Kartlar> aslar = OyuncuKartListesi.Where(o => o.isim.Contains("As")).ToList();
                oyuncuKartToplam -= (10 * aslar.Count());
            }
            return oyuncuKartToplam;
        }        
        private int RastgeleDeste()
        {
            int randomCard;
            randomCard = random.Next(0, Deste.Count);
            return randomCard;
        }        
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (!candrag)
                return;
            int rastgeleçek = RastgeleDeste();
            //kullanılmış kart mı diye kontrol ediyoruz..
            while (kullanılmışKartlar.Contains(rastgeleçek))
            {
                rastgeleçek = RastgeleDeste();
            }
            Kartlar elkart = Deste[rastgeleçek];
            OyuncuKartListesi.Add(elkart);
            kullanılmışKartlar.Add(rastgeleçek);
            //Oyuncu Kartı gösterme
            label4.Text = (Convert.ToString(Oyuncuhesapla()));
            //Oyuncu Kart çekme
            if (oyuncuKartToplam <= 21)
            {
                PictureBox pics = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(pictureBox7.Location.X, 610),
                    Image = Image.FromFile(Application.StartupPath + "\\" + elkart.Resim),
                    Size = new Size(90, 120),
                    BackColor = Color.Transparent                   
                    
                };
                this.Controls.Add(pics);
                pics.Cursor = Cursor;
                pics.BringToFront();
                OyuncuKartListesi.Last().pcb = pics;
            }
            else 
            {
                PictureBox picturs = new PictureBox
                {
                    
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(pictureBox7.Location.X, 610),
                    Image = Image.FromFile(Application.StartupPath + "\\" + elkart.Resim),
                    Size = new Size(90, 120),
                    BackColor = Color.Transparent
                };

                this.Controls.Add(picturs);
                picturs.Cursor = Cursor;
                picturs.BringToFront();
                OyuncuKartListesi.Last().pcb = picturs;
                
            }
            
            oyuncucekilen++;
            timer1.Start();
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (!candragbank)            
                return;            
            int rastgeleBanka = RastgeleDeste();
            //kullanılmış kart mı diye kontrol ediyoruz..
            while (kullanılmışKartlar.Contains(rastgeleBanka))
            {
                rastgeleBanka = RastgeleDeste();
            }
            Kartlar bankakart = Deste[rastgeleBanka];
            BankaKartListesi.Add(bankakart);
            kullanılmışKartlar.Add(rastgeleBanka);
            //Banka Kartı gösterme
            
                PictureBox picturs = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(pictureBox6.Location.X, 38),
                    Image = Image.FromFile(Application.StartupPath + "\\" + bankakart.Resim),
                    Size = new Size(90, 120),
                    BackColor = Color.Transparent
                };
                BankaKartListesi.Last().pcb = picturs;
                this.Controls.Add(picturs);
                picturs.Cursor = Cursor;
            picturs.Cursor = Cursor;
            
            bankacekilen++;
            timer2.Start();
            label5.Text = (Convert.ToString(BankaHesapla()));
        }
        public void checkWin()
        {
            if (oyuncuKartToplam > 21)
            {
                
                Form8 fr8 = new Form8(false, Oyuncuhesapla(), BankaHesapla());
                fr8.StartPosition = FormStartPosition.CenterScreen;
                fr8.Show();
                this.Enabled = false;
            }
        }

        public void checkWinbank()
        {
            if (bankaKartToplam > 21)
            {
                Form8 fr8 = new Form8(true, Oyuncuhesapla(), BankaHesapla());
                fr8.StartPosition = FormStartPosition.CenterScreen;
                fr8.Show();
                this.Enabled = false;
            }
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (OyuncuKartListesi.Last().pcb.Location.X < 275 + (105 * oyuncucekilen))
            {
                candrag = false;
                OyuncuKartListesi.Last().pcb.Location = new Point(OyuncuKartListesi.Last().pcb.Location.X + 15, OyuncuKartListesi.Last().pcb.Location.Y);
            }        
            else
            {
                timer1.Stop();
                candrag = true;
                checkWin();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (BankaKartListesi.Last().pcb.Location.X > 855 - (90* bankacekilen))
            {
                candragbank = false;
                BankaKartListesi.Last().pcb.Location = new Point(BankaKartListesi.Last().pcb.Location.X - 19, BankaKartListesi.Last().pcb.Location.Y);

            }
            else
            {
                timer2.Stop();
                candragbank = true;
                checkWinbank();
            }
        }        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Close();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {

        }
        private string text;
        private int len = 0;
        private void timer3_Tick(object sender, EventArgs e)
        {
            

            if (len < text.Length)
            {
                label6.Text = label6.Text + text.ElementAt(len);
                len++;
            }
            else
            {
                sp.Stop();
                System.Threading.Thread.Sleep(1000);
                timer3.Stop();
                pictureBox14.Visible = false;
                label6.Visible = false;
                len = 0;
            }

        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox16.Visible = true;
            pictureBox15.Visible = false;
            pictureBox13.Visible = true;
            timer4.Interval = 1;
            timer4.Start();



            pictureBox6.Visible = true;
            pictureBox7.Visible = false;
            int RastgeleBanka = RastgeleDeste();
            //Banka Kart çekiyor..
            while (kullanılmışKartlar.Contains(RastgeleBanka))
            {
                RastgeleBanka = RastgeleDeste();
            }
            Kartlar bankaKart = Deste[RastgeleBanka];
            BankaKartListesi.Add(bankaKart);
            kullanılmışKartlar.Add(RastgeleBanka);
            pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\" + bankaKart.Resim);

            if (bankaKartToplam > 21)
            {
                Form8 fr8 = new Form8(false,Oyuncuhesapla(),BankaHesapla());
                fr8.StartPosition = FormStartPosition.CenterScreen;
                fr8.Show();
            }
            label5.Text = (Convert.ToString(BankaHesapla()));
            tetikleme++;


        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (tetikleme > 0)
            {// bu if sayesinde button1 e zoruri 1 kere basıldıktan sonra bu button2 çalışacaktır..
                Oyuncuhesapla();
                BankaHesapla();
                if (bankaKartToplam > oyuncuKartToplam)
                {
                    Form8 fr8 = new Form8(false, Oyuncuhesapla(), BankaHesapla());
                    fr8.StartPosition = FormStartPosition.CenterScreen;
                    fr8.Show();
                    this.Enabled = false;
                    
                }
                else
                {
                    Form8 fr8 = new Form8(true, Oyuncuhesapla(), BankaHesapla());
                    fr8.StartPosition = FormStartPosition.CenterScreen;
                    fr8.Show();
                    this.Enabled = false;
                }
            }
        }

        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.card_back_bright;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.card_back;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.homebright;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.home;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Properties.Resources.homedark;
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox7.Image = Properties.Resources.card_back_dark;
        }

        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.card_back_bright;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            pictureBox6.Image = Properties.Resources.card_back;
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox6.Image = Properties.Resources.card_back_dark;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            //1694; 275
            if(pictureBox13.Location.Y < 225)
            {
                pictureBox13.Location = new Point(pictureBox13.Location.X,pictureBox13.Location.Y+6);
            }
            else
            {
                timer4.Stop();
                //yazı animasyon

                text = "Benim sıram..!!";
                label6.Text = "";
                timer3.Interval = 80;
                
                pictureBox14.Visible = true;
                label6.Visible = true;
                timer3.Start();
                
                sp.Play();
                
            }
        }
    }
}