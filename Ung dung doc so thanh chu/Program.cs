using System;

namespace baitap
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort donVi, hangChuc, hangTram;

            Console.WriteLine("Nhap so nguyen khong am (toi da 3 chu so):");
            donVi = ushort.Parse(Console.ReadLine());
            Console.WriteLine("So can doc la:");
            switch (donVi)
            {
                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                case 3:
                    Console.WriteLine("three");
                    break;
                case 4:
                    Console.WriteLine("four");
                    break;
                case 5:
                    Console.WriteLine("five");
                    break;
                case 6:
                    Console.WriteLine("six");
                    break;
                case 7:
                    Console.WriteLine("seven");
                    break;
                case 8:
                    Console.WriteLine("eight");
                    break;
                case 9:
                    Console.WriteLine("nine");
                    break;
                default: Console.WriteLine("Out of ability");
                    break;
            }
        }
    }
}