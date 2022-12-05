using UnitConverter.Converters.Distance;
using UnitConverter.Converters.Weight;

namespace ConverterTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            var converter = new GramToPoundConverter();
            Assert.AreEqual(converter.PerformConversion("10 kg", "grams"),(decimal)10000);
           
        }

        [TestMethod]
        public void TestMethod2()
        {

            var converter = new MeterToFeetConverter();
            Assert.AreEqual(converter.PerformConversion("10 ft", "meter"), (decimal)32.8084);

        }
    }
}