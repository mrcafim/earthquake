using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Earthquake.API.Models.Responses.USGS
{
    public class Feature
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public FeatureProperty Properties { get; set; }

        [JsonProperty("geometry")]
        public FeatureGeometry Geometry { get; set; }
    }
}
