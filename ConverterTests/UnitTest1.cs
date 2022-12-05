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
            Assert.AreEqual(converter.PerformConversion("1 gigapound", "gram"),(decimal)0.220459);
           
        }
    }
}