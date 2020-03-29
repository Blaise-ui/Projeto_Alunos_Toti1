using System;

namespace Projeto_Alunos_Toti1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = 0;
            int numero2 = 0;
            string operacao = "";

            Console.WriteLine("Por favor digite o primeiro número!");
            numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Por favor digite o segundo número!");
            numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEscolha o uma operação! \n\n" +
             "a ou + : adiçao \r\n" +
            "b ou - : subtracao\r\n" +
            "c ou * : multiplicação\r\n" +
            "d ou / : divisão\n");

            operacao = Console.ReadLine();
        }
    }
}
