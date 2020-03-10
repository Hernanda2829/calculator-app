using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.Title = "aplikasi calculator";

            //int a = 10;
            //int b = 6;

            Console.Write("inputkan nilai a = ");
            int a = int.Parse(Console.ReadLine()); //proses casting

            Console.Write("inputkan nilai b = ");
            int b = int.Parse(Console.ReadLine()); //proses casting

            Console.WriteLine(); //tambahkan baris kosong
     
            Console.WriteLine("hasil penambahan " + a + " + " + b + " = " + penambahan(a, b));
            Console.WriteLine("hasil pengurangan {0} - {1} = {2}", a, b, pengurangan(a, b));
            Console.WriteLine("hasil perkalian {0} * {1} = {2}", a, b, perkalian(a, b));
            Console.WriteLine("hasil pembagian {0} / {1} = {2}", a, b, pembagian(a, b));

            Console.WriteLine("\nTekan sembarangan key untuk keluar");
            Console.ReadKey();
        }

        static int penambahan(int a, int b)
        {
            return a + b;
        }
        static int pengurangan(int a, int b)
        {
            return a - b;
        }
        static int perkalian(int a, int b)
        {
            return a * b;
        }

    }
}