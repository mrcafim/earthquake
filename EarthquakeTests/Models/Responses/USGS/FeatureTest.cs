using Earthquake.API.Models.Responses.USGS;
using Xunit;

namespace EarthquakeTests.Models.Responses.USGS
{
    public class FeatureTest
    {
        [Fact]
        public void DefaultConstrutor_WithoutData_ShouldCreateObject()
        {
            // Arrange
            var feature = new Feature();

            // Assert
            Assert.NotNull(feature);
        }
    }
}
