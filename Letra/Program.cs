using System;

namespace Letra
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("*******\n");
            Console.WriteLine("*     *");
            Console.WriteLine("*     *");
            Console.WriteLine("*     *");
            Console.Write("*******\n");
            Console.WriteLine("*     *");
            Console.WriteLine("*     *");
            Console.WriteLine("*     *");*/
            for(int i=1; i<8; i++)
            {
                string c1 = "*\n";
                Console.Write(c1);
                for(int j=1; j<8; j++)
                {
                    string c2 = "*";
                    Console.Write("*");
                }
            }
        }
    }
}
