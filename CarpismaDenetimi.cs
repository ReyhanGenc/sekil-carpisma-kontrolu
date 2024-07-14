using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekilCarpistirma
{
    class CapismaDenetimi
    {
        public static bool NoktaDortgen(Nokta2d n, dikdortgen d)
        {
            int x_mesafe = Math.Abs(n.X - d.m.X);
            int y_mesafe = Math.Abs(n.Y - d.m.Y);

            if ((x_mesafe < d.genis / 2) && (y_mesafe < d.yuksek / 2))
                return true;
            else
                return false;
        }

        public static bool NoktaCember(Nokta2d n, Cember c)
        {
            double mesafe = Math.Sqrt((Math.Pow((n.X - c.m.X), 2)) + (Math.Pow((n.Y - c.m.Y), 2)));

            if (mesafe < c.r)
                return true;
            else
                return false;
        }

        public static bool DikdortgenDikdortgen(dikdortgen d1, dikdortgen d2)
        {
            double x1 = d1.m.X + d1.genis / 2;
            double y1 = d1.m.Y + d1.yuksek / 2;
            double x2 = d2.m.X + d2.genis / 2;
            double y2 = d2.m.Y + d2.yuksek / 2;

            if ((Math.Abs(x1 - x2) < (d1.genis / 2 + d2.genis / 2) && (Math.Abs(y1 - y2) < (d1.yuksek / 2 + d2.yuksek / 2))))
                return true;
            else
                return false;
        }

        public static bool DikdortgenCember(dikdortgen d, Cember c)
        {
            double x_mesafe = Math.Abs(d.m.X - c.m.X);
            double y_mesafe = Math.Abs(d.m.Y - c.m.Y);

            if ((x_mesafe < (d.genis / 2 + c.r)) && (y_mesafe < (d.yuksek / 2 + c.r)))
                return true;
            else
                return false;
        }

        public static bool CemberCember(Cember c1, Cember c2)
        {
            double mesafe = Math.Sqrt((Math.Pow((c1.m.X - c2.m.X), 2)) + (Math.Pow((c1.m.Y - c2.m.Y), 2)));

            if (mesafe < (c1.r + c2.r))
                return true;
            else
                return false;
        }

        public static bool NoktaKure(Nokta3d n, kure k)
        {
            double mesafe = Math.Sqrt((Math.Pow((n.X - k.m.X), 2)) + (Math.Pow((n.Y - k.m.Y), 2)) + (Math.Pow((n.Z - k.m.Z), 2)));

            if (mesafe < k.r)
                return true;
            else
                return false;
        }

        public static bool NoktaDikPriz(Nokta3d n, dikdortgenPrizma dp)
        {
            double x_mesafe = Math.Abs(n.X - dp.m.X);
            double y_mesafe = Math.Abs(n.Y - dp.m.Y);
            double z_mesafe = Math.Abs(n.Z - dp.m.Z);

            if ((x_mesafe < (dp.genis / 2)) && (y_mesafe < (dp.yuksek / 2)) && (z_mesafe < (dp.derin / 2)))
                return true;
            else
                return false;
        }

        public static bool NoktaSilindir(Nokta3d n, silindir s)
        {
            Nokta3d taban = new Nokta3d(s.m.X, s.m.Y + s.h / 2, s.m.Z);

            double mesafe = Math.Sqrt((Math.Pow((taban.X - n.X), 2)) + (Math.Pow((taban.Y - n.Y), 2)) + (Math.Pow((taban.Z - n.Z), 2)));

            if (mesafe < s.r && Math.Abs(taban.Y - n.Y) < (s.h / 2) && n.Y < taban.Y)
                return true;
            else
                return false;
        }

        public static bool SilindirSilindir(silindir s1, silindir s2)
        {
            Nokta3d taban1 = new Nokta3d(s1.m.X, s1.m.Y + s1.h / 2, s1.m.Z);
            Nokta3d taban2 = new Nokta3d(s2.m.X, s2.m.Y + s2.h / 2, s2.m.Z);

            double mesafe = Math.Sqrt((Math.Pow((taban1.X - taban2.X), 2)) + (Math.Pow((taban1.Y - taban2.Y), 2)) + (Math.Pow((taban1.Z - taban2.Z), 2)));

            if (mesafe < (s1.r + s2.r) && Math.Abs(taban1.Y - taban2.Y) < ((s1.h + s2.h) / 2))
                return true;
            else
                return false;
        }

        public static bool KureKure(kure k1, kure k2)
        {
            double mesafe = Math.Sqrt((Math.Pow((k1.m.X - k2.m.X), 2)) + (Math.Pow((k1.m.Y - k1.m.Y), 2)) + (Math.Pow((k1.m.Z - k2.m.Z), 2)));

            if (mesafe < (k1.r + k2.r))
                return true;
            else
                return false;
        }

        public static bool KureSilindir(kure k, silindir s)
        {
            double mesafe = Math.Sqrt((Math.Pow((k.m.X - s.m.X), 2)) + (Math.Pow((k.m.Y - s.m.Y), 2)) + (Math.Pow((k.m.Z - s.m.Z), 2)));

            double x_mesafe = Math.Abs(k.m.X - s.m.X);
            double y_mesafe = Math.Abs(k.m.Y - s.m.Y);
            double z_mesafe = Math.Abs(k.m.Z - s.m.Z);

            if ((x_mesafe < (k.r + s.r)) && (y_mesafe < (k.r + s.h / 2)) && (z_mesafe < (k.r + s.r)))
                return true;
            else if (Math.Sqrt((Math.Pow(s.r, 2)) + (Math.Pow(s.h / 2, 2))) + k.r < mesafe)
                return true;
            else
                return false;
        }

        //yüzey çarpışma denetimleri  

        public static bool YuzeyKure(yuzey y, kure k)
        {
            double x_mesafe = Math.Abs(k.m.X - y.m.X);
            double y_mesafe = Math.Abs(k.m.Y - y.m.Y);
            double z_mesafe = Math.Abs(k.m.Z - y.m.Z);

            if ((x_mesafe < k.r + y.genis / 2) && (z_mesafe < k.r + y.derin / 2) && y_mesafe < k.r)
                return true;
            else
                return false;
        }

        public static bool YuzeyDikPriz(yuzey y, dikdortgenPrizma dp)
        {
            double x_mesafe = Math.Abs(dp.m.X - y.m.X);
            double y_mesafe = Math.Abs(dp.m.Y - y.m.Y);
            double z_mesafe = Math.Abs(dp.m.Z - y.m.Z);

            if ((x_mesafe < (dp.genis / 2 + y.genis / 2)) && (y_mesafe < (dp.yuksek / 2)) && (z_mesafe < (dp.derin / 2 + y.derin / 2)))
                return true;
            else
                return false;

        }

        public static bool YuzeySilindir(yuzey y, silindir s)
        {
            double x_mesafe = Math.Abs(s.m.X - y.m.X);
            double y_mesafe = Math.Abs(s.m.Y - y.m.Y);
            double z_mesafe = Math.Abs(s.m.Z - y.m.Z);

            if ((x_mesafe < (y.genis / 2 + s.r)) && (z_mesafe < (y.derin / 2 + s.r)) && (y_mesafe < s.h / 2))
                return true;
            else
                return false;
        }

        public static bool KureDikPriz(kure k, dikdortgenPrizma dp)
        {
            double x_mesafe = Math.Abs(k.m.X - dp.m.X);
            double y_mesafe = Math.Abs(k.m.Y - dp.m.Y);
            double z_mesafe = Math.Abs(k.m.Z - dp.m.Z);

            if ((x_mesafe < (dp.genis / 2 + k.r)) && (y_mesafe < (dp.yuksek / 2 + k.r)) && (z_mesafe < (dp.derin / 2 + k.r)))
                return true;
            else
                return false;
        }

        public static bool DikPrizDikPriz(dikdortgenPrizma dp1, dikdortgenPrizma dp2)
        {
            double x_mesafe = Math.Abs(dp1.m.X - dp2.m.X);
            double y_mesafe = Math.Abs(dp1.m.Y - dp2.m.Y);
            double z_mesafe = Math.Abs(dp1.m.Z - dp2.m.Z);

            if ((x_mesafe < (dp1.genis / 2 + dp2.genis / 2)) && (y_mesafe < (dp1.yuksek / 2 + dp2.yuksek / 2)) && (z_mesafe < (dp1.derin / 2 + dp2.derin / 2)))
                return true;
            else
                return false;
        }
    }
}
