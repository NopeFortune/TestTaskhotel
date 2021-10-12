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

        // ~10-15 min
        public static bool ThirdTask(int number)
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
    }
}
