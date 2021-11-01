using Earthquake.API.DTO;
using Earthquake.API.Models.Responses.USGS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Earthquake.API.Models.ViewModels
{
    public class EarthquakeViewModel
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public string Place { get; set; }
        public float Magnitude { get; set; }
        public long Date { get; set; }
        public double DistanceKM { get; set; }

        public EarthquakeViewModel() { }
        public EarthquakeViewModel(Feature feature, EarthquakeQuery query)
        {
            Code = feature.Properties.Code;
            Title = feature.Properties.Title;
            Place = feature.Properties.Place;
            Magnitude = feature.Properties.Magnitude;
            Date = feature.Properties.Time;

            SetDistance(feature.Geometry, query);
        }

        public void SetDistance(FeatureGeometry geometry, EarthquakeQuery query)
        {
            var baseRad = Math.PI * query.Lat / 180;
            var targetRad = Math.PI * geometry.Coordinates[1] / 180;
            var theta = query.Long - geometry.Coordinates[0];
            var thetaRad = Math.PI * theta / 180;

            double dist =
                Math.Sin(baseRad) * Math.Sin(targetRad) + Math.Cos(baseRad) *
                Math.Cos(targetRad) * Math.Cos(thetaRad);
            dist = Math.Acos(dist);

            dist = dist * 180 / Math.PI;
            dist = dist * 60 * 1.1515;

            DistanceKM = dist * 1.609344;
        }
    }
}
