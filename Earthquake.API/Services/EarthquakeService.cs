using Earthquake.API.DTO;
using Earthquake.API.Models.Responses.USGS;
using Earthquake.API.Models.ViewModels;
using Earthquake.API.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Earthquake.API.Services
{
    public class EarthquakeService : IEarthquakeService
    {
        private readonly IUSGSService _uSGSService;

        public EarthquakeService(IUSGSService uSGSService)
        {
            _uSGSService = uSGSService;
        }

        public async Task<List<EarthquakeViewModel>> GetQuakes(EarthquakeQuery query)
        {
            var usgsData = await _uSGSService.GetData(query);

            if (usgsData.Features.Count == 0)
                return null;

            var earthquakes = getEarthquakes(usgsData, query);

            return earthquakes;
        }

        private List<EarthquakeViewModel> getEarthquakes(USGSResponse usgsData, EarthquakeQuery query)
        {
            var list = new List<EarthquakeViewModel>();

            usgsData.Features.ForEach(x => list.Add(new EarthquakeViewModel(x, query)));

            return list;
        }
    }
}
