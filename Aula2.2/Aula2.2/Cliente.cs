using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2._2
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        //Se não colocar que é public ele considera como private

        //Constructor
        public Cliente(string nome) { 
            this.Nome = nome; 
        }

        public string GerarRelatorio()
        {
            return this.Nome + " - " + this.Email;
        }
    }
}
