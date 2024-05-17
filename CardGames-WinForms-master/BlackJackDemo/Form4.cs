using BlackJackDemo.Properties;
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
    public partial class Form4 : Form
    {
        
        Kartlar[] ikinciKartDeğer = new Kartlar[9];
        Kartlar[] üçüncüKartDeğer = new Kartlar[6];
        Kartlar[] SonKartlarDeğer = new Kartlar[3];
        List<int> Masa = new List<int>();
        List<int> MasaRastgele = new List<int>();       
        List<Kartlar> MasaId = new List<Kartlar>()
        {

        };

        List<Kartlar> El = new List<Kartlar>()
        {
            new Kartlar() { deger = 0, isim = "null", Resim = "null" }
        };

        
        List<Kartlar> GörünürListe = new List<Kartlar>();
        List<PictureBox> birinciDizi = new List<PictureBox>();
        List<PictureBox> ikinciDizi = new List<PictureBox>();
        List<PictureBox> üçünciDizi = new List<PictureBox>();
        List<PictureBox> dörtDizi = new List<PictureBox>();
        List<int> tıklanabilir = new List<int>();


        //Deste oluşturduk (Listeye Resimleri attık)        

        Random random = new Random();
        bool candrag = true;

        int desteKart = Form7.Deste;

        int dk = Form7.dakika;
        int saniye = 59;
        
        public static int zincir = 0;
        public static int yüksekZincir = 0;
        public static int skor = 0;
        public static int yüksekSkor = 0;
        public static int silinenKartlar = 0;
        public static int yüksekSilinenKartlar = 0;
       

        List<Kartlar> Deste = new List<Kartlar>()
        {

                new Kartlar() { deger = 0,desen = Kartlar.Desen.SARI , isim ="Sarı Sıfır", Resim="ss0.png"},
                new Kartlar() { deger = 1, isim = "Sarı Bir", Resim="ss1.png"},
                new Kartlar() { deger = 2, isim = "Sarı İki", Resim = "ss2.png" },
                new Kartlar() { deger = 3, isim = "Sarı Üç", Resim = "ss3.png"},
                new Kartlar() { deger = 4, isim =  "Sarı Dört", Resim = "ss4.png"},
                new Kartlar() { deger = 5, isim = "Sarı Beş", Resim = "ss5.png" },
                new Kartlar() { deger = 6, isim = "Sarı Altı", Resim = "ss6.png" },
                new Kartlar() { deger = 7, isim = "Sarı Yedi", Resim = "ss7.png" },
                new Kartlar() { deger = 8, isim = "Sarı Sekiz", Resim = "ss8.png" },
                new Kartlar() { deger = 9, isim = "Sarı Dokuz", Resim = "ss9.png" },

                new Kartlar() { deger = 0, isim = "Kırmızı Sıfır", Resim="gg0.png"},
                new Kartlar() { deger = 1, isim = "Kırmızı Bir", Resim="gg1.png"},
                new Kartlar() { deger  = 2, isim = "Kırmızı İki", Resim = "gg2.png" },
                new Kartlar() { deger = 3, isim = "Kırmızı Üç", Resim = "gg3.png" },
                new Kartlar() { deger = 4, isim =  "Kırmızı Dört", Resim = "gg4.png"},
                new Kartlar() { deger = 5, isim = "Kırmızı Beş", Resim = "gg5.png" },
                new Kartlar() { deger = 6, isim = "Kırmızı Altı", Resim = "gg6.png" },
                new Kartlar(){ deger = 7, isim = "Kırmızı Yedi", Resim = "gg7.png" },
                new Kartlar() { deger = 8, isim = "Kırmızı Sekiz", Resim = "gg8.png" },
                new Kartlar() { deger = 9, isim = "Kırmızı Dokuz", Resim = "gg9.png" },

                new Kartlar() { deger = 0, isim = "Yeşil Sıfır", Resim="k0.png"},
                new Kartlar() { deger = 1, isim = "Yeşil Bir", Resim="k1.png"},
                new Kartlar() { deger  = 2, isim = "Yeşil İki", Resim = "k2.png" },
                new Kartlar() { deger = 3, isim = "Yeşil Üç", Resim = "k3.png" },
                new Kartlar() { deger = 4, isim =  "Yeşil Dört", Resim = "k4.png"},
                new Kartlar() { deger = 5, isim = "Yeşil Beş", Resim = "k5.png" },
                new Kartlar() { deger = 6, isim = "Yeşil Altı", Resim = "k6.png" },
                new Kartlar(){ deger = 7, isim = "Yeşil Yedi", Resim = "k7.png" },
                new Kartlar() { deger = 8, isim = "Yeşil Sekiz", Resim= "k8.png" },
                new Kartlar() { deger = 9, isim = "Yeşil Dokuz", Resim= "k9.png" },

                new Kartlar() { deger = 0, isim = "Mavi Sıfır", Resim="bb0.png"},
                new Kartlar() { deger = 1, isim = "Mavi Bir", Resim="bb1.png"},
                new Kartlar() { deger  = 2, isim = "Mavi İki", Resim = "bb2.png" },
                new Kartlar() { deger = 3, isim = "Mavi Üç", Resim = "bb3.png" },
                new Kartlar() { deger = 4, isim =  "Mavi Dört", Resim = "bb4.png"},
                new Kartlar() { deger = 5, isim = "Mavi Beş", Resim = "bb5.png" },
                new Kartlar() { deger = 6, isim = "Mavi Altı", Resim = "bb6.png" },
                new Kartlar(){ deger = 7, isim = "Mavi Yedi", Resim = "bb7.png" },
                new Kartlar() { deger = 8, isim = "Mavi Sekiz", Resim = "bb8.png" },
                new Kartlar() { deger = 9, isim = "Mavi Dokuz", Resim = "bb9.png" },

                 new Kartlar() { deger = 0, isim = "Mavi Sıfır", Resim="t0.png"},
                new Kartlar() { deger = 1, isim = "Mavi Bir", Resim="t1.png"},
                new Kartlar() { deger  = 2, isim = "Mavi İki", Resim = "t2.png" },
                new Kartlar() { deger = 3, isim = "Mavi Üç", Resim = "t3.png" },
                new Kartlar() { deger = 4, isim =  "Mavi Dört", Resim = "t4.png"},
                new Kartlar() { deger = 5, isim = "Mavi Beş", Resim = "t5.png" },
                new Kartlar() { deger = 6, isim = "Mavi Altı", Resim = "t6.png" },
                new Kartlar(){ deger = 7, isim = "Mavi Yedi", Resim = "t7.png" },
                new Kartlar() { deger = 8, isim = "Mavi Sekiz", Resim = "t8.png" },
                new Kartlar() { deger = 9, isim = "Mavi Dokuz", Resim = "t9.png" },


        };
        
        public Form4()
        {
            InitializeComponent();
            Bitmap bm = new Bitmap(Properties.Resources.imlec);
            Cursor = new Cursor(bm.GetHicon());
            playmusic();

        }
        private void Form4_Load(object sender, EventArgs e)
        {
            skor = 0;
            silinenKartlar = 0;
            zincir = 0;
            pictureBox34.Visible = false;
            pictureBox35.Visible = false;
            label3.Text = dk.ToString();
            timer3.Interval = 60000;// her 60 sny de 
            timer2.Interval = 1000;//her 1 saniye de 
            timer3.Start();//Dakika
            timer2.Start();//Saniye

            label1.Text = desteKart.ToString();
            //Masada ki Birinci Dizileri sıraya koy
            birinciDizi.Add(pictureBox8);
            birinciDizi.Add(pictureBox9);
            birinciDizi.Add(pictureBox10);
            birinciDizi.Add(pictureBox11);
            birinciDizi.Add(pictureBox15);
            birinciDizi.Add(pictureBox14);
            birinciDizi.Add(pictureBox13);
            birinciDizi.Add(pictureBox12);
            birinciDizi.Add(pictureBox25);
            birinciDizi.Add(pictureBox24);
            birinciDizi.Add(pictureBox23);
            birinciDizi.Add(pictureBox22);

            //Masada ki İkinci Dizileri sıraya koy
            ikinciDizi.Add(pictureBox6);
            ikinciDizi.Add(pictureBox7);
            ikinciDizi.Add(pictureBox4);
            ikinciDizi.Add(pictureBox17);
            ikinciDizi.Add(pictureBox16);
            ikinciDizi.Add(pictureBox19);
            ikinciDizi.Add(pictureBox27);
            ikinciDizi.Add(pictureBox26);
            ikinciDizi.Add(pictureBox29);

            //Masada ki üçüncü Dizileri sıraya koy

            üçünciDizi.Add(pictureBox5);
            üçünciDizi.Add(pictureBox2);
            üçünciDizi.Add(pictureBox18);
            üçünciDizi.Add(pictureBox20);
            üçünciDizi.Add(pictureBox28);
            üçünciDizi.Add(pictureBox30);

            dörtDizi.Add(pictureBox3);
            dörtDizi.Add(pictureBox21);
            dörtDizi.Add(pictureBox31);
            
            


            //oyuncunun elinde ki ilk gelen kart
            int rastgeleBas = RastgeleDeste();
            Kartlar elKart = Deste[rastgeleBas];
            El.Add(elKart);//Kartlar liste
            pictureBox33.Image = Image.FromFile(Application.StartupPath + "\\" + elKart.Resim);
            ilkdizi();
            Bitmap bm = new Bitmap(Properties.Resources.imlec);
            foreach (Control control in Controls)
                control.Cursor = new Cursor(bm.GetHicon());
           
                playmusic();
            
            
            
        }
        void playmusic()
        {
            SoundPlayer spd = new SoundPlayer(Properties.Resources.Cards_Flip_with_sound___mp3cut_net_);
            spd.Play();
        }
        private void ilkdizi()
        {
            for (int i = 0; i < birinciDizi.Count; i++)
            {

                int rastgeleBasla = RastgeleDeste();
                //Aynı Kartları kontrol ediyor
                while (MasaRastgele.Contains(rastgeleBasla))
                {
                    rastgeleBasla = RastgeleDeste();
                }

                Kartlar masakart = Deste[rastgeleBasla];//Destenin içinden rastgele değer ile kartımızı objemize atıyoruz.
                MasaId.Add(masakart);//kullanılmış kartın deger,isim,resmini listeliyor   
                MasaRastgele.Add(rastgeleBasla);//kullanılmış kartın Desteden çektiğimiz Rastgele sayısını tutuyor
                Masa.Add(masakart.deger);
                birinciDizi[i].Image = Image.FromFile(Application.StartupPath + "\\" + masakart.Resim);
            }
        }


        private int RastgeleDeste()
        {
            int randomCard;
            randomCard = random.Next(0, Deste.Count);
            return randomCard;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.Show();
            this.Close();

            if (zincir > yüksekZincir)
            {
                yüksekZincir = zincir;
            }

            if(skor > yüksekSkor)
            {
                yüksekSkor = skor;
            }
            if(silinenKartlar > yüksekSilinenKartlar)
            {
                yüksekSilinenKartlar = silinenKartlar;
            }
            
            timer2.Stop();
            timer3.Stop();
            timer4.Stop();

        }

        private void pictureBox32_Click(object sender, EventArgs e)
        {
            if (!candrag)
            {
                return;
            }

            if (desteKart > 0)
            {
                if (zincir > yüksekZincir)
                {
                    yüksekZincir = zincir;
                }

                if (skor > yüksekSkor)
                {
                    yüksekSkor = skor;
                }

                if (silinenKartlar > yüksekSilinenKartlar)
                {
                    yüksekSilinenKartlar = silinenKartlar;
                }

                zincir = 0;
                
                int rastgeleEl = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleEl))
                {
                    rastgeleEl = RastgeleDeste();
                }
                Kartlar el = Deste[rastgeleEl];

                PictureBox deste = new PictureBox
                {
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(pictureBox32.Location.X, 575),
                    Image = Image.FromFile(Application.StartupPath + "\\" + el.Resim),
                    Size = new Size(82, 111),
                    BackColor = Color.Transparent
                };
                this.Controls.Add(deste);
                deste.BringToFront();   
                El.Add(el);
                El.Last().pcb = deste;
                desteKart--;
                label1.Text = desteKart.ToString();
                label7.Text = zincir.ToString();
                timer1.Start();
            }
            else
            {
                
                timer4.Start(); 

                pictureBox34.Visible = true;

            }


        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (El.Last().pcb.Location.X < 780)
            {
                candrag = false;
                El.Last().pcb.Location = new Point(El.Last().pcb.Location.X + 35, El.Last().pcb.Location.Y);
            }
            else
            {
                timer1.Stop();
                candrag = true;
            }


        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;

           


            if (fazla == Masa[0] || eksik == Masa[0])
            {

                pictureBox8.Visible = false;
                El.Add(MasaId[0]);
                pictureBox33.Image = pictureBox8.Image;
                pictureBox33.BringToFront();  
                skor += 100 + (zincir * 10);
                zincir++;
                label7.Text = zincir.ToString();                
                silinenKartlar++;
            }

            if (pictureBox8.Visible == false && pictureBox9.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }

                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                ikinciKartDeğer[0] = masaikincikart;


                pictureBox6.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);

            }

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;

            

            if (fazla == Masa[1] || eksik == Masa[1])
            {

                pictureBox9.Visible = false;
                El.Add(MasaId[1]);
                pictureBox33.Image = pictureBox9.Image;
                pictureBox33.BringToFront();
                skor += 100 + (zincir * 10);
                zincir++;
                label7.Text = zincir.ToString();                
                silinenKartlar++;
            }

            if (pictureBox8.Visible == false && pictureBox9.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                ikinciKartDeğer[0] = masaikincikart;
                pictureBox6.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }


            if (pictureBox10.Visible == false && pictureBox9.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                ikinciKartDeğer[1] = masaikincikart;
                pictureBox7.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;

           
            if (fazla == Masa[2] || eksik == Masa[2])
            {


                pictureBox10.Visible = false;
                El.Add(MasaId[2]);
                pictureBox33.Image = pictureBox10.Image;
                pictureBox33.BringToFront();
                skor += 100 + (zincir * 10);
                zincir++;
                label7.Text = zincir.ToString();                
                silinenKartlar++;
            }

            if (pictureBox10.Visible == false && pictureBox11.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                ikinciKartDeğer[2] = masaikincikart;
                pictureBox4.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }


            if (pictureBox10.Visible == false && pictureBox9.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                ikinciKartDeğer[1] = masaikincikart;
                pictureBox7.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;

           

            if (fazla == Masa[3] || eksik == Masa[3])
            {

                pictureBox11.Visible = false;
                El.Add(MasaId[3]);
                pictureBox33.Image = pictureBox11.Image;
                pictureBox33.BringToFront();
                skor += 100 + (zincir * 10);
                zincir++;
                label7.Text = zincir.ToString();                
                silinenKartlar++;
            }

            if (pictureBox10.Visible == false && pictureBox11.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                ikinciKartDeğer[2] = masaikincikart;
                pictureBox4.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;

            


            if (fazla == Masa[4] || eksik == Masa[4])
            {

                pictureBox15.Visible = false;
                El.Add(MasaId[4]);
                pictureBox33.Image = pictureBox15.Image;
                pictureBox33.BringToFront();
                skor += 100 + (zincir * 10);
                zincir++;
                label7.Text = zincir.ToString();               
                silinenKartlar++;
            }

            if (pictureBox15.Visible == false && pictureBox14.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }

                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                ikinciKartDeğer[3] = masaikincikart;
                pictureBox17.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);

            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;


            if (fazla == Masa[5] || eksik == Masa[5])
            {

                pictureBox14.Visible = false;
                El.Add(MasaId[5]);
                pictureBox33.Image = pictureBox14.Image;
                pictureBox33.BringToFront();
                skor += 100 + (zincir * 10);
                zincir++;
                label7.Text = zincir.ToString();              
                silinenKartlar++;
            }

            if (pictureBox14.Visible == false && pictureBox15.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                ikinciKartDeğer[3] = masaikincikart;
                pictureBox17.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }


            if (pictureBox14.Visible == false && pictureBox13.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                ikinciKartDeğer[4] = masaikincikart;
                pictureBox16.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
          
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;


            if (fazla == Masa[6] || eksik == Masa[6])
            {


                pictureBox13.Visible = false;
                El.Add(MasaId[6]);
                pictureBox33.Image = pictureBox13.Image;
                pictureBox33.BringToFront();
                skor += 100 + (zincir * 10);
                zincir++;
                label7.Text = zincir.ToString();                
                silinenKartlar++;
            }
            

            if (pictureBox13.Visible == false && pictureBox14.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                ikinciKartDeğer[4] = masaikincikart;
                pictureBox16.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }


            if (pictureBox13.Visible == false && pictureBox12.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                ikinciKartDeğer[5] = masaikincikart;
                pictureBox19.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;

            

            if (fazla == Masa[7] || eksik == Masa[7])
            {

                pictureBox12.Visible = false;
                El.Add(MasaId[7]);
                pictureBox33.Image = pictureBox12.Image;
                pictureBox33.BringToFront();
                skor += 100 + (zincir * 10);
                zincir++;
                label7.Text = zincir.ToString();                
                silinenKartlar++;
            }

            if (pictureBox12.Visible == false && pictureBox13.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                ikinciKartDeğer[5] = masaikincikart;
                pictureBox19.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }

        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;



            if (fazla == Masa[8] || eksik == Masa[8])
            {

                pictureBox25.Visible = false;
                El.Add(MasaId[8]);
                pictureBox33.Image = pictureBox25.Image;
                pictureBox33.BringToFront();
                skor += 100 + (zincir * 10);
                zincir++;
                label7.Text = zincir.ToString();                
                silinenKartlar++;
            }

            if (pictureBox25.Visible == false && pictureBox24.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }

                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                ikinciKartDeğer[6] = masaikincikart;

                pictureBox27.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);

            }
        }

        private void pictureBox24_Click(object sender, EventArgs e)
        {
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;


            if (fazla == Masa[9] || eksik == Masa[9])
            {

                pictureBox24.Visible = false;
                El.Add(MasaId[9]);
                pictureBox33.Image = pictureBox24.Image;
                pictureBox33.BringToFront();
                skor += 100 + (zincir * 10);
                zincir++;
                label7.Text = zincir.ToString();                
                silinenKartlar++;
            }

            if (pictureBox24.Visible == false && pictureBox25.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                ikinciKartDeğer[6] = masaikincikart;

                pictureBox27.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }


            if (pictureBox24.Visible == false && pictureBox23.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                ikinciKartDeğer[7] = masaikincikart;

                pictureBox26.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }

        }

        private void pictureBox23_Click(object sender, EventArgs e)
        {
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;

            

            if (fazla == Masa[10] || eksik == Masa[10])
            {
                pictureBox23.Visible = false;
                El.Add(MasaId[10]);
                pictureBox33.Image = pictureBox23.Image;
                pictureBox33.BringToFront();
                skor += 100 + (zincir * 10);
                zincir++;
                label7.Text = zincir.ToString();               
                silinenKartlar++;
            }

            if (pictureBox23.Visible == false && pictureBox24.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                ikinciKartDeğer[7] = masaikincikart;

                pictureBox26.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }


            if (pictureBox23.Visible == false && pictureBox22.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                ikinciKartDeğer[8] = masaikincikart;

                pictureBox29.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }
        }

        private void pictureBox22_Click(object sender, EventArgs e)
        {
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;

            

            if (fazla == Masa[11] || eksik == Masa[11])
            {

                pictureBox22.Visible = false;
                El.Add(MasaId[11]);
                pictureBox33.Image = pictureBox22.Image;
                pictureBox33.BringToFront();
                skor += 100 + (zincir * 10);
                zincir++;
                label7.Text = zincir.ToString();               
                silinenKartlar++;
            }

            if (pictureBox22.Visible == false && pictureBox23.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                ikinciKartDeğer[8] = masaikincikart;

                pictureBox29.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;

            
            if (ikinciKartDeğer[8] == null)
            {
                MessageBox.Show("Lütfen açık kartları bitirin");
            }
            else
            {
                if (fazla == ikinciKartDeğer[8].deger || eksik == ikinciKartDeğer[8].deger)
                {

                    pictureBox29.Visible = false;
                    El.Add(ikinciKartDeğer[8]);
                    pictureBox33.Image = pictureBox29.Image;
                    pictureBox33.BringToFront();
                    skor += 100 + (zincir * 10);
                    zincir++;
                    label7.Text = zincir.ToString();                    
                    silinenKartlar++;
                }

            }


            if (pictureBox29.Visible == false && pictureBox26.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                üçüncüKartDeğer[5] = masaikincikart;

                pictureBox30.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }
        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;

            
            if (ikinciKartDeğer[7] == null)
            {
                MessageBox.Show("Lütfen açık kartları bitirin");
            }
            else
            {
                if (fazla == ikinciKartDeğer[7].deger || eksik == ikinciKartDeğer[7].deger)
                {

                    pictureBox26.Visible = false;
                    El.Add(ikinciKartDeğer[7]);
                    pictureBox33.Image = pictureBox26.Image;
                    pictureBox33.BringToFront();
                    skor += 100 + (zincir * 10);
                    zincir++;
                    label7.Text = zincir.ToString();                    
                    silinenKartlar++;
                }

            }


            if (pictureBox26.Visible == false && pictureBox29.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                üçüncüKartDeğer[5] = masaikincikart;

                pictureBox30.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }

            if (pictureBox26.Visible == false && pictureBox27.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                üçüncüKartDeğer[4] = masaikincikart;

                pictureBox28.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;

            
            if (ikinciKartDeğer[6] == null)
            {
                MessageBox.Show("Lütfen açık kartları bitirin");
            }
            else
            {
                if (fazla == ikinciKartDeğer[6].deger || eksik == ikinciKartDeğer[6].deger)
                {

                    pictureBox27.Visible = false;
                    El.Add(ikinciKartDeğer[6]);
                    pictureBox33.Image = pictureBox27.Image;
                    pictureBox33.BringToFront();
                    skor += 100 + (zincir * 10);
                    zincir++;
                    label7.Text = zincir.ToString();                   
                    silinenKartlar++;
                }

            }


            if (pictureBox27.Visible == false && pictureBox26.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                üçüncüKartDeğer[4] = masaikincikart;

                pictureBox28.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;

            
            if (ikinciKartDeğer[5] == null)
            {
                MessageBox.Show("Lütfen açık kartları bitirin");
            }
            else
            {
                if (fazla == ikinciKartDeğer[5].deger || eksik == ikinciKartDeğer[5].deger)
                {

                    pictureBox19.Visible = false;
                    El.Add(ikinciKartDeğer[5]);
                    pictureBox33.Image = pictureBox19.Image;
                    pictureBox33.BringToFront();
                    skor += 100 + (zincir * 10);
                    zincir++;
                    label7.Text = zincir.ToString();                    
                    silinenKartlar++;
                }

            }


            if (pictureBox19.Visible == false && pictureBox16.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                üçüncüKartDeğer[3] = masaikincikart;

                pictureBox20.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;

            
            if (ikinciKartDeğer[4] == null)
            {
                MessageBox.Show("Lütfen açık kartları bitirin");
            }
            else
            {
                if (fazla == ikinciKartDeğer[4].deger || eksik == ikinciKartDeğer[4].deger)
                {

                    pictureBox16.Visible = false;
                    El.Add(ikinciKartDeğer[4]);
                    pictureBox33.Image = pictureBox16.Image;
                    pictureBox33.BringToFront();
                    skor += 100 + (zincir * 10);
                    zincir++;
                    label7.Text = zincir.ToString();                   
                    silinenKartlar++;
                }

            }


            if (pictureBox16.Visible == false && pictureBox19.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                üçüncüKartDeğer[3] = masaikincikart;
                pictureBox20.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }

            if (pictureBox16.Visible == false && pictureBox17.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                üçüncüKartDeğer[2] = masaikincikart;
                pictureBox18.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;

            
            if (ikinciKartDeğer[3] == null)
            {
                MessageBox.Show("Lütfen açık kartları bitirin");
            }
            else
            {
                if (fazla == ikinciKartDeğer[3].deger || eksik == ikinciKartDeğer[3].deger)
                {

                    pictureBox17.Visible = false;
                    El.Add(ikinciKartDeğer[3]);
                    pictureBox33.Image = pictureBox17.Image;
                    pictureBox33.BringToFront();
                    skor += 100 + (zincir * 10);
                    zincir++;
                    label7.Text = zincir.ToString();                   
                    silinenKartlar++;
                }

            }


            if (pictureBox17.Visible == false && pictureBox16.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                üçüncüKartDeğer[2] = masaikincikart;
                pictureBox18.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;

            
            if (ikinciKartDeğer[2] == null)
            {
                MessageBox.Show("Lütfen açık kartları bitirin");
            }
            else
            {
                if (fazla == ikinciKartDeğer[2].deger || eksik == ikinciKartDeğer[2].deger)
                {

                    pictureBox4.Visible = false;
                    El.Add(ikinciKartDeğer[2]);
                    pictureBox33.Image = pictureBox4.Image;
                    pictureBox33.BringToFront();
                    skor += 100 + (zincir * 10);
                    zincir++;
                    label7.Text = zincir.ToString();                    
                    silinenKartlar++;
                }

            }


            if (pictureBox4.Visible == false && pictureBox7.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                üçüncüKartDeğer[1] = masaikincikart;
                pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;

            
            if (ikinciKartDeğer[0] == null)
            {
                MessageBox.Show("Lütfen açık kartları bitirin");
            }
            else
            {
                if (fazla == ikinciKartDeğer[0].deger || eksik == ikinciKartDeğer[0].deger)
                {

                    pictureBox6.Visible = false;
                    El.Add(ikinciKartDeğer[0]);
                    pictureBox33.Image = pictureBox6.Image;
                    pictureBox33.BringToFront();
                    skor += 100 + (zincir * 10);
                    zincir++;
                    label7.Text = zincir.ToString();                    
                    silinenKartlar++;
                }

            }


            if (pictureBox6.Visible == false && pictureBox7.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                üçüncüKartDeğer[0] = masaikincikart;
                pictureBox5.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;

            
            if (ikinciKartDeğer[1] == null)
            {
                MessageBox.Show("Lütfen açık kartları bitirin");
            }
            else
            {
                if (fazla == ikinciKartDeğer[1].deger || eksik == ikinciKartDeğer[1].deger)
                {

                    pictureBox7.Visible = false;
                    El.Add(ikinciKartDeğer[1]);
                    pictureBox33.Image = pictureBox7.Image;
                    pictureBox33.BringToFront();
                    skor += 100 + (zincir * 10);
                    zincir++;
                    label7.Text = zincir.ToString();                   
                    silinenKartlar++;
                }

            }


            if (pictureBox7.Visible == false && pictureBox4.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                üçüncüKartDeğer[1] = masaikincikart;
                pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }

            if (pictureBox7.Visible == false && pictureBox6.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                üçüncüKartDeğer[0] = masaikincikart;

                pictureBox5.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;

            
            if (üçüncüKartDeğer[0] == null)
            {
                MessageBox.Show("Lütfen açık kartları bitirin");
            }
            else
            {
                if (fazla == üçüncüKartDeğer[0].deger || eksik == üçüncüKartDeğer[0].deger)
                {

                    pictureBox5.Visible = false;
                    El.Add(üçüncüKartDeğer[0]);
                    pictureBox33.Image = pictureBox5.Image;
                    pictureBox33.BringToFront();
                    skor += 100 + (zincir * 10);
                    zincir++;
                    label7.Text = zincir.ToString();                   
                    silinenKartlar++;
                }

            }


            if (pictureBox5.Visible == false && pictureBox2.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                SonKartlarDeğer[0] = masaikincikart;
                pictureBox3.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;

            
            if (üçüncüKartDeğer[1] == null)
            {
                MessageBox.Show("Lütfen açık kartları bitirin");
            }
            else
            {
                if (fazla == üçüncüKartDeğer[1].deger || eksik == üçüncüKartDeğer[1].deger)
                {

                    pictureBox2.Visible = false;
                    El.Add(üçüncüKartDeğer[1]);
                    pictureBox33.Image = pictureBox2.Image;
                    pictureBox33.BringToFront();
                    skor += 100 + (zincir * 10);
                    zincir++;
                    label7.Text = zincir.ToString();                    
                    silinenKartlar++;
                }

            }


            if (pictureBox5.Visible == false && pictureBox2.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                SonKartlarDeğer[0] = masaikincikart;

                pictureBox3.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }
        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;

            
            if (üçüncüKartDeğer[2] == null)
            {
                MessageBox.Show("Lütfen açık kartları bitirin");
            }
            else
            {
                if (fazla == üçüncüKartDeğer[2].deger || eksik == üçüncüKartDeğer[2].deger)
                {

                    pictureBox18.Visible = false;
                    El.Add(üçüncüKartDeğer[2]);
                    pictureBox33.Image = pictureBox18.Image;
                    pictureBox33.BringToFront();
                    skor += 100 + (zincir * 10);
                    zincir++;
                    label7.Text = zincir.ToString();                    
                    silinenKartlar++;
                }

            }


            if (pictureBox18.Visible == false && pictureBox20.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                SonKartlarDeğer[1] = masaikincikart;

                pictureBox21.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;

            
            if (üçüncüKartDeğer[3] == null)
            {
                MessageBox.Show("Lütfen açık kartları bitirin");
            }
            else
            {
                if (fazla == üçüncüKartDeğer[3].deger || eksik == üçüncüKartDeğer[3].deger)
                {

                    pictureBox20.Visible = false;
                    El.Add(üçüncüKartDeğer[3]);
                    pictureBox33.Image = pictureBox20.Image;
                    pictureBox33.BringToFront();
                    skor += 100 + (zincir * 10);
                    zincir++;
                    label7.Text = zincir.ToString();                    
                    silinenKartlar++;
                }

            }


            if (pictureBox18.Visible == false && pictureBox20.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                SonKartlarDeğer[1] = masaikincikart;

                pictureBox21.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;

            
            if (üçüncüKartDeğer[4] == null)
            {
                MessageBox.Show("Lütfen açık kartları bitirin");
            }
            else
            {
                if (fazla == üçüncüKartDeğer[4].deger || eksik == üçüncüKartDeğer[4].deger)
                {

                    pictureBox28.Visible = false;
                    El.Add(üçüncüKartDeğer[4]);
                    pictureBox33.Image = pictureBox28.Image;
                    pictureBox33.BringToFront();
                    skor += 100 + (zincir * 10);
                    zincir++;
                    label7.Text = zincir.ToString();                    
                    silinenKartlar++;
                }

            }


            if (pictureBox28.Visible == false && pictureBox30.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                SonKartlarDeğer[2] = masaikincikart;

                pictureBox31.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }
        }

        private void pictureBox30_Click(object sender, EventArgs e)
        {
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;

            
            if (üçüncüKartDeğer[5] == null)
            {
                MessageBox.Show("Lütfen açık kartları bitirin");
            }
            else
            {
                if (fazla == üçüncüKartDeğer[5].deger || eksik == üçüncüKartDeğer[5].deger)
                {

                    pictureBox30.Visible = false;
                    El.Add(üçüncüKartDeğer[5]);
                    pictureBox33.Image = pictureBox30.Image;
                    pictureBox33.BringToFront();
                    skor += 100 + (zincir * 10);
                    zincir++;
                    label7.Text = zincir.ToString();                   
                    silinenKartlar++;

                }

            }


            if (pictureBox28.Visible == false && pictureBox30.Visible == false)
            {
                int rastgeleikinci = RastgeleDeste();
                while (MasaRastgele.Contains(rastgeleikinci))
                {
                    rastgeleikinci = RastgeleDeste();
                }
                Kartlar masaikincikart = Deste[rastgeleikinci];
                MasaRastgele.Add(rastgeleikinci);
                SonKartlarDeğer[2] = masaikincikart;

                pictureBox31.Image = Image.FromFile(Application.StartupPath + "\\" + masaikincikart.Resim);
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;

            
            if (SonKartlarDeğer[0] == null)
            {
                MessageBox.Show("Lütfen açık kartları bitirin");
            }
            else
            {
                if (fazla == SonKartlarDeğer[0].deger || eksik == SonKartlarDeğer[0].deger)
                {

                    pictureBox3.Visible = false;
                    El.Add(SonKartlarDeğer[0]);
                    pictureBox33.Image = pictureBox3.Image;
                    pictureBox33.BringToFront();
                    skor += 100 + (zincir * 10);
                    zincir++;
                    label7.Text = zincir.ToString();                   
                    silinenKartlar++;
                }
                if (pictureBox31.Visible == false && pictureBox21.Visible == false && pictureBox3.Visible == false)
                {
                    timer2.Stop();
                    timer3.Stop();
                    timer4.Stop();

                    this.Enabled = false;
                    Form10 fr10 = new Form10();
                    fr10.Show();
                    
                }

            }

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;

            
            if (SonKartlarDeğer[1] == null)
            {
                MessageBox.Show("Lütfen açık kartları bitirin");
            }
            else
            {
                if (fazla == SonKartlarDeğer[1].deger || eksik == SonKartlarDeğer[1].deger)
                {

                    pictureBox21.Visible = false;
                    El.Add(SonKartlarDeğer[1]);
                    pictureBox33.Image = pictureBox21.Image;
                    pictureBox33.BringToFront();
                    skor += 100 + (zincir * 10);
                    zincir++;
                    label7.Text = zincir.ToString();                 
                    silinenKartlar++;
                }

                if (pictureBox31.Visible == false && pictureBox21.Visible == false && pictureBox3.Visible == false)
                {
                    timer2.Stop();
                    timer3.Stop();
                    timer4.Stop();

                    this.Enabled = false;
                    Form10 fr10 = new Form10();
                    fr10.Show();
                    
                }
            }
        }

        private void pictureBox31_Click(object sender, EventArgs e)
        {
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;

            
            if (SonKartlarDeğer[2] == null)
            {
                MessageBox.Show("Lütfen açık kartları bitirin");
            }
            else
            {
                if (fazla == SonKartlarDeğer[2].deger || eksik == SonKartlarDeğer[2].deger)
                {

                    pictureBox31.Visible = false;
                    El.Add(SonKartlarDeğer[2]);
                    pictureBox33.Image = pictureBox31.Image;
                    pictureBox33.BringToFront();
                    skor += 100 + (zincir * 10);
                    zincir++;
                    label7.Text = zincir.ToString();                    
                    silinenKartlar++;
                }

                if (pictureBox31.Visible == false && pictureBox21.Visible == false && pictureBox3.Visible == false)
                {
                    timer2.Stop();
                    timer3.Stop();
                    timer4.Stop();

                    this.Enabled = false;
                    Form10 fr10 = new Form10();
                    fr10.Show();
                    this.Hide();
                }

            }
        }

        public void timer2_Tick(object sender, EventArgs e)
        {

            saniye--;
            if (saniye == 0)
            {
                saniye = 59;
            }

            if (dk < 0)
            {
                timer2.Stop();
                timer3.Stop();
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                pictureBox35.Visible = true;

                this.Enabled = false;
                Form10 fr10 = new Form10();
                fr10.StartPosition = FormStartPosition.CenterScreen;
                fr10.Show();
                
                
            }
            label4.Text = saniye.ToString();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            dk--;
            label3.Text = dk.ToString();

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.parlakhome;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = Properties.Resources.hometripeek;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1.Image = Properties.Resources.karahome;
        }

        private void pictureBox32_MouseEnter(object sender, EventArgs e)
        {
            pictureBox32.Image = Properties.Resources.card_back_bright;
        }

        private void pictureBox32_MouseLeave(object sender, EventArgs e)
        {
            pictureBox32.Image = Properties.Resources.card_back;
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            //kartlar görünmez mi ->görünmez ise -> görünürler listede ->görünürler +1 -1 ise liste -> listeden sil -> liste null oyun biter
            int fazla = El.Last().deger + 1;
            int eksik = El.Last().deger - 1;



            tıklanabilir.Clear();
            GörünürListe.Clear();
              
            
            //Görünür kartları listeye atıyoruz
            for (int i = 0; i < birinciDizi.Count; i++)
            {
                if (birinciDizi[i].Visible == true)
                {
                    GörünürListe.Add(MasaId[i]);
                }
               
            }
            for (int i = 0; i < ikinciDizi.Count; i++)
            {
                if (ikinciDizi[i].Visible == true)
                {
                    GörünürListe.Add(ikinciKartDeğer[i]);
                }
            }
            for (int i = 0; i < üçünciDizi.Count; i++)
            {
                if (üçünciDizi[i].Visible == true)
                {
                    GörünürListe.Add(üçüncüKartDeğer[i]);
                }
            }

            for (int i = 0; i < dörtDizi.Count; i++)
            {
                if (dörtDizi[i].Visible == true)
                {
                    GörünürListe.Add(SonKartlarDeğer[i]);
                }
            }



            for (int i = 0; i < GörünürListe.Count; i++)
            {
                if (GörünürListe[i] == null)
                {
                    continue;
                }
                if (fazla == GörünürListe[i].deger || eksik == GörünürListe[i].deger)
                {
                    tıklanabilir.Add(GörünürListe[i].deger);
                
                }
            }

            if (tıklanabilir.Count == 0)
            {
                
                timer4.Stop();
                timer2.Stop();
                timer3.Stop();

                this.Enabled = false;
                Form10 fr10 = new Form10();
                fr10.StartPosition = FormStartPosition.CenterScreen;
                fr10.Show();
                

            }

            for (int i = 0; i < tıklanabilir.Count; i++)
            {
                //   10         8                 8             8
                if (fazla != tıklanabilir[i] && eksik != tıklanabilir[i])
                {
                    
                    timer4.Stop();
                    timer2.Stop();
                    timer3.Stop();

                    this.Enabled = false;
                    Form10 fr10 = new Form10();
                    fr10.StartPosition = FormStartPosition.CenterScreen;
                    fr10.Show();
                    


                }
            }

            




        }

        private void pictureBox35_Click(object sender, EventArgs e)
        {

        }
    }
}
