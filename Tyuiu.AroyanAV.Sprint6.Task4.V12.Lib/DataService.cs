using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.AroyanAV.Sprint6.Task4.V12.Lib
{
    public class DataService : ISprint6Task4V12
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueArray;
            int len = (stopValue - startValue) + 1;
            valueArray = new double[len];

            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                if ((0.5 + 3 * x) == 0)
                {
                    y = 0;
                }
                else
                {
                    y = Math.Sin(x) + 2 / (0.5 + 3 * x) - 2 * Math.Cos(x) * 2 * x;
                }

                valueArray[count] = Math.Round(y, 2);
                count++;
            }

            return valueArray;
        }
    }
}