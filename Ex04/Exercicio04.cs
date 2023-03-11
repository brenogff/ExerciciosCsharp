using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosCsharp.Ex04
{
    public class Exercicio04
    {
        public void Executar()
        {
            /*4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
            SP – R$67.836,43
            RJ – R$36.678,66
            MG – R$29.229,88
            ES – R$27.165,48
            Outros – R$19.849,53
            Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro 
            do valor total mensal da distribuidora.*/

            decimal SP = 6783643;
            decimal RJ = 3667866;
            decimal MG = 2922988;
            decimal ES = 2716548;
            decimal Outros = 1984953;

            decimal total = (SP + RJ + MG + ES + Outros);

            Console.WriteLine($"O total mensal da distribuidora sera: {total.ToString("C")}");

            var PercentualSP = ((SP / total) * 100);
            var PercentualRJ = ((RJ / total) * 100);
            var PercentualMG = ((MG / total) * 100);
            var PercentualES = ((ES / total) * 100);
            var PercentualOutros = ((Outros / total) * 100);

            Console.WriteLine($"Percentual de SP sera: {PercentualSP = Math.Round(Convert.ToDecimal(PercentualSP), 2)} %");
            Console.WriteLine($"Percentual de RJ sera: {PercentualRJ = Math.Round(Convert.ToDecimal(PercentualRJ), 2)} %");
            Console.WriteLine($"Percentual de MG sera: {PercentualMG = Math.Round(Convert.ToDecimal(PercentualMG), 2)} %");
            Console.WriteLine($"Percentual de ES sera: {PercentualES = Math.Round(Convert.ToDecimal(PercentualES), 2)} %");
            Console.WriteLine($"Percentual de Outros sera: {PercentualOutros = Math.Round(Convert.ToDecimal(PercentualOutros), 2)} %");

        }
    }
}