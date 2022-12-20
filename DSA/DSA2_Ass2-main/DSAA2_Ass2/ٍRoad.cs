using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA2_Ass2_WinForm
{
    internal class Road
    {
        public City city1 { get; set; }
        public City city2 { get; set; }
        public int maxSpeed { get; set; }
        public int distance { get; set; }
        public Road(City _city1, City _city2, int _maxSpeed, int _distance)
        {
            city1 = _city1;
            city2 = _city2;
            maxSpeed = _maxSpeed;
            distance = _distance;
        }
    }
}