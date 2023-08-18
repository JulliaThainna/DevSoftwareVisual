using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula2._2
{
    public class ClientePj : Cliente //: é o extends (herança)
    {
        public string Cnpj { get; set; }
        public string RazaoSocial { get; set; }
        public ClientePj(string nome, string cnpj) : base(nome) 
        {
            this.Cnpj = cnpj;
        }

        public virtual string GerarRelatorio() //virtual é = @overwrite
        {
            return this.RazaoSocial + " - " + this.Email;
        }
    }
}
