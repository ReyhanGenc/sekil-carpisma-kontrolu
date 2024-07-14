using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NDP_G221210009
{
    public class kure
    {
        Nokta3d merkez;
        int yaricap;

        public kure()
        {
            merkez = new Nokta3d();
            yaricap = 0;
        }

        public kure(Nokta3d m, int r)
        {
            merkez = m;
            yaricap = r;
        }

        public Nokta3d m { get => merkez; set => merkez = value; }
        public int r { get => yaricap; set => yaricap = value; }
    }
}
