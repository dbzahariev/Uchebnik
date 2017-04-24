using System;

namespace Glava2
{
    class Program
    {
        static void Main(string[] args)
        {
            Task8();
        }

        static void Task1()
        {
            bool isMale = true;
            Console.WriteLine(isMale);
        }

        static void Task2()
        {
            string A = "Hello";
            string B = "World";

            object AB = A + " " + B;
            Console.WriteLine(AB);
        }

        static void Task3()
        {
            string A = "Hello";
            string B = "World";

            object ABo = A + " " + B;

            string ABs = (string)ABo;
            Console.WriteLine(ABs);
        }

        static void Task4()
        {
            string Q = "The \"use\" of quotations causes difficulties.";
            string NQ = "The use of quotations causes difficulties.";

            Console.WriteLine(Q);
            Console.WriteLine(NQ);
        }

        static void Task5()
        {
            Console.WriteLine("   o       o   ");
            Console.WriteLine("  o  o   o  o      ");
            Console.WriteLine("  o    o    o       ");
            Console.WriteLine("   o       o         ");
            Console.WriteLine("     o    o       ");
            Console.WriteLine("       o         ");
        }

        static void Task6()
        {
            Console.WriteLine("    ©    ");
            Console.WriteLine("   © ©   ");
            Console.WriteLine("  ©   ©  ");
            Console.WriteLine(" ©     © ");
            Console.WriteLine("©©©©©©©©©");
        }

        static void Task7() {
            string PIme = "";
            string FIme = "";
            int Godini = 0;
            bool isMale = false;
            int Nomer = 27560000;
        }

        static void Task8() {
            int A = 5;
            int B = 10;
            int Change = 0;

            A = A + B;
            B = A - B;
            A = A - B;
        }
    }
}
