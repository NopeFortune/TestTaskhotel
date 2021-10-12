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
            string[] stringy = new string[] { "Moscow", "St.Petersburg", "Voronezsh" };
            Console.WriteLine(FirstTask(stringy));
        }

        public static string FirstTask(string[] array)
        {
            return $"{string.Join(", ", array)}.";
        }
    }
}
