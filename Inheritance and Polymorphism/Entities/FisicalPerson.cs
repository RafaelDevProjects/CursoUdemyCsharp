using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_and_Polymorphism.Entities
{
    internal class FisicalPerson : TaxPayers
    {
        public double HealthSpending { get; set; }
        public FisicalPerson() { }
        public FisicalPerson(string name, double annualIncome, double healthSpending) : base(name, annualIncome)
        {
            HealthSpending = healthSpending;
        }

        public override double TaxCalculation()
        {
            double rate = 0.25;
            if (AnnualIncome < 20000.00) 
            {
                rate = 0.15;
            }
            if (HealthSpending > 0)
            {
                return (AnnualIncome * rate) - (HealthSpending * 0.50);
            }
            else
            {
                return (AnnualIncome * rate);
            }
        }
    }
}
