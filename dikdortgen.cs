using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekilCarpistirma
{
    public class dikdortgen
    {
        Nokta2d merkez;
        int genislik;
        int yukseklik;

        public dikdortgen()
        {
            merkez = new Nokta2d();
            genislik = 0;
            yukseklik = 0;
        }

        public dikdortgen(Nokta2d m, int genis, int yuksek)
        {
            merkez = m;
            genislik = genis;
            yukseklik = yuksek;
        }

        public Nokta2d m { get => merkez;set=> merkez = value; }
        public int genis { get => genislik; set => genislik = value; }
        public int yuksek { get => yukseklik; set => yukseklik = value; }
    }
}
