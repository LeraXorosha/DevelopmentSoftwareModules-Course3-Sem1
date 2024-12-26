using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraversingTheArray
{
    /// <summary>
    /// класс содержащий набор методов расширения для масива вещественных чисел 
    /// </summary>
    public static class ExtensionDoubleArray
    {
        public static double FindMinimum(this double[] mas)
        {
            if (mas.Length <= 0) throw new Exception("массив пуст");

            double min = mas[0];
            for (int k = 0; k < mas.Length; k++)
            {
                if (mas[k] < min) min = mas[k];
            }

            return min;
        }


        public static double FindMaximum(this double[] mas)
        {
            if (mas.Length <= 0) throw new Exception("массив пуст");
            double max = mas[0];
            for (int k = 0; k < mas.Length; k++)
            {
                if (mas[k] > max) max = mas[k];
            }

            return max;
        }


        public static double FindAverage(this double[] mas)
        {
            if (mas.Length <= 0) throw new Exception("массив пуст");
            double sum = 0;
            for (int k = 0; k < mas.Length; k++)
            {
                double a = mas[k] / mas.Length;
                sum += a;

            }
            return sum;
        }

        public static double FindMedian(this double[] mas)
        {
            if (mas.Length <= 0) throw new Exception("массив пуст");
            Array.Sort(mas);
            double median = 0;
            int check = mas.Length;
            if (check % 2 != 0)
            {
                median = mas[check / 2];
            }
            else
            {
                median = (mas[check / 2 - 1] + mas[check / 2]) / 2;
            }
            return median;
        }

        public static double FindGeometricAverage(this double[] mas)
        {
            if (mas.Length <= 0) throw new Exception("массив пуст");
            double proizv = 1;
            for (int k = 0; k < mas.Length; k++)
            {
                proizv *= mas[k];
                if (mas[k] <= 0)
                    throw new Exception("было встречено отрицательное число");
                        
            }
            return Math.Pow(proizv,mas.Length);
        }

        
    }
}
