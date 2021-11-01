using Earthquake.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Moq;
using Earthquake.API.DTO;

namespace EarthquakeTests.Controllers
{
    public class EarthquakeControllerTest : TestBase
    {
        [Fact]
        public void Get_ShouldReturnBadRequest()
        {
            var earthquakeController = AutoMocker.CreateInstance<EarthquakeController>();

            // Act
            var result =  earthquakeController.Get(GenerateQuery(0, -121.89, new DateTime(), new DateTime()));

            // Assert
            Assert.IsType<BadRequestObjectResult>(result.Result);
        }

        [Fact]
        public void Get_ShouldReturnNotFound()
        {
            var earthquakeController = AutoMocker.CreateInstance<EarthquakeController>();

            // Act
            var result = earthquakeController.Get(GenerateQuery(38.5666, -121.89, new DateTime(1500, 01, 01), new DateTime(1500, 12, 01)));

            // Assert
            Assert.IsType<NotFoundResult>(result.Result);
        }

        private EarthquakeQuery GenerateQuery(double latitude, double longitude, DateTime start, DateTime end)
        {
            return new EarthquakeQuery()
            {
                Lat = latitude,
                Long = longitude,
                Start_date = start,
                End_date = end,
            };
        }
    }
}
