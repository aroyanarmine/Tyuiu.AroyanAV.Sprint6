using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AroyanAV.Sprint6.Task3.V15.Lib
{
    public class DataService : ISprint6Task3V15
    {
        public int[,] Calculate(int[,] matrix)
        {
            var thirdColumn = new int[matrix.GetLength(0)];
            for (int i = 0; i < matrix.GetLength(0); i++)
                thirdColumn[i] = matrix[i, 2];
            Array.Sort(thirdColumn);
            for (int i = 0; i < matrix.GetLength(0); i++)
                matrix[i, 2] = thirdColumn[i];
            return matrix;
        }
    }
}