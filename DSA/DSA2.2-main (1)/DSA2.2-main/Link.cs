using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Link
    {
        public string vertex1;
        public string vertex2;
        public double distance;
        public double speed;

        public Link (string vertex1, string vertex2, double distance, double speed)
        {
            this.vertex1 = vertex1;
            this.vertex2 = vertex2;
            this.distance = distance;
            this.speed = speed;
        }
    }
}
