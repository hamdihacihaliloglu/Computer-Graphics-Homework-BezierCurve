using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BezierCurve
{
    public partial class Form1 : Form
    {
        /*Noktaları P0(0,0) , P1(1,2.25) , P2(3.5,0.75) , P3(2.75,0) olarak verilen üçüncü dereceden bir bezier eğrisi çizen program*/
        public Form1()
        {
            InitializeComponent();
        }
        System.Drawing.Graphics eksenCizgi;
        System.Drawing.Graphics elipsCiz;

        Pen kalemKirmizi = new Pen(Color.Red, 2);

        private int koordinatHesaplaX(float geciciX)
        {
            return Convert.ToInt32(400 + (80 * geciciX));
        }
        private int koordinatHesaplaY(float geciciY)
        {
            return Convert.ToInt32(225 + (-50 * geciciY));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void koordinat_ciz_Click(object sender, EventArgs e)
        {
            eksenCizgi = this.CreateGraphics();
            eksenCizgi.DrawLine(kalemKirmizi, koordinatHesaplaX(-5), koordinatHesaplaY(0), koordinatHesaplaX(5), koordinatHesaplaY(0));
            eksenCizgi.DrawLine(kalemKirmizi, koordinatHesaplaX(0), koordinatHesaplaY(-5), koordinatHesaplaX(0), koordinatHesaplaY(5));
            eksenCizgi.Dispose();
        }
        private void kontrol_noktasi_ciz_Click(object sender, EventArgs e)
        {
            elipsCiz = this.CreateGraphics();

            elipsCiz.DrawEllipse(kalemKirmizi, koordinatHesaplaX(0), koordinatHesaplaY(0), 10, 5);
            elipsCiz.DrawEllipse(kalemKirmizi, koordinatHesaplaX(1), koordinatHesaplaY(2.25f), 10, 5);
            elipsCiz.DrawEllipse(kalemKirmizi, koordinatHesaplaX(3.5f), koordinatHesaplaY(0.75f), 10, 5);
            elipsCiz.DrawEllipse(kalemKirmizi, koordinatHesaplaX(2.75f), koordinatHesaplaY(0), 10, 5);
        }
        private void bezier_ciz_Click(object sender, EventArgs e)
        {
            /*
           Formül::
           C(u) = P0 * (1-u)^3 + P1 * 3u * (1-u)^2 +P2 *3 * u^2 * (1-u) + P3 * u^3                     
            */
            double u = 0.0;
            double a = 0.01;
            Graphics g = this.CreateGraphics();

            float baslangic_xu = (float)(Math.Pow((1 - u), 3) * koordinatHesaplaX(0) + 3 * u * Math.Pow((1 - u), 2) * koordinatHesaplaX(1) + 3 * Math.Pow(u, 2) * (1 - u) * koordinatHesaplaX(3.5f) + Math.Pow(u, 3) * koordinatHesaplaX(2.75f));
            float baslangic_yu = (float)(Math.Pow((1 - u), 3) * koordinatHesaplaY(0) + 3 * u * Math.Pow((1 - u), 2) * koordinatHesaplaY(2.25f) + 3 * Math.Pow(u, 2) * (1 - u) * koordinatHesaplaY(0.75f) + Math.Pow(u, 3) * koordinatHesaplaY(0));

            for (u = 0.0001; u <= 1.0; u += a)
            {

                float xu = (float)(Math.Pow((1 - u), 3) * koordinatHesaplaX(0) + 3 * u * Math.Pow((1 - u), 2) * koordinatHesaplaX(1) + 3 * Math.Pow(u, 2) * (1 - u) * koordinatHesaplaX(3.5f) + Math.Pow(u, 3) * koordinatHesaplaX(2.75f));
                float yu = (float)(Math.Pow((1 - u), 3) * koordinatHesaplaY(0) + 3 * u * Math.Pow((1 - u), 2) * koordinatHesaplaY(2.25f) + 3 * Math.Pow(u, 2) * (1 - u) * koordinatHesaplaY(0.75f) + Math.Pow(u, 3) * koordinatHesaplaY(0));

                g.DrawLine(kalemKirmizi, baslangic_xu, baslangic_yu, xu, +yu);
                baslangic_xu = xu;
                baslangic_yu = yu;
            }
            kalemKirmizi.Dispose();
        }
    }
}
