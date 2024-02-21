using ClassLibrary;

namespace Calculator
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodAdd()
        {
            Calculate obj = new Calculate();
            int result = obj.Add(10, 10);

            Assert.AreEqual(20, result);
        }

        [TestMethod]
        public void TestMethodSubstr()
        {
            Calculate obj = new Calculate();
            int result = obj.Substract(10, 10);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMethodMultiply()
        {
            Calculate obj = new Calculate();
            int result = obj.Multiply(10, 10);

            Assert.AreEqual(100, result);
        }
    }
}