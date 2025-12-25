using System;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AroyanAV.Sprint6.Task0.V19.Lib
{
    public class DataService : ISprint6Task0V19
    {
        public double Calculate(int x)
        {
            {
                double x3 = Math.Pow(x, 3);
                double x2 = x * x;
                return -0.25 * (x3 - 3 * x2 + 4);
            }
        }
    }
}