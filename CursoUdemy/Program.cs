using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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


            //Console.WriteLine("Quantos produtos?");
            //int n = int.Parse(Console.ReadLine());

            //Produto[] produtos = new Produto[n]; // parar criar um array do tipo Produto

            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine($"Produto {i}: ");
            //    string nome = Console.ReadLine();

            //    Console.WriteLine($"Preco {i}: ");
            //    double price = double.Parse(Console.ReadLine());

            //    produtos[i] = new Produto { Nome = nome, Preco = price }; // criando um novo produto e adicionando ele ao array

            //}

            //double sum = 0.0;
            //for (int i = 0; i < n; i++)
            //{
            //    sum += produtos[i].Preco; // acessando a classe produto e pegando o atributo preço de cada um dos objetos Produto
            //}

            //double avg = sum / n;
            //Console.WriteLine($"AVEREGE PRICE: {avg}");


            //Console.Write("How many rooms will be rented? ");
            //int qnt = int.Parse(Console.ReadLine());

            //Room[] rooms= new Room[10];

            //for (int i = 0; i < qnt; i++) 
            //{
            //    Console.WriteLine($"Rent #{i}: ");
            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();
            //    Console.Write("Email: ");
            //    string email = Console.ReadLine();
            //    Console.Write("Room: ");
            //    int roomNumber = int.Parse(Console.ReadLine());
            //    rooms[roomNumber] = new Room() {Tenant = name, TenantEmail = email, RoomNumber = roomNumber};
            //    Console.WriteLine();
            //}


            //Console.WriteLine("Busy rooms: ");
            //for (int i = 0; i < 10; i++)
            //{
            //    if (rooms[i] != null)
            //    {
            //        Console.WriteLine($"{rooms[i].RoomNumber}: {rooms[i].Tenant}, {rooms[i].TenantEmail}");
            //    }

            //}





            #endregion

            #region params

            //Console.WriteLine(Calculator.Sum(2, 3)); // verificar a classe
            //Console.WriteLine(Calculator.Sum(10, 3, 100, 1, 2));

            //int a = 10;
            //Calculator.TripleRef(ref a); // a palavra ref faz com que o parametro x dentro da função Triple mude a variavel original que foi passada como referencia
            //Console.WriteLine(a);

            //int triple;
            //Calculator.TripleOut(a, out triple); // a palavra out na classe triple out faz com que a saida da função seja armazenada na variavel triple 
            //Console.WriteLine(triple);

            #endregion

            #region List

            List<string> list = new List<string>(); // instanciando uma lista
            list.Add("rafael"); // adicionando item na lista

            #endregion
        }
    }
}
