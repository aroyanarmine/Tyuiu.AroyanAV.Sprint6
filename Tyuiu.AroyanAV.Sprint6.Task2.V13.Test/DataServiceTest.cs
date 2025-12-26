using Tyuiu.AroyanAV.Sprint6.Task2.V13.Lib;

namespace Tyuiu.AroyanAV.Sprint6.Task2.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            var res = ds.GetMassFunction(-5, 5);

            double[] wait = ds.GetMassFunction(-5, 5);

            CollectionAssert.AreEqual(res, wait);
        }
    }
}
