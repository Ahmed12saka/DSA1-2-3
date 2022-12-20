using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA2_Ass2
{
    internal class Pixel
    {
        public float x { get; set; }
        public float y { get; set; }
        public string name { get; set; }
        public Pixel(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }
}