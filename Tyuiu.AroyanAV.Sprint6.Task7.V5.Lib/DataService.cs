using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AroyanAV.Sprint6.Task7.V5.Lib
{
    public class DataService : ISprint6Task7V5
    {
        public int[,] GetMatrix(string path)
        {
            string[] strings = File.ReadAllLines(path);


            int rows = strings.Length;
            int cols = strings[0].Split(';').Length;

            int[,] matrix = new int[rows, cols];

            for (int r = 0; r < rows; r++)
            {
                string[] values = strings[r].Split(';');

                for (int c = 0; c < cols; c++)
                {
                    int value = int.Parse(values[c]);


                    if (c == cols - 1 && value < 2)
                    {
                        matrix[r, c] = 2;
                    }
                    else
                    {
                        matrix[r, c] = value;
                    }
                }
            }

            return matrix;
        }

        public int[,] LoadMatrix(string loadedFilePath, out int rows, out int cols)
        {
            throw new NotImplementedException();
        }

        public int[,] ProcessMatrix(int[,] inputMatrix)
        {
            throw new NotImplementedException();
        }

        public void SaveMatrixToFile(int[,] resultMatrix, string fileName)
        {
            throw new NotImplementedException();
        }
    }
}