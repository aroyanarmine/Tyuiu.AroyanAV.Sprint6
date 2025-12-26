using Tyuiu.AroyanAV.Sprint6.Task4.V12.Lib;

namespace Tyuiu.AroyanAV.Sprint6.Task4.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double[] res = ds.GetMassFunction(-5, 5);

            double[] wait = { 6.49, -9.88, -12.26, -4.60, 0.52, 4, -0.75, 4.55, 12.23, 9.86, -6.50 };
            CollectionAssert.AreEqual(wait, res);
        }
    }
}