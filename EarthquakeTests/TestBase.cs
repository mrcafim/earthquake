using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Text;
using Moq.AutoMock;

namespace EarthquakeTests
{
    public class TestBase
    {
        public readonly AutoMocker AutoMocker = new AutoMocker();

        public IConfiguration GetConfiguration()
        {
            return new ConfigurationBuilder()
                .AddJsonFile("appsettings.test.json")
                .Build();
        }
    }
}
