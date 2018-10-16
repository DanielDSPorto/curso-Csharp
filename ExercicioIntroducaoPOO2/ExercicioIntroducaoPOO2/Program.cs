using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario F;

            Console.WriteLine("cadastre aqui seu funcionário");
            Console.WriteLine("Nome , depois salário bruto e então o desconto feito de seu salário");

            F = new Funcionario(Console.ReadLine(), double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture), double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture));

            Console.WriteLine(string.Format("Dados do funcionário: {0}, R$ {1}", F.nome, F.salarioLiquido().ToString("F2")));
            Console.WriteLine("Deseja aumentar o salário em qual porcentagem?");
            F.aumentarSalario(double.Parse(Console.ReadLine()));
            Console.WriteLine(string.Format("Os novos dados do funcionário são: {0}, R$ {1}", F.nome, F.salarioLiquido().ToString("F2")));

            Console.ReadLine();

        }
    }
}
