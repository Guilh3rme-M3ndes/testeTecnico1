using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacciEstagio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> fibonacci = new List <int> ();
            int a = 0;
            int b = 1;
            int c = 0;
            int numero;
            Console.WriteLine("Informe o número a ser checado");
            bool ehNumero = int.TryParse(Console.ReadLine(), out int resultado);
            numero = resultado;

            while (!ehNumero)
            {

                if (ehNumero)
                {
                    numero = resultado;
                }
                else
                {
                    Console.WriteLine("Deve ser um inteiro válido!");
                    ehNumero = int.TryParse(Console.ReadLine(), out int resultadoDnv);
                    numero = resultadoDnv;

                }
            }
            

            for (int ultimo = 0; ultimo <= numero; ultimo = a) 
            {
                c = a + b;
                a = b;
                b = c;
                
                fibonacci.Add(c);
                
            }
            if (fibonacci.Contains(numero))
            {
                Console.WriteLine($"O numero {numero} pertence a sequencia");
            }
            else
            {
                Console.WriteLine($"O numero {numero} não pertence a sequencia");
            }
            Console.ReadKey();
            
        }
    }
}
