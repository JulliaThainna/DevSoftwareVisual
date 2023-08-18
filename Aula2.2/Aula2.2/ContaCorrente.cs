using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2._2
{
    public class ContaCorrente
    {
        public Cliente Titular { get; set; }
        public int Numero { get; set; }
        public int Agencia { get; set; } //prop
        public decimal Saldo
        {
            get { return Saldo; }
            set { Saldo = value; }
        } // Para casos especiais

        public bool Sacar(decimal valor)
        {
            if (Saldo < valor)
            {
                return false;
            }
            else
            {
                Saldo -= valor;
                return true;
            }
        }

        public bool Depositar(decimal valor)
        {
            if (valor > 0)
            {
                this.Saldo += valor;
                return true;
            }
            else
            {
                Console.WriteLine("Depósito deve ser maior que 0");
                return false;
            }
        }

        public bool Pix(decimal valor, ContaCorrente contaDestino)
        {
            if (contaDestino != null && this.Sacar(valor))
            {
                return contaDestino.Depositar(valor);
            }
            return false;
        }
    }
}
