using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ExerciciosCsharp.Ex05
{
    public class Exercicio05
    {
        public void Executar()
        {
            /*
            5) Escreva um programa que inverta os caracteres de um string.
            IMPORTANTE:
            a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
            b) Evite usar funções prontas, como, por exemplo, reverse;*/

            Console.WriteLine("Digite uma palavra: ");
            string palavra = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (var i = palavra.Length - 1; i >= 0; i--)
            {
                sb.Append(palavra[i]);
            }
            Console.WriteLine(sb.ToString());

        }
    }
}