using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Earthquake.API.DTO
{
    public class EarthquakeQuery
    {
        public double Lat { get; set; }
        public double Long { get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_date { get; set; }

    }
}
