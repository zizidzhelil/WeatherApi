using Core.Models;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Tests.Models.CityTests
{
    [TestFixture]
    public class CountryPropertyTests
    {
        [Test]
        public void GetAndSetCountry()
        {
            string expected = "England";

            City city = new City();
            city.Country = expected;

            string actual = city.Country;

            Assert.AreEqual(actual, expected);
        }
    }
}
