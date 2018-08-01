using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3107_Console
{
    class Program
    {
        public static int Id { get; set; }
        public static int num2 { get; set; }
        public static int resp { get; set; }
        public static String operação { get; set; }
       

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Console.WriteLine("Digite um nº");
            Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro nº");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a operação");
            operação = Console.ReadLine();

            switch (operação)
            {
                case "+":
                    SomarNumeros(num2, Id);
                    break;
                case "-":
                    DiminuirNumeros(num2, Id);
                    break;
                case "/":
                    DividirNumeros(num2, Id);
                    break;
                case "*":
                    MultiplicarNumeros(num2, Id);
                    break;
            }
            //Console.WriteLine("A soma dos nºs é " + soma);
            //ImprimirNumeroDigitado(Id);
            Console.ReadKey();
        }

        static void ImprimirNumeroDigitado (int num)
        {
             Console.WriteLine("Você digitou:" + num);
        }

        static void SomarNumeros(int num2, int Id)
        {
            resp = num2 + Id;
            Console.WriteLine("A soma dos números é:" + resp);
            
        }

        static void DiminuirNumeros(int num2, int Id)
        {
            resp = Id - num2;
            Console.WriteLine("A subtração dos números é:" + resp);

        }

        static void DividirNumeros(int num2, int Id)
        {
            resp = Id/num2;
            Console.WriteLine("A divisão dos números é:" + resp);

        }

        static void MultiplicarNumeros(int num2, int Id)
        {
            resp = Id * num2;
            Console.WriteLine("A multiplicação dos números é:" + resp);

        }

    }
}
