using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSA2_Ass2
{
    public partial class Form : Form
    {

        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region cities to Pixels
            List<Pixel> citiesP = new List<Pixel>();
            Pixel Varna = new Pixel(831, 299, "Varna");
            Pixel Dobrich = new Pixel(766, 166, "Dobrich");
            Pixel Silistra = new Pixel(646, 55, "Silistra");
            Pixel Razgrad = new Pixel(500, 136, "Razgrad");
            Pixel Turgovishte = new Pixel(427, 248, "Turgovishte");
            Pixel Shumen = new Pixel(615, 300, "Shumen");
            Pixel Burgas = new Pixel(751, 513, "Burgas");
            Pixel Yambol = new Pixel(498, 473, "Yambol");
            Pixel VelikoTurnovo = new Pixel(246, 288, "Veliko Turnovo");
            Pixel Plovdiv = new Pixel(228, 513, "Plovdiv");
            Pixel Sofia = new Pixel(51, 361, "Sofia");
            citiesP.Add(Varna);
            citiesP.Add(Dobrich);
            citiesP.Add(Silistra);
            citiesP.Add(Razgrad);
            citiesP.Add(Turgovishte);
            citiesP.Add(Shumen);
            citiesP.Add(Burgas);
            citiesP.Add(VelikoTurnovo);
            citiesP.Add(Yambol);
            citiesP.Add(Plovdiv);
            citiesP.Add(Sofia);
            #endregion

            Map map = new Map();
            map.fillMap();
            string start = Start.Text;
            string destination = Destination.Text;
            map.DoDijkstraMagic(start);
            List<City> result = map.getCitiesPath(destination);
            for (int i = 0; i < result.Count - 1; i++)
            {
                Pen graphPen = new Pen(Color.Red, 3);
                Pixel p1 = new Pixel(1, 1, "");
                Pixel p2 = new Pixel(1, 1, "");
                Graphics g = MapImage.CreateGraphics();
                foreach (var city in citiesP)
                {
                    if (result[i].name.Equals(city.name))
                    {
                        p1 = city;
                    };
                }
                foreach (var city in citiesP)
                {
                    if (result[i].pointerToPreviousCity == null) { }
                    else
                    {
                        if (result[i].pointerToPreviousCity.name.Equals(city.name))
                        {
                            p2 = city;
                        };
                    }
                }

                g.DrawLine(graphPen, p1.x, p1.y, p2.x, p2.y);
            }

            City display = null;
            display = map.findCity(destination, display);
            Message.Text = $"The best path from {start} to {destination} will take around {display.timeToReachThisCity} hours.";
        }

        private void MapImage_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pen graphPen = new Pen(Color.Black, 3);

            Pixel Varna = new Pixel(831, 299, "Varna");
            Pixel Dobrich = new Pixel(766, 166, "Dobrich");
            Pixel Silistra = new Pixel(646, 55, "Silistra");
            Pixel Razgrad = new Pixel(500, 136, "Razgrad");
            Pixel Turgovishte = new Pixel(427, 248, "Turgovishte");
            Pixel Shumen = new Pixel(615, 300, "Shumen");
            Pixel Burgas = new Pixel(751, 513, "Burgas");
            Pixel Yambol = new Pixel(498, 473, "Yambol");
            Pixel VelikoTurnovo = new Pixel(246, 288, "Veliko Turnovo");
            Pixel Plovdiv = new Pixel(228, 513, "Plovdiv");
            Pixel Sofia = new Pixel(51, 361, "Sofia");

            Graphics g = MapImage.CreateGraphics();
            g.DrawLine(graphPen, Varna.x, Varna.y, Dobrich.x, Dobrich.y);
            g.DrawLine(graphPen, Varna.x, Varna.y, Razgrad.x, Razgrad.y);
            g.DrawLine(graphPen, Varna.x, Varna.y, Shumen.x, Shumen.y);
            g.DrawLine(graphPen, Varna.x, Varna.y, Burgas.x, Burgas.y);
            g.DrawLine(graphPen, Dobrich.x, Dobrich.y, Silistra.x, Silistra.y);
            g.DrawLine(graphPen, Silistra.x, Silistra.y, Razgrad.x, Razgrad.y);
            g.DrawLine(graphPen, Shumen.x, Shumen.y, Turgovishte.x, Turgovishte.y);
            g.DrawLine(graphPen, Silistra.x, Silistra.y, Razgrad.x, Razgrad.y);
            g.DrawLine(graphPen, Burgas.x, Burgas.y, Shumen.x, Shumen.y);
            g.DrawLine(graphPen, Burgas.x, Burgas.y, Yambol.x, Yambol.y);
            g.DrawLine(graphPen, Turgovishte.x, Turgovishte.y, VelikoTurnovo.x, VelikoTurnovo.y);
            g.DrawLine(graphPen, Yambol.x, Yambol.y, VelikoTurnovo.x, VelikoTurnovo.y);
            g.DrawLine(graphPen, Yambol.x, Yambol.y, Plovdiv.x, Plovdiv.y);
            g.DrawLine(graphPen, VelikoTurnovo.x, VelikoTurnovo.y, Sofia.x, Sofia.y);
            g.DrawLine(graphPen, Plovdiv.x, Plovdiv.y, Sofia.x, Sofia.y);
            g.DrawLine(graphPen, Razgrad.x, Razgrad.y, Turgovishte.x, Turgovishte.y);
            g.DrawLine(graphPen, Yambol.x, Yambol.y, Shumen.x, Shumen.y);
        }

        private void Destination_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }
    }
}