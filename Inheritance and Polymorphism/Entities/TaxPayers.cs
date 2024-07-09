using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Polymorphism.Entities
{
    abstract internal class TaxPayers
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public TaxPayers() { }

        public TaxPayers(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        abstract public double TaxCalculation();
    }
}
