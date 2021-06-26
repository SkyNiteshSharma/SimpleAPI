using System;
using Xunit;
using SimpleAPI.Controllers;

namespace SimpleAPI.Tests
{
    public class UnitTest1
    {
        // Arrange
        WeatherForecastController wController = new WeatherForecastController();
        [Fact]
        public void Test1()
        {
            // ACT
          var result =  wController.FetchData(1);
          // Assert
          Assert.Equal("Nitesh Sharma", result);

        }
    }
}
