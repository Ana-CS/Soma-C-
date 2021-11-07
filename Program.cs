using System;

namespace teste1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

                      
            Console.WriteLine("Digite o primeiro numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("A resposta é: " + (num1+num2));

        }
    }
}
