using Earthquake.API.DTO;
using Earthquake.API.Models.Responses.USGS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Earthquake.API.Services.Interfaces
{
    public interface IUSGSService
    {
        Task<USGSResponse> GetData(EarthquakeQuery query);
    }
}
