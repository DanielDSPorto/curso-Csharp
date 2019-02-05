using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioIntroducaoPOO3
{
    class Aluno
    {
        public Aluno(string Name, double Grade1, double Grade2, double Grade3)
        {
            this.Name = Name;
            this.Grade1 = Grade1;
            this.Grade2 = Grade2;
            this.Grade3 = Grade3;
            overallSum = Grade1 + Grade2 + Grade3;
        }

        public string Name { get; }
        public double Grade1 { get; }
        public double Grade2 { get; }
        public double Grade3 { get; }
        public double overallSum;



        public override string ToString()
        {
            if (overallSum < 60)
                return string.Format("NOTA FINAL = {0}\n" + "REPROVADO\n" + "FALTARAM {1} PONTOS", overallSum.ToString("F2"), (60 - overallSum).ToString("F2"));
            return string.Format("NOTA FINAL = {0}\n" + "APROVADO", overallSum.ToString("F2"));
         }
    }
}
