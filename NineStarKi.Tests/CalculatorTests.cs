using NineStarKi.Models;
using System;
using Xunit;

namespace NineStarKi.Tests
{
    public class CalculatorTests
    {
        private Calculator calculator;

        public CalculatorTests(Calculator calc)
        {
            calculator = calc;
        }
        [Fact]
        public void Can_Calculate_Main_Personality()
        {
            // Arrange - set year
            int year = 2000;

            // Act
            char mainPersonality = calculator.MainPersonality(year);

            // Assert
            Assert.Equal('9', mainPersonality);
        }

        [Fact]
        public void Can_Calculate_Personality()
        {
            // Arrange - set date
            DateTime localTime = new DateTime(2000, 01, 01, 00 ,00, 00);
            DateTimeOffset date = new DateTimeOffset(localTime,
                TimeZoneInfo.Local.GetUtcOffset(localTime));

            // Act
            string numbers = calculator.Personality(date);

            // Assert
            Assert.Equal("1.7.8", numbers);
        }
    }
}
