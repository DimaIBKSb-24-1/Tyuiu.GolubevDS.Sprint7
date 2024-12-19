
namespace Tyuiu.GolubevDS.Sprint7.V7.Lib
{
    public class DataService
    {
        public string[,] GetBase(string path)
        {
            // Проверьте, существует ли файл  
            if (!File.Exists(path))
            {
                throw new FileNotFoundException($"Файл не найден: {path}");
            }

            // Считываем всё содержимое файла  
            string file = File.ReadAllText(path);

            // Разбиваем содержимое на строки, учитывая разные типы концов строк  
            string[] lines = file.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.RemoveEmptyEntries);

            int rows = lines.Length;

            // Проверяем, что файл не пустой  
            if (rows == 0)
            {
                throw new InvalidOperationException("Файл пуст.");
            }

            // Разбиваем первую строку для определения количества столбцов  
            int columns = lines[0].Split(';').Length;

            // Создаем двумерный массив  
            string[,] array = new string[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_mas = lines[i].Split(';');

                // Проверяем, что количество столбцов совпадает  
                if (line_mas.Length != columns)
                {
                    throw new InvalidOperationException($"Строка {i + 1} имеет некорректное количество столбцов.");
                }

                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = line_mas[j];
                }
            }

            return array;
        }
    }
}
