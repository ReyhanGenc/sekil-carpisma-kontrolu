using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SekilCarpistirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Height = 900;
            Width = 1300;
            Text = "Çarpışma Denetimi";

            //form elemanlarını ekleyecek olan fonksiyonumu ekledim.
            FormElemanOlustur();
        }

        public PictureBox pBox;
        public ComboBox m_Btn_İslem;
        public Label sonuc;
        public Label ilksekil;
        public Label ikisekil;
        public TextBox x1;
        public TextBox y1;
        public TextBox z1;
        public TextBox x2;
        public TextBox y2;
        public TextBox z2;
        public TextBox gen1;
        public TextBox yuk1;
        public TextBox der1;
        public TextBox gen2;
        public TextBox yuk2;
        public TextBox der2;
        public TextBox r1;
        public TextBox r2;
        public Label x1l;
        public Label y1l;
        public Label z1l;
        public Label x2l;
        public Label y2l;
        public Label z2l;
        public Label gen1l;
        public Label yuk1l;
        public Label der1l;
        public Label gen2l;
        public Label yuk2l;
        public Label der2l;
        public Label r1l;
        public Label r2l;
        public Label mesaj;

        private void FormElemanOlustur()
        {
            //Form elemanları oluşturuluyor.
            pBox = new PictureBox();
            m_Btn_İslem = new ComboBox();
            sonuc = new Label();
            ilksekil = new Label();
            ikisekil = new Label();
            x1 = new TextBox();
            x2 = new TextBox();
            y1 = new TextBox();
            y2 = new TextBox();
            z1 = new TextBox();
            z2 = new TextBox();
            gen1 = new TextBox();
            yuk1 = new TextBox();
            der1 = new TextBox();
            gen2 = new TextBox();
            yuk2 = new TextBox();
            der2 = new TextBox();
            r1 = new TextBox();
            r2 = new TextBox();
            x1l = new Label();
            x2l = new Label();
            y1l = new Label();
            y2l = new Label();
            z1l = new Label();
            z2l = new Label();
            gen1l = new Label();
            yuk1l = new Label();
            der1l = new Label();
            gen2l = new Label();
            yuk2l = new Label();
            der2l = new Label();
            r1l = new Label();
            r2l = new Label();
            mesaj = new Label();

            pBox.SetBounds(50, 50, 800, 700);

            m_Btn_İslem.Text = "Yapılacak işlemi seçiniz...";
            m_Btn_İslem.SetBounds(900, 30, 370, 40);
            m_Btn_İslem.Click += m_Btn_İslen_Click;

            ilksekil.Text = "İlk şeklin verileri";
            ilksekil.SetBounds(900,70,200,40);

            ikisekil.Text = "İkinci şeklin verileri";
            ikisekil.SetBounds(1100, 70, 200, 40);

            //Form elemanları konumları düzenleniyor.
            x1l.SetBounds(900,110,50,40);
            y1l.SetBounds(900, 190, 50, 40);
            z1l.SetBounds(900, 270, 50, 40);
            x2l.SetBounds(1100, 110, 50, 40);
            y2l.SetBounds(1100, 190, 50, 40);
            z2l.SetBounds(1100, 270, 50, 40);
            gen1l.SetBounds(900, 350, 70, 40);
            yuk1l.SetBounds(900, 430, 70, 40);
            der1l.SetBounds(900, 510, 70, 40);
            r1l.SetBounds(900, 590, 70, 40);
            gen2l.SetBounds(1100, 350, 70, 40);
            yuk2l.SetBounds(1100, 430, 70, 40);
            der2l.SetBounds(1100, 510, 70, 40);
            r2l.SetBounds(1100, 590, 70, 40);
            x1.SetBounds(900, 130, 50, 40);
            y1.SetBounds(900, 210, 50, 40);
            z1.SetBounds(900, 290, 50, 40);
            x2.SetBounds(1100, 130, 50, 40);
            y2.SetBounds(1100, 210, 50, 40);
            z2.SetBounds(1100, 290, 50, 40);
            gen1.SetBounds(900, 370, 70, 40);
            yuk1.SetBounds(900, 450, 70, 40);
            der1.SetBounds(900, 530, 70, 40);
            gen2.SetBounds(1100, 370, 70, 40);
            yuk2.SetBounds(1100, 450, 70, 40);
            der2.SetBounds(1100, 530, 70, 40);
            r1.SetBounds(900, 610, 70, 40);
            r2.SetBounds(1100, 610, 70, 40);
            mesaj.SetBounds(900, 750, 370, 40);

            //Form elemanlarına metin ekleniyor.
            x1.Text = "0";
            y1.Text = "0";
            z1.Text = "0";
            x2.Text = "0";
            y2.Text = "0";
            z2.Text = "0";
            gen1.Text = "0";
            yuk1.Text = "0";
            der1.Text = "0";
            yuk2.Text = "0";
            gen2.Text = "0";
            der2.Text = "0";
            r1.Text = "0";
            r2.Text = "0";
            x1l.Text = "x";
            y1l.Text = "y";
            z1l.Text = "z";
            x2l.Text = "x";
            y2l.Text = "y";
            z2l.Text = "z";
            gen1l.Text = "genişlik";
            yuk1l.Text = "yükseklik";
            der1l.Text = "derinlik";
            yuk2l.Text = "yükseklik";
            gen2l.Text = "genişlik";
            der2l.Text = "derinlik";
            r1l.Text = "yarıçap";
            r2l.Text = "yarıçap";
            mesaj.Text = "// Verileri girdikten sonra sonuç gözükmezse ComboBox'tan aynı seçeneği tekrar seçiniz.";

            sonuc.Text = "sonuç:";
            sonuc.SetBounds(900, 650, 370, 40);

            //Form elemanları forma ekleniyor
            Controls.Add(m_Btn_İslem); //Buton oluşturuldu.
            Controls.Add(sonuc);
            Controls.Add(pBox);
            Controls.Add(gen1);
            Controls.Add(yuk1);
            Controls.Add(der1);
            Controls.Add(gen2);
            Controls.Add(yuk2);
            Controls.Add(der2);
            Controls.Add(r1);
            Controls.Add(r2);
            Controls.Add(x1);
            Controls.Add(y1);
            Controls.Add(z1);
            Controls.Add(x2);
            Controls.Add(y2);
            Controls.Add(z2);
            Controls.Add(pBox);
            Controls.Add(gen1l);
            Controls.Add(yuk1l);
            Controls.Add(der1l);
            Controls.Add(gen2l);
            Controls.Add(yuk2l);
            Controls.Add(der2l);
            Controls.Add(r1l);
            Controls.Add(r2l);
            Controls.Add(x1l);
            Controls.Add(y1l);
            Controls.Add(z1l);
            Controls.Add(x2l);
            Controls.Add(y2l);
            Controls.Add(z2l);
            Controls.Add(ilksekil);
            Controls.Add(ikisekil);
            Controls.Add(mesaj);
            
            //ComboBox için seçenekler ekleniyor.
            m_Btn_İslem.Items.Add("Nokta, Dörtgen çarpışma denetimi"); //0
            m_Btn_İslem.Items.Add("Nokta, çember çarpışm{a denetimi"); //1
            m_Btn_İslem.Items.Add("Dikdörtgen, dikdörtgen çarpışma denetimi"); //2
            m_Btn_İslem.Items.Add("Dikdörtgen, çember çarpışma denetimi"); //3
            m_Btn_İslem.Items.Add("Çember, çember çarpışma denetimi"); //4
            m_Btn_İslem.Items.Add("Nokta, Küre çarpışma denetimi"); //5
            m_Btn_İslem.Items.Add("Nokta, dikdörtgen prizma çarpışma denetimi"); //6
            m_Btn_İslem.Items.Add("Nokta, Silindir çarpışma denetimi"); //7
            m_Btn_İslem.Items.Add("Silindir, silindir çarpışma denetimi"); //8
            m_Btn_İslem.Items.Add("Küre, küre çarpışma denetimi"); //9
            m_Btn_İslem.Items.Add("Küre silindir çarpışma denetimi"); //10
            m_Btn_İslem.Items.Add("Yüzey, küre çarpışma denetimi"); //11
            m_Btn_İslem.Items.Add("Yüzey, dikdörtgen prizma çarpışma denetimi"); //12
            m_Btn_İslem.Items.Add("Yüzey silindir çarpışma denetimi"); //13
            m_Btn_İslem.Items.Add("Küre, dikdörtgen prizma çarpışma denetimi"); //14
            m_Btn_İslem.Items.Add("Dikdörtgen prizma, dikdörtgen prizma çarpışma denetimi"); //15
        }

        //Form uygulamasının iki boyutlu, şekillerin 3 boyutlu olmasından kaynaklı olarak görünümde hatalar olabilir.
        //şekillerimizi çizdiren fonksiyonlar 
        public void d_Ciz(dikdortgen d)
        {
            Graphics dikdortgen = pBox.CreateGraphics();
            dikdortgen.DrawRectangle(Pens.Black, 400 + d.m.X, 350 + d.m.Y, d.yuksek, d.genis);
        }

        public void n_Ciz(Nokta2d n)
        {
            Graphics nokta = pBox.CreateGraphics();
            nokta.DrawEllipse(Pens.Black, 400 + n.X-1, 350 + n.Y-1, 2, 2);
        }

        public void c_Ciz(Cember c)
        {
            Graphics cember = pBox.CreateGraphics();
            cember.DrawEllipse(Pens.Black, 400 + c.m.X - c.r  , 350 + c.m.Y - c.r, c.r*2, c.r*2);
        }

        public void k_Ciz(kure k)
        {
            Graphics kure = pBox.CreateGraphics();
            kure.DrawEllipse(Pens.Black, 400 + k.m.X - k.r, 350 + k.m.Y - k.r, k.r*2, k.r*2);
            kure.DrawEllipse(Pens.Black, 400 + k.m.X -k.r , 350 + k.m.Y-k.r/3, k.r*2 , k.r/2);
        }

        public void dp_Ciz(dikdortgenPrizma dp)
        {
            Graphics dpriz = pBox.CreateGraphics();
            dpriz.DrawRectangle(Pens.Black, 400 + dp.m.X - dp.genis / 2, 350 + dp.m.Y - dp.yuksek / 2, dp.genis, dp.yuksek);
            dpriz.DrawRectangle(Pens.Black, 400 + dp.m.X - dp.genis / 2+dp.derin/4, 350 + dp.m.Y - dp.yuksek / 2-dp.derin/4, dp.genis, dp.yuksek);
            dpriz.DrawLine(Pens.Black, 400 + dp.m.X - dp.genis / 2 + dp.derin / 4, 350 + dp.m.Y - dp.yuksek / 2 - dp.derin / 4, 400 + dp.m.X - dp.genis / 2, 350 + dp.m.Y - dp.yuksek / 2);
            dpriz.DrawLine(Pens.Black, 400 + dp.m.X + dp.genis / 2 + dp.derin / 4, 350 + dp.m.Y - dp.yuksek / 2 - dp.derin / 4, 400 + dp.m.X + dp.genis / 2, 350 + dp.m.Y - dp.yuksek / 2);
            dpriz.DrawLine(Pens.Black, 400 + dp.m.X - dp.genis / 2 + dp.derin / 4, 350 + dp.m.Y + dp.yuksek / 2 - dp.derin / 4, 400 + dp.m.X - dp.genis / 2, 350 + dp.m.Y + dp.yuksek / 2);
            dpriz.DrawLine(Pens.Black, 400 + dp.m.X + dp.genis / 2 + dp.derin / 4, 350 + dp.m.Y + dp.yuksek / 2 - dp.derin / 4, 400 + dp.m.X + dp.genis / 2, 350 + dp.m.Y + dp.yuksek / 2);

        }

        public void s_Ciz(silindir s)
        {
            Graphics silindir = pBox.CreateGraphics();
            silindir.DrawEllipse(Pens.Black, 400 + s.m.X - s.r, 350 + s.m.Y + s.h / 2, s.r*2, s.r / 4);
            silindir.DrawLine(Pens.Black, 400 + s.m.X - s.r, 350 + s.m.Y + s.h / 2 + s.r / 8, 400 + s.m.X - s.r, 350 + s.m.Y - s.h / 2 + s.r / 8);
            silindir.DrawEllipse(Pens.Black, 400 + s.m.X - s.r, 350 + s.m.Y - s.h / 2, s.r*2, s.r / 4);
            silindir.DrawLine(Pens.Black, 400 + s.m.X+s.r, 350 + s.m.Y + s.h / 2 + s.r / 8, 400 + s.m.X+s.r, 350 + s.m.Y - s.h / 2 + s.r / 8);
        }

        public void y_Ciz(yuzey y) //yuzey şekli z ekseninde ilerlediği için bazı durumlarda diğer şekle çarpıyor gibi görünebilir, ancak bu pencerenin 2 boyutlu olmasından kaynaklıdır.
        {
            Graphics yuzey = pBox.CreateGraphics();
            yuzey.DrawLine(Pens.Black, 400 + y.m.X - y.genis / 2 + y.derin / 4, 350 + y.m.Y - y.derin/2, 400 + y.m.X - y.genis / 2, 350 + y.m.Y - y.derin / 4);
            yuzey.DrawLine(Pens.Black, 400 + y.m.X + y.genis / 2 + y.derin / 4, 350 + y.m.Y - y.derin /2, 400 + y.m.X + y.genis / 2, 350 + y.m.Y - y.derin / 4);
            yuzey.DrawLine(Pens.Black, 400 + y.m.X - y.genis / 2 + y.derin / 4, 350 + y.m.Y - y.derin / 2, 400 + y.m.X + y.genis / 2 + y.derin / 4, 350 + y.m.Y - y.derin / 2);
            yuzey.DrawLine(Pens.Black, 400 + y.m.X - y.genis / 2, 350 + y.m.Y - y.derin / 4, 400 + y.m.X + y.genis / 2, 350 + y.m.Y - y.derin / 4);
        }

        //Bu fonksiyonda ComboBox'ın herhangi bir seçeneğine tıklandığında gerçekleşecek durumlar için komutlar oluşturuldu.
        public void m_Btn_İslen_Click(object sender, EventArgs e)
        {
            //eğer index'i 0 olan seçenek seçilirse aşağıdaki işlemler yapılacak
            if(m_Btn_İslem.SelectedIndex==0)
            {
                //TextBox ile kullanıcıdan veriler alınıyor.
                Nokta2d n = new Nokta2d();
                n.X = int.Parse(x1.Text);
                n.Y = int.Parse(y1.Text);

                dikdortgen d = new dikdortgen();
                d.m.X = int.Parse(x2.Text);
                d.m.Y = int.Parse(y2.Text);
                d.genis = int.Parse(gen2.Text);
                d.yuksek = int.Parse(yuk2.Text);

                //Şekiller için çarpışma denetimi gerçekleştiriliyor.
                if (CapismaDenetimi.NoktaDortgen(n, d))
                    sonuc.Text += "Nokta, dörtgen çarpıştı.";
                else
                    sonuc.Text += "Nokta,dörtgen çarpışmadı.";
                d_Ciz(d); n_Ciz(n);
            }

            //Diğer seçenekler için de koşullar ekleniyor.
            else if (m_Btn_İslem.SelectedIndex==1)
            {
                Nokta2d n = new Nokta2d();
                n.X = int.Parse(x1.Text);
                n.Y = int.Parse(y1.Text);

                Cember c = new Cember();
                c.m.X = int.Parse(x2.Text);
                c.m.Y = int.Parse(y2.Text);
                c.r = int.Parse(r2.Text);

                if (CapismaDenetimi.NoktaCember(n, c))
                    sonuc.Text += "Nokta, çember çarpıştı.";
                else
                    sonuc.Text += "Nokta,çember çarpışmadı.";
                c_Ciz(c); n_Ciz(n);
            }

            else if (m_Btn_İslem.SelectedIndex == 2)
            {
                dikdortgen d1 = new dikdortgen();
                d1.m.X = int.Parse(x1.Text);
                d1.m.Y = int.Parse(y1.Text);
                d1.genis = int.Parse(gen1.Text);
                d1.yuksek = int.Parse(yuk1.Text);

                dikdortgen d2 = new dikdortgen();
                d2.m.X = int.Parse(x2.Text);
                d2.m.Y = int.Parse(y2.Text);
                d2.genis = int.Parse(gen2.Text);
                d2.yuksek = int.Parse(yuk2.Text);

                if (CapismaDenetimi.DikdortgenDikdortgen(d1, d2))
                    sonuc.Text += "Dikdörtgen, dörtgen çarpıştı";
                else
                    sonuc.Text += "Dikdörtgen,dörtgen çarpışmadı";
                d_Ciz(d1); d_Ciz(d2);
            }

            else if (m_Btn_İslem.SelectedIndex == 3)
            {
                dikdortgen d = new dikdortgen();
                d.m.X = int.Parse(x1.Text);
                d.m.Y = int.Parse(y1.Text);
                d.genis = int.Parse(gen1.Text);
                d.yuksek = int.Parse(yuk1.Text);

                Cember c = new Cember();
                c.m.X = int.Parse(x2.Text);
                c.m.Y = int.Parse(y2.Text);
                c.r = int.Parse(r2.Text);

                if (CapismaDenetimi.DikdortgenCember(d, c))
                    sonuc.Text += "Dikdörtgen, dikörtgen çarpıştı";
                else
                    sonuc.Text += "Dikdörtgen, dikörtgen çarpışmadı";
                d_Ciz(d); c_Ciz(c);
            }

            else if (m_Btn_İslem.SelectedIndex == 4)
            {
                Cember c1 = new Cember();
                c1.m.X = int.Parse(x1.Text);
                c1.m.Y = int.Parse(y1.Text);
                c1.r = int.Parse(r1.Text);

                Cember c2 = new Cember();
                c2.m.X = int.Parse(x2.Text);
                c2.m.Y = int.Parse(y2.Text);
                c2.r = int.Parse(r2.Text);

                if (CapismaDenetimi.CemberCember(c1, c2))
                    sonuc.Text += "çemberler çarpıştı";
                else
                    sonuc.Text += "çemberler çarpışmadı";
                c_Ciz(c1); c_Ciz(c2);
            }

            else if (m_Btn_İslem.SelectedIndex == 5)
            {
                Nokta3d n = new Nokta3d();
                n.X = int.Parse(x1.Text);
                n.Y = int.Parse(y1.Text);
                n.Z = int.Parse(z1.Text);

                kure k = new kure();
                k.m.X= int.Parse(x2.Text);
                k.m.Y = int.Parse(y2.Text);
                k.m.Z = int.Parse(z2.Text);
                k.r = int.Parse(r2.Text);

                if (CapismaDenetimi.NoktaKure(n, k))
                    sonuc.Text += "Nokta, küre çarpıştı";
                else
                    sonuc.Text += "Nokta, küre çarpışmadı";
                n_Ciz(n); k_Ciz(k);
            }

            else if (m_Btn_İslem.SelectedIndex == 6)
            {
                Nokta3d n = new Nokta3d();
                n.X = int.Parse(x1.Text);
                n.Y = int.Parse(y1.Text);
                n.Z = int.Parse(z1.Text);

                dikdortgenPrizma dp = new dikdortgenPrizma();
                dp.m.X = int.Parse(x2.Text);
                dp.m.Y = int.Parse(y2.Text);
                dp.m.Z = int.Parse(z2.Text);

                dp.genis = int.Parse(gen2.Text);
                dp.yuksek = int.Parse(yuk2.Text);
                dp.derin = int.Parse(der2.Text);

                if (CapismaDenetimi.NoktaDikPriz(n, dp))
                    sonuc.Text += "Nokta, dikdörtgen prizma çarpıştı";
                else
                    sonuc.Text += "Nokta, dikdörtgen prizma çarpışmadı";
                n_Ciz(n); dp_Ciz(dp);
            }

            else if (m_Btn_İslem.SelectedIndex == 7)
            {
                Nokta3d n = new Nokta3d();
                n.X = int.Parse(x1.Text);
                n.Y = int.Parse(y1.Text);
                n.Z = int.Parse(z1.Text);

                silindir s= new silindir();
                s.m.X = int.Parse(x2.Text);
                s.m.Y = int.Parse(y2.Text);
                s.m.Z = int.Parse(z2.Text);
                s.r = int.Parse(r2.Text);
                s.h = int.Parse(yuk2.Text);

                if (CapismaDenetimi.NoktaSilindir(n, s))
                    sonuc.Text += "Nokta, silindir çarpıştı";
                else
                    sonuc.Text += "Nokta, silindir çarpışmadı";
                n_Ciz(n); s_Ciz(s);
            }

            else if (m_Btn_İslem.SelectedIndex == 8)
            {
                silindir s1 = new silindir();
                s1.m.X = int.Parse(x1.Text);
                s1.m.Y = int.Parse(y1.Text);
                s1.m.Z = int.Parse(z1.Text);
                s1.r = int.Parse(r1.Text);
                s1.h = int.Parse(yuk1.Text);

                silindir s2 = new silindir();
                s2.m.X = int.Parse(x2.Text);
                s2.m.Y = int.Parse(y2.Text);
                s2.m.Z = int.Parse(z2.Text);
                s2.r = int.Parse(r2.Text);
                s2.h = int.Parse(yuk2.Text);

                if (CapismaDenetimi.SilindirSilindir(s1, s2))
                    sonuc.Text += "Silindirler çarpıştı";
                else
                    sonuc.Text += "Silindirler çarpışmadı";
                s_Ciz(s1); ;s_Ciz(s2);
            }

            else if (m_Btn_İslem.SelectedIndex == 9)
            {
                kure k1 = new kure();
                k1.m.X = int.Parse(x1.Text);
                k1.m.Y = int.Parse(y1.Text);
                k1.m.Z = int.Parse(z1.Text);
                k1.r = int.Parse(r1.Text);

                kure k2 = new kure();
                k2.m.X = int.Parse(x2.Text);
                k2.m.Y = int.Parse(y2.Text);
                k2.m.Z = int.Parse(z2.Text);
                k2.r = int.Parse(r2.Text);

                if (CapismaDenetimi.KureKure(k1, k2))
                    sonuc.Text += "Küreler çarpıştı";
                else
                    sonuc.Text += "Küreler çarpışmadı";

                k_Ciz(k1);k_Ciz(k2);
            }

            else if (m_Btn_İslem.SelectedIndex == 10)
            {
                kure k = new kure();
                k.m.X = int.Parse(x1.Text);
                k.m.Y = int.Parse(y1.Text);
                k.m.Z = int.Parse(z1.Text);
                k.r = int.Parse(r1.Text);

                silindir s = new silindir();
                s.m.X = int.Parse(x2.Text);
                s.m.Y = int.Parse(y2.Text);
                s.m.Z = int.Parse(z2.Text);
                s.r = int.Parse(r2.Text);
                s.h = int.Parse(yuk2.Text);

                if (CapismaDenetimi.KureSilindir(k, s))
                    sonuc.Text += "Silindir, küre çarpıştı";
                else
                    sonuc.Text += "Silindir, küre çarpışmadı";
                k_Ciz(k); s_Ciz(s);
            }

            else if (m_Btn_İslem.SelectedIndex == 11)
            {
                yuzey y = new yuzey();
                y.m.X = int.Parse(x1.Text);
                y.m.Y = int.Parse(y1.Text);
                y.m.Z = int.Parse(z1.Text);
                y.genis = int.Parse(gen1.Text);
                y.derin = int.Parse(der1.Text);

                kure k = new kure();
                k.m.X = int.Parse(x2.Text);
                k.m.Y = int.Parse(y2.Text);
                k.m.Z = int.Parse(z2.Text);
                k.r = int.Parse(r2.Text);

                if (CapismaDenetimi.YuzeyKure(y,k))
                    sonuc.Text += "Yüzey, küre çarpıştı";
                else
                    sonuc.Text += "Yüzey, küre çarpışmadı";
                y_Ciz(y); k_Ciz(k);
            }

            else if (m_Btn_İslem.SelectedIndex == 12)
            {
                yuzey y = new yuzey();
                y.m.X = int.Parse(x1.Text);
                y.m.Y = int.Parse(y1.Text);
                y.m.Z = int.Parse(z1.Text);
                y.genis = int.Parse(gen1.Text);
                y.derin = int.Parse(der1.Text);

                dikdortgenPrizma dp = new dikdortgenPrizma();
                dp.m.X = int.Parse(x2.Text);
                dp.m.Y = int.Parse(y2.Text);
                dp.m.Z = int.Parse(z2.Text);

                dp.genis = int.Parse(gen2.Text);
                dp.yuksek = int.Parse(yuk2.Text);
                dp.derin = int.Parse(der2.Text);

                if (CapismaDenetimi.YuzeyDikPriz(y,dp))
                    sonuc.Text += "Yüzey, dikdörtgen prizma çarpıştı";
                else
                    sonuc.Text += "Yüzey, dikdörtgen prizma çarpışmadı";
                y_Ciz(y); dp_Ciz(dp);
            }

            else if (m_Btn_İslem.SelectedIndex == 13)
            {
                yuzey y = new yuzey();
                y.m.X = int.Parse(x1.Text);
                y.m.Y = int.Parse(y1.Text);
                y.m.Z = int.Parse(z1.Text);
                y.genis = int.Parse(gen1.Text);
                y.derin = int.Parse(der1.Text);

                silindir s = new silindir();
                s.m.X = int.Parse(x2.Text);
                s.m.Y = int.Parse(y2.Text);
                s.m.Z = int.Parse(z2.Text);
                s.r = int.Parse(r2.Text);
                s.h = int.Parse(yuk2.Text);

                if (CapismaDenetimi.YuzeySilindir(y,s))
                    sonuc.Text += "Yüzey, silindir prizma çarpıştı";
                else
                    sonuc.Text += "Yüzey, silindir prizma çarpışmadı";
                y_Ciz(y); s_Ciz(s);
            }

            else if (m_Btn_İslem.SelectedIndex == 14)
            {
                kure k = new kure();
                k.m.X = int.Parse(x1.Text);
                k.m.Y = int.Parse(y1.Text);
                k.m.Z = int.Parse(z1.Text);
                k.r = int.Parse(r1.Text);

                dikdortgenPrizma dp = new dikdortgenPrizma();
                dp.m.X = int.Parse(x2.Text);
                dp.m.Y = int.Parse(y2.Text);
                dp.m.Z = int.Parse(z2.Text);

                dp.genis = int.Parse(gen2.Text);
                dp.yuksek = int.Parse(yuk2.Text);
                dp.derin = int.Parse(der2.Text);

                if (CapismaDenetimi.KureDikPriz(k,dp))
                    sonuc.Text += "Küre, dikdörtgen prizma çarpıştı";
                else
                    sonuc.Text += "Küre, dikdörtgen prizma çarpışmadı";
                k_Ciz(k); dp_Ciz(dp);
            }

            else if (m_Btn_İslem.SelectedIndex == 15)
            {
                dikdortgenPrizma dp1 = new dikdortgenPrizma();
                dp1.m.X = int.Parse(x1.Text);
                dp1.m.Y = int.Parse(y1.Text);
                dp1.m.Z = int.Parse(z1.Text);
                dp1.genis = int.Parse(gen1.Text);
                dp1.yuksek = int.Parse(yuk1.Text);
                dp1.derin = int.Parse(der1.Text);

                dikdortgenPrizma dp2 = new dikdortgenPrizma();
                dp2.m.X = int.Parse(x2.Text);
                dp2.m.Y = int.Parse(y2.Text);
                dp2.m.Z = int.Parse(z2.Text);
                dp2.genis = int.Parse(gen2.Text);
                dp2.yuksek = int.Parse(yuk2.Text);
                dp2.derin = int.Parse(der2.Text);

                if (CapismaDenetimi.DikPrizDikPriz(dp1, dp2))
                    sonuc.Text += "Dikdörtgen prizma, dikdörtgen prizma çarpıştı";
                else
                    sonuc.Text += "Dikdörtgen prizma, dikdörtgen prizma çarpışmadı";
                dp_Ciz(dp1); dp_Ciz(dp2);
            }
        }
    }
}
