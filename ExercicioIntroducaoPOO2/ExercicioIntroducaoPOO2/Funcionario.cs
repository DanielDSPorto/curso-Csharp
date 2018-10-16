using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace curso
{
    class Funcionario
    {
        public Funcionario(string nome, double salarioBruto, double desconto)
        {
            this.nome = nome;
            this.salarioBruto = salarioBruto;
            this.desconto = desconto;
        }
        public string nome
        {
            get;
        }

        public double salarioBruto
        {
            get;set;
        }

        public double desconto
        {
            get;set;
        }
        public double salarioLiquido()
        {
            return salarioBruto - desconto;
        }

        public void aumentarSalario(double aumentoPercentual)
        {
            if (aumentoPercentual < 0)
            {
                Console.WriteLine("aumento inválido");
            }

            this.salarioBruto *= (1 + aumentoPercentual / 100);
        }

    }
}
