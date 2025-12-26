using Tyuiu.AroyanAV.Sprint6.Task6.V29.Lib;

namespace Tyuiu.AroyanAV.Sprint6.Task6.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // arrange
            string path = @"C:\Users\armine06\документы\новая папка\Tyuiu.AroyanAV.Sprint6\Tyuiu.AroyanAV.Sprint6.Task5.V10\bin\Debug\net8.0-windows\InPutDataFileTask5V10.txt";
            DataService ds = new DataService();

            // act
            string result = ds.CollectTextFromFile(path);

            // assert
            string expected = "gMxrJi rvzAEwiXzIsLRa xakZKciG";
            Assert.AreEqual(expected, result);
        }
    }
}

