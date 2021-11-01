﻿using Earthquake.API.Models.Responses.USGS;
using Xunit;

namespace EarthquakeTests.Models.Responses.USGS
{
    public class USGSResponseTest
    {
        [Fact]
        public void DefaultConstrutor_WithoutData_ShouldCreateObject()
        {
            // Arrange
            var response = new USGSResponse();

            // Assert
            Assert.NotNull(response);
        }
    }
}