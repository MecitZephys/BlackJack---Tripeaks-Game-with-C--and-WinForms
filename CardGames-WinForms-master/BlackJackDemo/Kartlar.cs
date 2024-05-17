using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackDemo
{
    internal class Kartlar
    {
        public int deger { get; set; }
        public enum Desen
        {
            SARI,
            YESIL,
            MAVI,
            KIRMIZI,
        }
        public Desen desen { get; set; }
        public string isim { get; set; }

        public PictureBox pcb;
        public string Resim { get; set; }

        
           
        
    }
}
