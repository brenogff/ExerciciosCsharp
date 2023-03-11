using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosCsharp.Ex02
{
    public class Exercicio02
    {

        public void Executar()
        {
            /*2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores 
            (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...), 
            escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci 
            e retorne uma mensagem avisando se o número informado pertence ou não a sequência.

            IMPORTANTE:
            Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;*/

            Console.Write("Informe um numero: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSequencia de Fibonacci:");

            int atual = 1;
            int anterior = 0;

            while (atual <= numero)
            {
                Console.Write($"{atual} ");

                int proximo = atual + anterior;
                anterior = atual;
                atual = proximo;

                if (atual == numero)
                {
                    Console.Write($"{anterior} {atual}");
                    Console.WriteLine($"\n{numero} pertence a sequencia de Fibonacci.");
                    return;
                }
            }

            Console.WriteLine($"\n{numero} nao pertence a sequencia de Fibonacci.");

        }


    }
}