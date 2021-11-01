using Earthquake.API.Models.Responses.USGS;
using Xunit;

namespace EarthquakeTests.Models.Responses.USGS
{
    public class MetadataTest
    {
        [Fact]
        public void DefaultConstrutor_WithoutData_ShouldCreateObject()
        {
            // Arrange
            var metadata = new Metadata();

            // Assert
            Assert.NotNull(metadata);
        }
    }
}