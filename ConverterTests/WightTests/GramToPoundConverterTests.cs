using UnitConverter.Converters.Weight;

namespace ConverterTests.WightTests
{
    [TestClass]
    public class GramToPoundConverterTests
    {
        [TestMethod]
        public void GramToPound_Should_Throw_ArgumentException()
        {
            var converter = new GramToPoundConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("", ""));
            Assert.AreEqual(res.Message, "inputs cannot be empty!");

        }

        [TestMethod]
        public void GramToPound_Should_Throw_ArgumentException2()
        {
            var converter = new GramToPoundConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion(null, null));
            Assert.AreEqual(res.Message, "inputs cannot be empty!");

        }

        [TestMethod]
        public void GramToPound_Should_Throw_ArgumentException3()
        {
            var converter = new GramToPoundConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("test", "test"));
            Assert.AreEqual(res.Message, "invalid input, value and unit should be separated by single space");

        }
        [TestMethod]
        public void GramToPound_Should_Throw_ArgumentException4()
        {
            var converter = new GramToPoundConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("test, test", "test"));
            Assert.AreEqual(res.Message, "invalid input, value cannot be convreted to decimal");

        }

        [TestMethod]
        public void GramToPound_Should_Throw_ArgumentException5()
        {
            var converter = new GramToPoundConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("-1, gram", "pounds"));
            Assert.AreEqual(res.Message, "invalid input, value cannot be negative");

        }

        [TestMethod]
        public void GramToPound_Should_Throw_ArgumentException6()
        {
            var converter = new GramToPoundConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("1, test", "pound"));
            Assert.IsTrue(res.Message.Contains("invalid input, cannot find synonim for unit"));

        }

        [TestMethod]
        public void GramToPound_Should_Throw_ArgumentException7()
        {
            var converter = new GramToPoundConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("1, gram", "test"));
            Assert.AreEqual(res.Message, "Synonim for unit: test not Found");
        }


        [TestMethod]
        public void Shoud_Convert_gram_To_Pound()
        {
            var converter = new GramToPoundConverter();
            var res = converter.PerformConversion("100, gram", "pounds");
            Assert.AreEqual(res, (decimal)0.220459);

        }

        [TestMethod]
        public void Shoud_Convert_Pound_To_Gram()
        {
            var converter = new GramToPoundConverter();
            var res = converter.PerformConversion("100, pound", "grams");
            Assert.AreEqual(res, (decimal)45360);

        }

        [TestMethod]
        public void Shoud_Convert_kilogram_To_Pound()
        {
            var converter = new GramToPoundConverter();
            var res = converter.PerformConversion("100, kilogram", "pounds");
            Assert.AreEqual(res, (decimal)220.458554);

        }

        [TestMethod]
        public void Shoud_Convert_pound_To_Kilogram()
        {
            var converter = new GramToPoundConverter();
            var res = converter.PerformConversion("100, pound", "kilograms");
            Assert.AreEqual(res, (decimal)45.36);

        }




    }
}
