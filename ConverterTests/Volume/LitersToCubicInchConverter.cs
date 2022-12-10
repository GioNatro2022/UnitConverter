using UnitConverter.Converters.Volume;

namespace ConverterTests.Volume
{
    [TestClass]
    public class LitersToCubicInchConverterTests
    {

        [TestMethod]
        public void LitersToCubicInch_Should_Throw_ArgumentException()
        {
            var converter = new LitersToCubicInchConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("", ""));
            Assert.AreEqual(res.Message, "inputs cannot be empty!");

        }

        [TestMethod]
        public void LitersToCubicInch_Should_Throw_ArgumentException2()
        {
            var converter = new LitersToCubicInchConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion(null, null));
            Assert.AreEqual(res.Message, "inputs cannot be empty!");

        }

        [TestMethod]
        public void LitersToCubicInch_Should_Throw_ArgumentException3()
        {
            var converter = new LitersToCubicInchConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("test", "test"));
            Assert.AreEqual(res.Message, "invalid input, value and unit should be separated by single space");

        }
        [TestMethod]
        public void LitersToCubicInch_Should_Throw_ArgumentException4()
        {
            var converter = new LitersToCubicInchConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("test, test", "test"));
            Assert.AreEqual(res.Message, "invalid input, value cannot be convreted to decimal");

        }

        [TestMethod]
        public void LitersToCubicInch_Should_Throw_ArgumentException5()
        {
            var converter = new LitersToCubicInchConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("-1, cubicInch", "liter"));
            Assert.AreEqual(res.Message, "invalid input, value cannot be negative");

        }

        [TestMethod]
        public void LitersToCubicInch_Should_Throw_ArgumentException6()
        {
            var converter = new LitersToCubicInchConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("1, test", "l"));
            Assert.IsTrue(res.Message.Contains("invalid input, cannot find synonim for unit"));

        }

        [TestMethod]
        public void LitersToCubicInch_Should_Throw_ArgumentException7()
        {
            var converter = new LitersToCubicInchConverter();
            var res = Assert.ThrowsException<ArgumentException>(() => converter.PerformConversion("1, cubicInch", "test"));
            Assert.AreEqual(res.Message, "Synonim for unit: test not Found");
        }


        [TestMethod]
        public void Shoud_Convert_CubicInch_To_Liter()
        {
            var converter = new LitersToCubicInchConverter();
            var res = converter.PerformConversion("100, cubicinch", "liter");
            Assert.AreEqual(res, (decimal)1.638700);

        }

        [TestMethod]
        public void Shoud_Convert_Liter_To_CubicInch()
        {
            var converter = new LitersToCubicInchConverter();
            var res = converter.PerformConversion("100, liter", "cubicinch");
            Assert.AreEqual(res, (decimal)6102.400);

        }

        [TestMethod]
        public void Shoud_Convert_Mililiter_To_CubicInch()
        {
            var converter = new LitersToCubicInchConverter();
            var res = converter.PerformConversion("100, mililiter", "cubicinch");
            Assert.AreEqual(res, (decimal)6.102400);

        }

        [TestMethod]
        public void Shoud_Convert_CubicInch_To_Mililiter()
        {
            var converter = new LitersToCubicInchConverter();
            var res = converter.PerformConversion("100, cubicinch", "mililiter");
            Assert.AreEqual(res, (decimal)1638.699528);

        }

    }
}
