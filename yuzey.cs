using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekilCarpistirma
{
    //yüzey şeklinin verilerini içeren yüzey sınıfı
    public class yuzey
    {
        Nokta3d merkez;
        int genislik;
        int derinlik;

        public yuzey()
        {
            merkez = new Nokta3d();
            genislik = 0;
            derinlik = 0;
        }

        public yuzey(Nokta3d m , int genis, int derin)
        {
            merkez = m;
            genislik = genis;
            derinlik = derin;
        }

        public Nokta3d m { get => merkez; set => merkez = value; }
        public int genis { get => genislik; set => genislik = value; }
        public int derin{ get => derinlik; set => derinlik = value; }
    }
}
