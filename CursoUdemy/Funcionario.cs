using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace CursoUdemy
{
    internal class Funcionario
    {

        public string Nome { get; set; }
        public double Salario { get; private set; }
        public int Id { get;}

        public Funcionario(string nome, double salario, int id)
        {
            Nome = nome;
            Salario = salario;
            this.Id = id;
        }

        public void AumentarSalario(double porcentagem) 
        {
            Salario += (Salario * porcentagem) / 100.0;
        }

        public override string ToString()
        {
            return Id
                + ", "
                + Nome
                + ", "
                + Salario.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
