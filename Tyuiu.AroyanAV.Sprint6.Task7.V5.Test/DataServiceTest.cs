namespace Tyuiu.AroyanAV.Sprint6.Task7.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\пользователи\armine06\документы\новая папка\Tyuiu.AroyanAV.Sprint6.Task7.V5\OutPutFileTask7.csv";
            FileInfo fileInfo = new FileInfo(path);
            bool res = fileInfo.Exists;
            bool wait = false;
            Assert.AreEqual(wait, res);

        }
    }
}
