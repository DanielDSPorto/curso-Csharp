using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioFixacao01
{
    class ContaBancaria
    {
        public ContaBancaria(int numeroConta, string nomeTitular, double saldoInicial)
        {
            this.numeroConta = numeroConta;
            this.nomeTitular = nomeTitular;
            this.saldoConta = saldoInicial;
        }

        public ContaBancaria(int numeroConta, string nomeTitular)
        {
            this.numeroConta = numeroConta;
            this.nomeTitular = nomeTitular;
            this.saldoConta = 0;
        }

        public string nomeTitular
        {
            get; set;
        }
        public int numeroConta
        {
            get;
        }

        public double saldoConta
        {
            get; private set;
        }

        public void depositar(double deposito)
        {
            if (deposito <= 0)
            {
                Console.WriteLine("Valores negativos de depósito são inválidos");
            }
            else
            { 
                this.saldoConta += deposito;
            }
        }

        public double sacar (double valor)
        {
            if (saldoConta <= 0)
            {
                Console.WriteLine("Você não pode sacar porque não possui dinheiro em sua conta");
                return 0;
            }
            else if (valor > saldoConta)
            {
                valor = saldoConta;
                saldoConta = -5;
            }
            else
            {
                saldoConta -= (valor + 5);
            }
            return valor;
        }

    }
}
