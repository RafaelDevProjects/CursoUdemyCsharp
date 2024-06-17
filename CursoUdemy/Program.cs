using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region nullable

            //Nullable<double> e = null; // forma de dizer que uma variavel é nula
            //double? x = null; // outra forma de dizer que uma variavel é nula


            //Console.WriteLine(x.GetValueOrDefault()); // PEGA O VALOR 0 OU OQUE FOI DADO

            //Console.WriteLine(x.HasValue); // Ve se tem algum valor dentro da variavel

            //if (x.HasValue)
            //    Console.WriteLine(x.Value);
            //else
            //    Console.WriteLine("x is null");

            //double? a = null;
            //double? b = 10;

            //double c = a ?? 5; // a variavel a é nula, por isso sera atribuido o valor 5
            //double d =  b ?? 5; // a variavel b não é nula, por isso sera atribuido o valor 5

            //Console.WriteLine(c);
            //Console.WriteLine(d);

            #endregion

            #region arrays

            //Console.Write("Digite a quantidade de alturas:");
            //int n = int.Parse(Console.ReadLine());

            //double[] vect = new double[n]; // Cria um vetor com o nome vect |é importante escrever o tamanho do vetor nesse caso|

            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("Digite a alturas:");
            //    double? RespostaAltura = double.Parse(Console.ReadLine());

            //    double altura = RespostaAltura ?? 0.0;

            //    vect[i] = altura; // permite usar o indice do array para adicionar o valor da altura
            //}

            //// para pegar a media de alturas
            //double sum = 0.0;
            //for (int i = 0; i < n; i++)
            //{
            //    sum += vect[i];
            //}

            //double avg = sum / n;


            //Console.WriteLine("AVERAGE HEIGTH: " + avg);



            #endregion

        }
    }
}
