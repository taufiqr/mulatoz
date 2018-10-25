using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class D
    {
        public List<string> DATA_SENSOR { get; set; }
        public List<int> Sensor_suhu { get; set; }
        public List<int> airflow { get; set; }
        public List<int> burner { get; set; }
        public List<int> drum { get; set; }
        public List<double> user { get; set; }
    }

    public class DataSensor
    {
        public D d { get; set; }
        public DateTime ts { get; set; }
    }
}
