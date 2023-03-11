using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using System.Text;
using System.Linq.Expressions;

namespace ExerciciosCsharp.Ex03
{
    public class Exercicio03
    {
        public void Executar()
        {
            /*3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
          • O menor valor de faturamento ocorrido em um dia do mês; 
          • O maior valor de faturamento ocorrido em um dia do mês;
          • Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

          IMPORTANTE:
          a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
          b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;  
          }*/

            string conteudoArquivo = File.ReadAllText("Ex03/Arquivo/dados.json");

            var listaDados = JsonConvert.DeserializeObject<List<ArquivoJson>>(conteudoArquivo);

            var maior = listaDados.OrderByDescending(p => p.Valor).First();
            var menor = listaDados.OrderByDescending(p => p.Valor).Last();
            var total = listaDados.Sum(p => p.Valor);
            var mediaValor = listaDados.Where(p => p.Valor != 0).Average(p => p.Valor);
            var qtdDia = listaDados.Where(p => p.Valor > mediaValor).Count();

            Console.WriteLine($"O menor valor encontrado foi: {menor.Valor} No dia {menor.Dia}");
            Console.WriteLine($"O maior valor encontrado foi: {maior.Valor} no dia {maior.Dia}");
            Console.WriteLine($"O valor total foi: {total} ");
            Console.WriteLine($"Sendo a media: {mediaValor.ToString()}");
            Console.WriteLine($"A quantidade de dias com faturamento diario superior a media sera de: {qtdDia}");

        }
    }
}