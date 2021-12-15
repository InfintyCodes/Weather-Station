using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveToSqlDB.Models
{
    internal class DhtMeasurment
    {
        public string deviceId { set; get; }
        public float temperature { get; set; }
        public float humidity { get; set; }
        public long epochTime { set; get; }
    }
}
