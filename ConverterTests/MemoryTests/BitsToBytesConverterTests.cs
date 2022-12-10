
using UnitConverter.Converters.Memory;

namespace ConverterTests.MemoryTests
{
    [TestClass]
    public class BitsToBytesConverterTests
    {
        [TestMethod]
        public void BitsToBytes_Should_Throw_ArgumentException()
        {
            var converter = new BitsToBytesConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("", ""));
            Assert.AreEqual(res.Message, "inputs cannot be empty!");

        }

        [TestMethod]
        public void BitsToBytes_Should_Throw_ArgumentException2()
        {
            var converter = new BitsToBytesConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion(null, null));
            Assert.AreEqual(res.Message, "inputs cannot be empty!");

        }

        [TestMethod]
        public void BitsToBytes_Should_Throw_ArgumentException3()
        {
            var converter = new BitsToBytesConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("test", "test"));
            Assert.AreEqual(res.Message, "invalid input, value and unit should be separated by single space");

        }
        [TestMethod]
        public void BitsToBytes_Should_Throw_ArgumentException4()
        {
            var converter = new BitsToBytesConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("test, test", "test"));
            Assert.AreEqual(res.Message, "invalid input, value cannot be convreted to decimal");

        }

        [TestMethod]
        public void BitsToBytes_Should_Throw_ArgumentException5()
        {
            var converter = new BitsToBytesConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("-1, Bit", "Byte"));
            Assert.AreEqual(res.Message, "invalid input, value cannot be negative");

        }

        [TestMethod]
        public void BitsToBytes_Should_Throw_ArgumentException6()
        {
            var converter = new BitsToBytesConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("1, test", "Byte"));
            Assert.IsTrue(res.Message.Contains("invalid input, cannot find synonim for unit"));

        }

        [TestMethod]
        public void BitsToBytes_Should_Throw_ArgumentException7()
        {
            var converter = new BitsToBytesConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("1, bits", "test"));
            Assert.AreEqual(res.Message, "Synonim for unit: test not Found");

        }

        [TestMethod]
        public void Shoud_Convert_Bit_To_Byte()
        {
            var converter = new BitsToBytesConverter();
            var res = converter.PerformConversion("100, bit", "byte");
            Assert.AreEqual(res, (decimal)12.5);

        }

        [TestMethod]
        public void Shoud_Convert_Byte_To_Bit()
        {
            var converter = new BitsToBytesConverter();
            var res = converter.PerformConversion("100, bytes", "bit");
            Assert.AreEqual(res, (decimal)800);

        }

        [TestMethod]
        public void Shoud_Convert_MegaByte_To_Bit()
        {
            var converter = new BitsToBytesConverter();
            var res = converter.PerformConversion("100, Megabyte", "bits");
            Assert.AreEqual(res, (decimal)800000000);

        }

        [TestMethod]
        public void Shoud_Convert_Bit_To_Terabyte()
        {
            var converter = new BitsToBytesConverter();
            var res = converter.PerformConversion("10000000, bit", "terabytes");
            Assert.AreEqual(res, (decimal)0.000001);

        }

    }
}
