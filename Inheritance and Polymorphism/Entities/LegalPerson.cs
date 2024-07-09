using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Polymorphism.Entities
{
    internal class LegalPerson : TaxPayers
    {
        public int NumberOfEmployees { get; set; }

        public LegalPerson() { }

        public LegalPerson(string name, double annualIncome,int numberOfEmployees) : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double TaxCalculation()
        {
            double rate = 0.16;
            if (NumberOfEmployees >= 20)
            {
                rate = 0.14;
            }
            return AnnualIncome * rate;
        }
    }
}
