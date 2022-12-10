using UnitConverter.Converters.Temperature;

namespace ConverterTests.TemperatureTests
{
    [TestClass]
    public class CelsiusToFarenheitConverterTests
    {

        [TestMethod]
        public void CelsiusToFarenheit_Should_Throw_ArgumentException()
        {
            var converter = new CelsiusToFarenheitConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("", ""));
            Assert.AreEqual(res.Message, "inputs cannot be empty!");

        }

        [TestMethod]
        public void CelsiusToFarenheit_Should_Throw_ArgumentException2()
        {
            var converter = new CelsiusToFarenheitConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion(null, null));
            Assert.AreEqual(res.Message, "inputs cannot be empty!");

        }

        [TestMethod]
        public void CelsiusToFarenheit_Should_Throw_ArgumentException3()
        {
            var converter = new CelsiusToFarenheitConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("test", "test"));
            Assert.AreEqual(res.Message, "invalid input, value and unit should be separated by single space");

        }
        [TestMethod]
        public void CelsiusToFarenheit_Should_Throw_ArgumentException4()
        {
            var converter = new CelsiusToFarenheitConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("test, test", "test"));
            Assert.AreEqual(res.Message, "invalid input, value cannot be convreted to decimal");

        }

        [TestMethod]
        public void CelsiusToFarenheit_Should_Throw_ArgumentException5()
        {
            var converter = new CelsiusToFarenheitConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("-1, c", "f"));
            Assert.AreEqual(res.Message, "invalid input, value cannot be negative");

        }

        [TestMethod]
        public void CelsiusToFarenheit_Should_Throw_ArgumentException6()
        {
            var converter = new CelsiusToFarenheitConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("1, test", "f"));
            Assert.IsTrue(res.Message.Contains("invalid input, cannot find synonim for unit"));

        }

        [TestMethod]
        public void CelsiusToFarenheit_Should_Throw_ArgumentException7()
        {
            var converter = new CelsiusToFarenheitConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("1, celsius", "test"));
            Assert.AreEqual(res.Message, "Synonim for unit: test not Found");

        }


        [TestMethod]
        public void Shoud_Convert_Celsius_To_Farenheit()
        {
            var converter = new CelsiusToFarenheitConverter();
            var res = converter.PerformConversion("10, celsius", "f");
            Assert.AreEqual(res, (decimal)50);

        }

        [TestMethod]
        public void Shoud_Convert_Farenheit_To_Celsius()
        {
            var converter = new CelsiusToFarenheitConverter();
            var res = converter.PerformConversion("100, f", "celsius");
            Assert.AreEqual(res, (decimal)37.777778);

        }

      


    }
}
