using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] stringarray = new string[] { "Moscow", "St.Petersburg", "Voronezsh" };
        }

        // ~5 min
        public static string FirstTask(string[] array)
        {
            return $"{string.Join(", ", array)}.";
        }

        // ~10-15 min
        public static int SecondTask(float number)
        {
            int helper = (int)Math.Round(number);
            double result = helper % 5;
            switch (result)
            {
                case 1:
                    return helper -= 1;
                case 2:
                    return helper -= 2;
                case 3:
                    return helper += 2;
                case 4:
                    return helper += 1;
                default:
                    return helper;
            }
        }

        // ~ 10-15 min
        public static string ThirdTask(int number)
        {
            string helper = number.ToString();
            int a = helper[helper.Length - 1] - '0';
            if (Enumerable.Range(2, 4).Contains(a))
            {
                return $"{number} компьютера";
            }
            else if (a % 10 == 1)
            {
                return $"{number} компьютер";
            }
            else
            {
                return $"{number} компьютеров";
            }
        }

        // ~10-15 min
        public static bool FourthTask(int number)
        {
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static int[] FifthTask(int[] array1, int[] array2)
        {
            int[] newarray1 = array1.GroupBy(x => x).SelectMany(x => x.Skip(1)).ToArray();
            int[] newarray2 = array2.GroupBy(x => x).SelectMany(x => x.Skip(1)).ToArray();

            int[] newarray3 = newarray1.Intersect(newarray2).ToArray();

            //return array1.GroupBy(x => x).SelectMany(x => x.Skip(1)).Intersect(array2.GroupBy(x => x).SelectMany(x => x.Skip(1))).ToArray();

            return newarray3;
        }
    }
}
