using System;
using System.Collections.Generic;
using System.Text;

namespace Section10finalExercise.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual()
        {

        }
        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }
        public override double Tax()
        {
            var taxRange = (AnualIncome < 20000.00) ? (0.15) : (0.25);
            return (AnualIncome * taxRange) - (0.5 * HealthExpenditures);
        }
    }
}
