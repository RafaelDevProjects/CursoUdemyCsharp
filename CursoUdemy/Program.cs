using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
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

            //List<string> list = new List<string>(); // instanciando uma lista
            //list.Add("rafael"); // adicionando item na lista
            //list.Add("rafaela");
            //list.Add("Mauricio");
            //list.Add("Carlinhos");
            //list.Add("Patricia");


            //list.Insert(1, "Marcos"); // adiciona item no index
            //Console.WriteLine($"Numero de pessoas na lista: {list.Count()}"); // mostra quantos items tem na lista


            //foreach (var item in list)
            //{
            //    Console.WriteLine(item); // vai mostrar cada item da lista
            //}

            //string s1 = list.Find(a => a.StartsWith("r")); // encontra o primeiro nome da lista que começa com a letra "r"
            //string s2 = list.Find(a => a.EndsWith("s")); // encontra o primeiro nome da lista que termina com a letra "s"
            //string s3 = list.Find(a => a.Equals("rafael")); // encontra o primeiro nome da lista que seja igual a "rafael"

            //string s4 = list.FindLast(a => a.StartsWith("r")); // encontra o ultimo nome da lista que comece com a letra 'r'

            //int pos1 = list.FindIndex(a => a.StartsWith("r")); // encontra o indice do primeiro nome que começa com "r"
            //int pos2 = list.FindLastIndex(a => a.StartsWith("r")); // encontra o indice do ultimo nome que começa com "r"

            //List<string> list2 = list.FindAll(a => a.Length >= 5); // filtra a lista original em uma outra lista, o filtro é para todos os nome com mais de 5 caracteres ou igual

            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine($"Primeiro nome da lista que começa com 'r': {s1}");
            //Console.WriteLine($"Primeiro nome da lista que termina com 's': {s2}");
            //Console.WriteLine($"Primeiro nome da lista que seja igual a 'rafael': {s3}");
            //Console.WriteLine($"Ultimo nome da lista que começa com 'r': {s4}");
            //Console.WriteLine($"Indice do primeiro nome da lista que começa com 'r': {pos1}");
            //Console.WriteLine($"Indice do ultimo nome da lista que começa com 'r': {pos2}");

            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Lista filtrada com nomes com mais de 5 caractéres");
            //foreach (var item in list2)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Lista usando o Remove para remover o nome Marcos");
            //list.Remove("Marcos"); // remove o "Marcos"
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item); // vai mostrar cada item da lista
            //}

            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Lista usando o RemoveAt para remover o nome na posição 1");
            //list.RemoveAt(1); // remove o nome da pessoa que esta na posição 2
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item); // vai mostrar cada item da lista
            //}


            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Lista usando o RemoveAll para remover todos os nome com a letra 'r'");
            //list.RemoveAll(a => a.StartsWith("r")); // Remove todos que tem a letra "r"

            //foreach (var item in list)
            //{
            //    Console.WriteLine(item); // vai mostrar cada item da lista
            //}

            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("Lista usando o Remove para remover um range de 2 pessoas a partir da posição 1");
            //list.RemoveRange(1, 2); // remove apartir da posição 1, ele remove 1 elemento
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item); // vai mostrar cada item da lista
            //}



            #endregion

            #region List Exercicio de Fixação

            //List<Funcionario> funcionarios = new List<Funcionario>();

            //Console.Write("Numero de funcionarios: ");
            //int n = int.Parse(Console.ReadLine());


            //for (int i = 0; i < n; i++)
            //{
            //    Console.Write("ID: ");
            //    int id = int.Parse(Console.ReadLine());

            //    Console.Write("Nome: ");
            //    string nome = Console.ReadLine();

            //    Console.Write("Salario: ");
            //    double salario = double.Parse(Console.ReadLine());

            //    Funcionario funcionario = new Funcionario(nome, salario, id);
            //    funcionarios.Add(funcionario);

            //    Console.WriteLine();

            //}

            //Console.WriteLine("Aumento de salario ");
            //Console.Write("ID do funcionario: ");
            //int ID = int.Parse(Console.ReadLine());

            //Funcionario fun = funcionarios.Find(a => a.Id == ID);
            //if (fun != null)
            //{
            //    Console.Write("Qual é a pocentagem: ");
            //    double porcentagem = double.Parse(Console.ReadLine());
            //    fun.AumentarSalario(porcentagem);
            //}
            //else
            //{
            //    Console.WriteLine("Esse ID não existe");
            //}

            //Console.WriteLine();
            //Console.WriteLine("Lista de funcionarios: ");
            //foreach (Funcionario obj in  funcionarios)
            //{
            //    Console.WriteLine(obj.ToString());
            //}

            #endregion
        }
    }
}
