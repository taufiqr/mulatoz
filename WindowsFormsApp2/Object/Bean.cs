using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Bean
    {
        public Bean(string json)
        {
            JObject jObject = JObject.Parse(json);
            JToken jd = jObject["d"];
            kopi_bean = (string)jd["kopi_bean"];
            kopi_size = (string)jd["kopi_size"];
            kopi_country = (string)jd["kopi_country"];
            kopi_region = (string)jd["kopi_region"];
            kopi_proses = (string)jd["kopi_proses"];
            kopi_harvest = (string)jd["kopi_harvest"];
            kopi_moister = (string)jd["kopi_moister"];
            kopi_vendor = (string)jd["kopi_vendor"];
            selection_kopi = (int)jd["selection_kopi"];
            count_kopi = (int)jd["count_kopi"];
            command_kopi = (int)jd["command_kopi"];
            
        }

        public string kopi_bean { get; set; }
        public string kopi_size { get; set; }
        public string kopi_country { get; set; }
        public string kopi_region { get; set; }
        public string kopi_proses { get; set; }
        public string kopi_harvest { get; set; }
        public string kopi_moister { get; set; }
        public string kopi_vendor { get; set; }
        public int selection_kopi { get; set; }
        public int count_kopi { get; set; }
        public int command_kopi { get; set; }
    }
}
