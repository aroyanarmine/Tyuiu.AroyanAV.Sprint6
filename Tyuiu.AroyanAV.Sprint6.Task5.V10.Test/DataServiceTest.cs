using Tyuiu.AroyanAV.Sprint6.Task5.V10.Lib;

namespace Tyuiu.AroyanAV.Sprint6.Task5.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\armine06\документы\новая папка\Tyuiu.AroyanAV.Sprint6\Tyuiu.AroyanAV.Sprint6.Task5.V10\bin\Debug\net8.0-windows\InPutDataFileTask5V10.txt";
            double[] res = ds.LoadFromDataFile(path);
            double[] wait = { -13, -19, -9.82, 13, 11.49, -9.71, 3.36, 10, 14.52, 16, 13.66, 0.48, 4.13, -0.11, 19, -17.36, 11, 11.28, -12, -12.35 };
            CollectionAssert.AreEqual(wait, res);
        }

        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = @"C:\Users\armine06\документы\новая папка\Tyuiu.AroyanAV.Sprint6\Tyuiu.AroyanAV.Sprint6.Task5.V10\bin\Debug\net8.0-windows\InPutDataFileTask5V10.txt"; ;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}
