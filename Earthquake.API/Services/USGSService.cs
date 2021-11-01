using Earthquake.API.DTO;
using Earthquake.API.Models.Responses.USGS;
using Earthquake.API.Services.Interfaces;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Earthquake.API.Services
{
    public class USGSService : IUSGSService
	{
		private readonly IConfiguration _Configuration;
        public USGSService(IConfiguration Configuration)
        {
            _Configuration = Configuration;
        }
        public async Task<USGSResponse> GetData(EarthquakeQuery query)
		{
			var url = getUrlWithParameters(query);
			using (var client = new HttpClient())
			{
				var response = await client.GetAsync(url);

				if (!response.IsSuccessStatusCode)
					throw new Exception("Could not retrieve information from USGS, try again. ");

				var result = await response.Content.ReadAsStringAsync();
				return JsonConvert.DeserializeObject<USGSResponse>(result);
			}
		}

		private string getUrlWithParameters(EarthquakeQuery query)
        {
			var url = $"{_Configuration["USGS:Url"]}?format={_Configuration["USGS:DefaultFormat"]}&limit={_Configuration["USGS:DefaultLimit"]}&orderby={_Configuration["USGS:DefaultOrderBy"]}";

            if (query.Lat != 0 || query.Long != 0) url += "&maxradiuskm=" + _Configuration["USGS:DefaultRadiusKM"];
            if (query.Lat != 0) url += "&latitude=" + query.Lat.ToString().Replace(',', '.');
			if (query.Long != 0) url += "&longitude=" + query.Long.ToString().Replace(',', '.');
			if (query.Start_date != DateTime.MinValue) url += "&starttime=" + query.Start_date;
			if (query.End_date != DateTime.MinValue) url += "&endtime=" + query.End_date;

			return url;
		}
    }
}
