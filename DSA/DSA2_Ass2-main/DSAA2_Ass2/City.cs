using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA2_Ass2
{
    internal class City
    {
        public string name { get; set; }
        public City pointerToPreviousCity { get; set; }
        public float timeToReachThisCity { get; set; }
        public City(string _name)
        {
            name = _name;
            timeToReachThisCity = float.MaxValue;
        }
    }
}
