using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_teste
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = "Hello World";
            string s2 = "Good Morning";

            Console.WriteLine(s1);
            Console.Write("Escreva seu nome: ");
            string s3 = Console.ReadLine();

            Console.WriteLine("======================================");
            Console.WriteLine($"{s1}! {s2}, {s3}!");

            Console.WriteLine("Tchau!!!");            
            Console.WriteLine("======================================");

            Console.ReadKey();

        }
    }
}
