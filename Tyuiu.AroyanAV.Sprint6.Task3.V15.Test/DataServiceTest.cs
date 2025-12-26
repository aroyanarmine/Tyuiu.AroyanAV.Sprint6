using Tyuiu.AroyanAV.Sprint6.Task3.V15.Lib;

namespace Tyuiu.AroyanAV.Sprint6.Task3.V15.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var initialMatrix = new int[3, 3] { { 0, 1, -2 }, { 1, -5, -12 }, { 8, -2, 1 } };
            var expectedSortedMatrix = new int[3, 3] { { 0, 1, -12 }, { 1, -5, -2 }, { 8, -2, 1 } };
            CollectionAssert.AreEqual(expectedSortedMatrix, new DataService().Calculate(initialMatrix));
        }
    }
}
