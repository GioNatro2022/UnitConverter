using UnitConverter.Converters.Distance;

namespace ConverterTests.DistanceTests
{
    [TestClass]
    public class DistanceConverterTests
    {
        [TestMethod]
        public void MeterToFeet_Should_Throw_ArgumentException()
        {
            var converter = new MeterToFeetConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("", ""));
            Assert.AreEqual(res.Message, "inputs cannot be empty!");

        }

        [TestMethod]
        public void MeterToFeet_Should_Throw_ArgumentException2()
        {
            var converter = new MeterToFeetConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion(null, null));
            Assert.AreEqual(res.Message, "inputs cannot be empty!");

        }

        [TestMethod]
        public void MeterToFeet_Should_Throw_ArgumentException3()
        {
            var converter = new MeterToFeetConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("test", "test"));
            Assert.AreEqual(res.Message, "invalid input, value and unit should be separated by single space");

        }
        [TestMethod]
        public void MeterToFeet_Should_Throw_ArgumentException4()
        {
            var converter = new MeterToFeetConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("test, test", "test"));
            Assert.AreEqual(res.Message, "invalid input, value cannot be convreted to decimal");

        }

        [TestMethod]
        public void MeterToFeet_Should_Throw_ArgumentException5()
        {
            var converter = new MeterToFeetConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("-1, m", "ft"));
            Assert.AreEqual(res.Message, "invalid input, value cannot be negative");

        }

        [TestMethod]
        public void MeterToFeet_Should_Throw_ArgumentException6()
        {
            var converter = new MeterToFeetConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("1, test", "ft"));
            Assert.IsTrue(res.Message.Contains("invalid input, cannot find synonim for unit"));

        }

        [TestMethod]
        public void MeterToFeet_Should_Throw_ArgumentException7()
        {
            var converter = new MeterToFeetConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("1, meters", "test"));
            Assert.AreEqual(res.Message, "Synonim for unit: test not Found");

        }

        [TestMethod]
        public void Shoud_Convert_Feet_To_Meter()
        {
            var converter = new MeterToFeetConverter();
            var res = converter.PerformConversion("100, ft", "m");
            Assert.AreEqual(res, (decimal)30.478513);

        }

        [TestMethod]
        public void Shoud_Convert_Meter_To_Feet()
        {
            var converter = new MeterToFeetConverter();
            var res = converter.PerformConversion("100, m", "ft");
            Assert.AreEqual(res, (decimal)328.100);

        }

        [TestMethod]
        public void Shoud_Convert_KiloMeter_To_Meter()
        {
            var converter = new MeterToFeetConverter();
            var res = converter.PerformConversion("10, kilometers", "m");
            Assert.AreEqual(res, (decimal)10000);

        }

        [TestMethod]
        public void Shoud_Convert_Meter_To_KiloMeter()
        {
            var converter = new MeterToFeetConverter();
            var res = converter.PerformConversion("10, m", "kilometers");
            Assert.AreEqual(res, (decimal)0.01);

        }
        [TestMethod]
        public void Shoud_Convert_Kilometer_To_Feet()
        {
            var converter = new MeterToFeetConverter();
            var res = converter.PerformConversion("10, kilometers", "ft");
            Assert.AreEqual(res, (decimal)32810);

        }
        [TestMethod]
        public void Shoud_Convert_Feet_To_Kilometer()
        {
            var converter = new MeterToFeetConverter();
            var res = converter.PerformConversion("10, ft", "kilometers");
            Assert.AreEqual(res, (decimal)0.003048);
        }
    }
}