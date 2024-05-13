using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Vetor_Media_Altura
{
 internal class Program
 {
  static void Main(string[] args)
  {


   Console.Write("Digite o numero de indices maximos do vetor: ");
   int x = int.Parse(Console.ReadLine());
   double[] Altura = new double[x];

   for (int iterador = 0; iterador < x; iterador++){
   Altura[iterador] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
   }

   double soma = 0.0;
   for(int iterador = 0; iterador < x; iterador++){
   soma += Altura[iterador];
   }

   double media = soma / x;
   Console.WriteLine($"Media das alturas: {media.ToString("F2",CultureInfo.InvariantCulture)}");

  }
 }
}
