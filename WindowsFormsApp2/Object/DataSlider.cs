using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2.Object
{
    public class DataSlider
    {
        public D d { get; set; }
    }

    public class D
    {
        public List<double> af { get; set; }
        public List<double> br { get; set; }
        public List<double> ds { get; set; }
        public double sv { get; set; }
    }
}
