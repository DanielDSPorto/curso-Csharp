using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExercicioIntroducaoPOO3
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.Write("Nome do aluno: ");
            string name = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno:");
            var aluno = new Aluno(name, double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture), double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture));
            Console.WriteLine(aluno.ToString());
        }
    }
}
