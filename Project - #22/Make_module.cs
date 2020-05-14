using System;
using System.Collections.Generic;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            Queue<int> Eu = new Queue<int>();
            Random ran = new Random();
            for (int i = 0; i < 20; i++)                 
                Eu.Enqueue(ran.Next(1, 100));
            Console.OutputEncoding = Encoding.GetEncoding(866);
            Console.WriteLine("Моя очередь:");             
            foreach (int i in Eu)                 
                Console.Write("{0} ", i);
            Console.ReadLine();
        }
    }
}