using Earthquake.API.DTO;
using Earthquake.API.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Earthquake.API.Services.Interfaces
{
    public interface IEarthquakeService
    {
        Task<List<EarthquakeViewModel>> GetQuakes(EarthquakeQuery query);
    }
}
