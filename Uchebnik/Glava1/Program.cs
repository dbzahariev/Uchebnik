using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Glava1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task10();
        }

        static void Task6()
        {
            Console.WriteLine("Dimitar Zahariev");
        }

        static void Task7()
        {
            Console.WriteLine("1");
            Console.WriteLine("101");
            Console.WriteLine("1001");
        }

        static void Task8()
        {
            Console.WriteLine(System.DateTime.Now);
        }

        static void Task9()
        {
            Console.WriteLine(Math.Sqrt(12345));
        }

        static void Task10()
        {
            for (int i = 2; i <= 102; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("-" + i);
                }
            }
        }
    }
}
