using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekilCarpistirma
{
    //İki bileşeni olan noktanın verilerini içeren sınıf
    public class Nokta2d
    {
        int x; int y;

        //kurucu fonksiyonlar oluşturuluyor
        public Nokta2d()
        {
            x = 0;y = 0;
        }

        public Nokta2d(int X, int Y)
        {
            x = X;
            y = Y;
        }

        public int X { get => x;set=> x = value; }
        public int Y { get => y; set => y = value; }
    }
    
    //Üç bileşeni olan noktanın verilerini içeren sınıf, Nokta2d sınıfıyla aynı bileşenlere sahip olduğu için Nokta2d'den kalıtım alıyor. 
    public class Nokta3d:Nokta2d
    {
        int z;
        public Nokta3d()
        {
            z = 0;
        }

        public Nokta3d(int X, int Y, int Z)
        {
            z = Z;
        }

        public int Z { get => z; set => z = value; }
    }

    public class Cember
    {
        Nokta2d merkez;
        int yaricap;

        public Cember()
        {
            merkez = new Nokta2d();
            yaricap = 0;
        }

        public Cember(Nokta2d m, int r)
        {
            merkez = m;
            yaricap = r;
        }

        public int r { get => yaricap; set => yaricap = value; }
        public Nokta2d m { get => merkez; set => merkez = value; }
    }
}
