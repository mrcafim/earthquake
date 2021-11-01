using Earthquake.API.Models.Responses.USGS;
using Xunit;

namespace EarthquakeTests.Models.Responses.USGS
{
    public class FeatureGeometryTest
    {
        [Fact]
        public void DefaultConstrutor_WithoutData_ShouldCreateObject()
        {
            // Arrange
            var feature = new FeatureGeometry();

            // Assert
            Assert.NotNull(feature);
        }
    }
}
