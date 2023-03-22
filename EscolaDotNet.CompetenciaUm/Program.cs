using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscolaDotNet.CompetenciaUm
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int [] notas = new int[4];
            double media;
            for (int i = 0; i <= (notas.Length-1); i++)
            {
                Console.WriteLine($"Digite a { (i + 1)}ª nota:");
                notas[i] = int.Parse(Console.ReadLine());
            }
            media = notas.Sum() / notas.Length;
            if (media <= 7) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Média: {media}");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Média: {media}");
            }
           
            Console.ReadKey();
            
        }
    }
}
