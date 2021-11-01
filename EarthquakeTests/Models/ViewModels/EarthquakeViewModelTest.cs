using Earthquake.API.DTO;
using Earthquake.API.Models.Responses.USGS;
using Earthquake.API.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace EarthquakeTests.Models.ViewModels
{
    public class EarthquakeViewModelTest
    {
        [Fact]
        public void DefaultConstrutor_WithoutData_ShouldCreateObject()
        {
            // Arrange
            var viewmodel = new EarthquakeViewModel();

            // Assert
            Assert.NotNull(viewmodel);
        }
    }
}
