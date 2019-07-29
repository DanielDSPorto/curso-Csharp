using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioFixacao01
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria c1, c2;
            Console.WriteLine("Deseja cadastrar uma conta? Insira o numero da nova conta, o nome do usuário e o valor do deposito inicial (se houver)");
            c1 = new ContaBancaria(int.Parse(Console.ReadLine()), Console.ReadLine(), double.Parse(Console.ReadLine()));
            Console.WriteLine("Deseja cadastrar uma conta? Insira o numero da nova conta, o nome do usuário e o valor do deposito inicial (se houver)");
            c2 = new ContaBancaria(int.Parse(Console.ReadLine()), Console.ReadLine(), double.Parse(Console.ReadLine()));


            char? caracterDeSaida = null;

            while (caracterDeSaida != 'x')
            {
                Console.WriteLine("Deseja saber quanto há na conta de " + c1.nomeTitular + "?  (s/n)");
                caracterDeSaida = Char.Parse(Console.ReadLine());
                if (caracterDeSaida == 's')
                {
                    Console.WriteLine("a conta de " + c1.nomeTitular + " tem " + c1.saldoConta.ToString("F2"));
                }
                Console.WriteLine("Deseja sair? (aperte x para isso)");
                caracterDeSaida = Char.Parse(Console.ReadLine());
            }

        }
    }
}
