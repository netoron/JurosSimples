using System;

namespace JurosSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            string capital;
            string juros;
            string tempo;

            double capital1; 
            double juros1;
            double tempo1;
            double soma;
            double soma2;
            
            Console.WriteLine("Calcule o montante final de um investimento a juros simples");
            Console.WriteLine("Digite o capital");
            capital = Console.ReadLine();
            Console.WriteLine("Digite a porcentagem de juros");
            juros = Console.ReadLine();
            Console.WriteLine("Digite quantos meses");
            tempo = Console.ReadLine();
            
            capital1 = Convert.ToDouble(capital);
            juros1 = Convert.ToDouble(juros);
            tempo1 = Convert.ToDouble(tempo);

            soma = capital1 * juros1 * tempo1;
            soma2 = soma + capital1;
            
            Console.WriteLine($"O juros é:{soma}");
            Console.WriteLine($"O Montante é:{soma2}");
            ////    INCOMPLETO   /////// INCOMPLETO    ///////   INCOMPLETO ///////
            
        }
    }
}
