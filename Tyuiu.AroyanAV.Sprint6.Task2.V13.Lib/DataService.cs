using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AroyanAV.Sprint6.Task2.V13.Lib
{
    public class DataService : ISprint6Task2V13
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int arrLen = stopValue - startValue + 1, curValue = startValue;

            double[] res = new double[arrLen];

            for (int i = 0; i < arrLen; i++)
            {
                res[i] = Math.Sin(curValue);
                res[i] += 2 * curValue / 3;
                res[i] -= Math.Cos(curValue) * 4 * curValue;
                res[i] = Math.Round(res[i], 2);

                curValue++;
            }

            return res;
        }
    }
}