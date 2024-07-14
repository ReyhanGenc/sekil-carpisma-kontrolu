using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekilCarpistirma
{
    public class dikdortgenPrizma
    {
        Nokta3d merkez;
        int genislik;
        int yukseklik;
        int derinlik;

        public dikdortgenPrizma()
        {
            merkez = new Nokta3d();
            genislik = 0;
            yukseklik = 0;
            derinlik = 0;
        }

        public dikdortgenPrizma(Nokta3d m, int genis, int yuksek, int derin)
        {
            merkez = m;
            genislik = genis;
            derinlik = derin;
        }

        public Nokta3d m { get => merkez; set => merkez = value; }
        public int genis { get => genislik; set => genislik = value; }
        public int yuksek { get => yukseklik; set => yukseklik = value; }
        public int derin { get => derinlik; set => derinlik = value; }
    }
}
