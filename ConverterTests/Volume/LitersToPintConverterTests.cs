using UnitConverter.Converters.Volume;

namespace ConverterTests.Volume
{
    [TestClass]

    public class LitersToPintConverterTests
    {
        [TestMethod]
        public void LitersToPint_Should_Throw_ArgumentException()
        {
            var converter = new LitersToPintConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("", ""));
            Assert.AreEqual(res.Message, "inputs cannot be empty!");

        }

        [TestMethod]
        public void LitersToPint_Should_Throw_ArgumentException2()
        {
            var converter = new LitersToPintConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion(null, null));
            Assert.AreEqual(res.Message, "inputs cannot be empty!");

        }

        [TestMethod]
        public void LitersToPint_Should_Throw_ArgumentException3()
        {
            var converter = new LitersToPintConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("test", "test"));
            Assert.AreEqual(res.Message, "invalid input, value and unit should be separated by single space");

        }
        [TestMethod]
        public void LitersToPint_Should_Throw_ArgumentException4()
        {
            var converter = new LitersToPintConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("test, test", "test"));
            Assert.AreEqual(res.Message, "invalid input, value cannot be convreted to decimal");

        }

        [TestMethod]
        public void LitersToPint_Should_Throw_ArgumentException5()
        {
            var converter = new LitersToPintConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("-1, l", "pint"));
            Assert.AreEqual(res.Message, "invalid input, value cannot be negative");

        }

        [TestMethod]
        public void LitersToPint_Should_Throw_ArgumentException6()
        {
            var converter = new LitersToPintConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("1, test", "l"));
            Assert.IsTrue(res.Message.Contains("invalid input, cannot find synonim for unit"));

        }

        [TestMethod]
        public void LitersToPint_Should_Throw_ArgumentException7()
        {
            var converter = new LitersToPintConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("1, pint", "test"));
            Assert.AreEqual(res.Message, "Synonim for unit: test not Found");
        }





        [TestMethod]
        public void Shoud_Convert_Pint_To_Liter()
        {
            var converter = new LitersToPintConverter();
            var res = converter.PerformConversion("100, pint", "liter");
            Assert.AreEqual(res, (decimal)47.326077);

        }

        [TestMethod]
        public void Shoud_Convert_Liter_To_Pint()
        {
            var converter = new LitersToPintConverter();
            var res = converter.PerformConversion("100, liter", "pint");
            Assert.AreEqual(res, (decimal)211.300);

        }

        [TestMethod]
        public void Shoud_Convert_Mililiter_To_Pint()
        {
            var converter = new LitersToPintConverter();
            var res = converter.PerformConversion("100, mililiter", "pint");
            Assert.AreEqual(res, (decimal)0.211300);

        }

        [TestMethod]
        public void Shoud_Convert_Pint_To_Mililiter()
        {
            var converter = new LitersToPintConverter();
            var res = converter.PerformConversion("100, pint", "mililiter");
            Assert.AreEqual(res, (decimal)47326.076668);

        }
    }
}
