using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Init();
            InitializeComponent();
        }

        private void FindPath_Click(object sender, EventArgs e)
        {
            Refresh();
            Graphics gr = this.CreateGraphics();
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            string start = startCity.Text;
            string end = endCity.Text;
            double totalDistance = 0;
            if (start == end)
            {
                message.BackColor = Color.Red;
                message.Text = "Input invalid";
                timeBox.Text = null;
                distance.Text = null;
            }
            else if (startCity.Text == "Select start city" || endCity.Text == "Select destination")
            {
                message.BackColor = Color.Red;
                message.Text = "Input ivalid";
                timeBox.Text = null;
                distance.Text = null;
            }
            else
            {
                List<Label> labels = new List<Label>()
            {
                lblBurgas,
                lblDobrich,
                lblKazanlyk,
                lblRazgrad,
                lblShumen,
                lblSilistra,
                lblSliven,
                lblStaraZagora,
                lblTyrgowishte,
                lblVarna,
                lblVelikoTyrnovo,
                lblYambol
            };
                List<string> path = GetShortestPath(start, end, timeBox);
                List<Label> draw = new List<Label>();
                foreach (string city in path)
                {
                    foreach (Label label in labels)
                    {
                        if (label.Text == city)
                        {
                            draw.Add(label);
                        }
                    }
                }
                foreach (Link node in links)
                {
                    for (int i = 0; i < path.Count; i++)
                    {
                        if (i + 1 == path.Count)
                        {
                            break;
                        }
                        if (node.vertex1 == path[i] && node.vertex2 == path[i + 1])
                        {
                            totalDistance = totalDistance + node.distance;
                        }
                        else if (node.vertex1 == path[i + 1] && node.vertex2 == path[i])
                        {
                            totalDistance = totalDistance + node.distance;
                        }
                    }
                }
                for (int i = 0; i < draw.Count; i++)
                {
                    gr.DrawLine(pen, draw[i].Location.X, draw[i].Location.Y,
                        draw[i + 1].Location.X, draw[i + 1].Location.Y);
                    if (i + 1 == draw.Count - 1)
                    {
                        break;
                    }
                }
                message.BackColor = Color.Green;
                message.Text = "Success!";
                distance.Text = Convert.ToString($"{totalDistance} km");
            }
        }

        static List<Link> links = new List<Link>();

        static void Init()
        {
            links.Add(new Link("Varna", "Dobrich", 52, 60));
            links.Add(new Link("Varna", "Burgas", 116, 60));
            links.Add(new Link("Varna", "Shumen", 90, 60));
            links.Add(new Link("Dobrich", "Silistra", 90, 60));
            links.Add(new Link("Silistra", "Shumen", 113, 60));
            links.Add(new Link("Silistra", "Razgrad", 119, 60));
            links.Add(new Link("Silistra", "Veliko Tyrnovo", 230, 60));
            links.Add(new Link("Shumen", "Razgrad", 50, 60));
            links.Add(new Link("Shumen", "Tyrgowishte", 42, 60));
            links.Add(new Link("Shumen", "Sliven", 135, 60));
            links.Add(new Link("Tyrgowishte", "Razgrad", 37, 60));
            links.Add(new Link("Tyrgowishte", "Veliko Tyrnovo", 100, 60));
            links.Add(new Link("Tyrgowishte", "Sliven", 110, 60));
            links.Add(new Link("Veliko Tyrnovo", "Kazanlyk", 100, 60));
            links.Add(new Link("Veliko Tyrnovo", "Sliven", 112, 60));
            links.Add(new Link("Veliko Tyrnovo", "Razgrad", 117, 60));
            links.Add(new Link("Kazanlyk", "Sliven", 87, 60));
            links.Add(new Link("Kazanlyk", "Stara Zagora", 35, 60));
            links.Add(new Link("Stara Zagora", "Yambol", 87, 60));
            links.Add(new Link("Yambol", "Sliven", 29, 60));
            links.Add(new Link("Yambol", "Burgas", 93, 60));
            links.Add(new Link("Sliven", "Burgas", 115, 60));
        }

        private static Dictionary<string, double> GetNeighbors(string node)
        {
            Dictionary<string, double> citiesTime = new Dictionary<string, double>();

            foreach (Link city in links)
            {
                if (city.vertex1 == node)
                {
                    citiesTime.Add(city.vertex2, city.distance / city.speed);
                }
                else if (city.vertex2 == node)
                {
                    citiesTime.Add(city.vertex1, city.distance / city.speed);
                }
            }
            return citiesTime;
        }

        private static List<string> GetShortestPath(string start, string end, TextBox timebox)
        {
            Dictionary<string, double> smallesttime = new Dictionary<string, double>();
            Dictionary<string, string> prevPath = new Dictionary<string, string>();
            List<string> visited = new List<string>();
            Queue<string> nodesToVisit = new Queue<string>();
            
            smallesttime.Add(start, 0);
            visited.Add(start);

            string currentNode = start;

            while (true)
            {
                double time = smallesttime[currentNode];

                Dictionary<string, double> next = GetNeighbors(currentNode);

                foreach (KeyValuePair<string, double> value in next)
                {
                    string neighbor = value.Key;
                    double cost = value.Value;

                    if (!visited.Contains(neighbor))
                    {
                        nodesToVisit.Enqueue(neighbor);
                    }

                    double thisTime = time + cost;

                    if (prevPath.ContainsKey(neighbor))
                    {
                        double anotherTime = smallesttime[neighbor];

                        if (thisTime < anotherTime)
                        {
                            prevPath[neighbor] = currentNode;
                            smallesttime[neighbor] = thisTime;
                        }
                    }
                    else
                    {
                        prevPath[neighbor] = currentNode;
                        smallesttime[neighbor] = thisTime;
                    }
                }
                visited.Add(currentNode);

                if (nodesToVisit.Count == 0)
                {
                    break;
                }

                currentNode = nodesToVisit.Dequeue();
            }

            List<string> path = new List<string>();

            currentNode = end;

            while (currentNode != start)
            {
                path.Add(currentNode);

                currentNode = prevPath[currentNode];
            }

            path.Add(start);

            double costToDisplay = smallesttime[end];
            double decimalPart = costToDisplay - Math.Truncate(costToDisplay);
            double decimalPartMin = decimalPart * 60;

            if (Math.Truncate(costToDisplay) == 0)
            {
                timebox.Text = Convert.ToString($"{(decimalPartMin)} min");
            }
            else
            {
                timebox.Text = Convert.ToString($"{(costToDisplay)} h {(decimalPartMin)} min");
            }

            return path;
        }
    }
}
