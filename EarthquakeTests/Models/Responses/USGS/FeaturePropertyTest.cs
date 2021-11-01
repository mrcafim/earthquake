using Earthquake.API.Models.Responses.USGS;
using Xunit;

namespace EarthquakeTests.Models.Responses.USGS
{
    public class FeaturePropertyTest
    {
        [Fact]
        public void DefaultConstrutor_WithoutData_ShouldCreateObject()
        {
            // Arrange
            var feature = new FeatureProperty();

            // Assert
            Assert.NotNull(feature);
        }
    }
}
