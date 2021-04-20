using System;
//using System.Diagnostics;
using Xunit;
using SimpleAPI.Controllers;
using Microsoft.Extensions.Logging;

namespace SimpleAPI.Test
{
    public class UnitTest1
    {
        private static readonly ILogger<WeatherForecastController> logger;

        WeatherForecastController wcontroller = new WeatherForecastController(logger);
        [Fact]
        public void MyTest()
        {
            var returnValue = wcontroller.getString();
            Assert.Equal("Damir", returnValue);
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
