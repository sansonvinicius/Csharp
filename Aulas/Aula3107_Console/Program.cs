using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3107_Console
{
    class Program
    {
        private static int id;
      

        public static int Id { get => id; set => id = value; }
       

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Console.WriteLine("Digite um nº");
            Id = int.Parse(Console.ReadLine());

            Console.WriteLine("Você digitou:" + Id);
            Console.ReadKey();
        }
    }
}
