using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekilCarpistirma
{
    public class silindir
    {
        Nokta3d merkez;
        int yaricap;
        int yukseklik;

        public silindir()
        {
            merkez = new Nokta3d();
            yaricap = 0;
            yukseklik = 0;
        }

        public silindir(Nokta3d m, int r,int h)
        {
            merkez = m;
            yaricap = r;
            yukseklik = h;
        }

        public Nokta3d m { get => merkez; set => merkez = value; }
        public int r { get => yaricap; set => yaricap = value; }
        public int h { get => yukseklik; set => yukseklik = value; }
    }
}
