using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitConverter.Converters.Distance;

namespace ConverterTests.DistanceTests
{
    [TestClass]

    public class MeterToInchTests
    {
        [TestMethod]
        public void MeterToInch_Should_Throw_ArgumentException()
        {
            var converter = new MeterToInchConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("", ""));
            Assert.AreEqual(res.Message, "inputs cannot be empty!");

        }

        [TestMethod]
        public void MeterToInch_Should_Throw_ArgumentException2()
        {
            var converter = new MeterToInchConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion(null, null));
            Assert.AreEqual(res.Message, "inputs cannot be empty!");

        }

        [TestMethod]
        public void MeterToInch_Should_Throw_ArgumentException3()
        {
            var converter = new MeterToInchConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("test", "test"));
            Assert.AreEqual(res.Message, "invalid input, value and unit should be separated by single space");

        }
        [TestMethod]
        public void MeterToInch_Should_Throw_ArgumentException4()
        {
            var converter = new MeterToInchConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("test, test", "test"));
            Assert.AreEqual(res.Message, "invalid input, value cannot be convreted to decimal");

        }

        [TestMethod]
        public void MeterToInch_Should_Throw_ArgumentException5()
        {
            var converter = new MeterToInchConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("-1, m", "ft"));
            Assert.AreEqual(res.Message, "invalid input, value cannot be negative");

        }

        [TestMethod]
        public void MeterToInch_Should_Throw_ArgumentException6()
        {
            var converter = new MeterToInchConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("1, test", "ft"));
            Assert.IsTrue(res.Message.Contains("invalid input, cannot find synonim for unit"));

        }

        [TestMethod]
        public void MeterToInch_Should_Throw_ArgumentException7()
        {
            var converter = new MeterToInchConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("1, meters", "test"));
            Assert.AreEqual(res.Message, "Synonim for unit: test not Found");

        }
        /////
        ///
        [TestMethod]
        public void Shoud_Convert_Inch_To_Meter()
        {
            var converter = new MeterToInchConverter();
            var res = converter.PerformConversion("100, inch", "m");
            Assert.AreEqual(res, (decimal)2.540005);

        }

        [TestMethod]
        public void Shoud_Convert_Meter_To_Inch()
        {
            var converter = new MeterToInchConverter();
            var res = converter.PerformConversion("100, m", "inch");
            Assert.AreEqual(res, (decimal)3937);

        }

        [TestMethod]
        public void Shoud_Convert_KiloMeter_To_inch()
        {
            var converter = new MeterToInchConverter();
            var res = converter.PerformConversion("10, kilometers", "inch");
            Assert.AreEqual(res, (decimal)393700);

        }

        [TestMethod]
        public void Shoud_Convert_Inch_To_KiloMeter()
        {
            var converter = new MeterToInchConverter();
            var res = converter.PerformConversion("10, inch", "kilometer");
            Assert.AreEqual(res, (decimal)0.000254);

        }
              
    }
}
