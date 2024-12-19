namespace Tyuiu.GolubevDS.Sprint7.V7.Test;
using Tyuiu.GolubevDS.Sprint7.V7.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidGetBase()
    {
        DataService ds = new DataService();
        string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\TEST.csv";

        // Создание файла TEST.csv с данными для теста  
        using (var writer = new StreamWriter(pathSaveFile))
        {
            writer.WriteLine("1;2");
            writer.WriteLine("3;4");
            writer.WriteLine("5;6");
        }

        // Вызовите метод для получения данных  
        string[,] res = ds.GetBase(pathSaveFile);
        string[,] wait = { { "1", "2" }, { "3", "4" }, { "5", "6" } };

        // Сравните результаты  
        CollectionAssert.AreEqual(wait, res);
    }
}