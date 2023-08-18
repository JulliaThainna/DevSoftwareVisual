using Aula2._2;

namespace aula2._2 
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Criar cliente 1 e conta 1
            ContaCorrente c1 = new ContaCorrente();
            Cliente cliente1 = new Cliente();
            Console.WriteLine("Digite o nome do Cliente: ");
            cliente1.Nome = Console.ReadLine();
            c1.Titular = cliente1;
            Console.WriteLine("Digite o saldo da conta: ");
            c1.Saldo = decimal.Parse(Console.ReadLine());

            //Criar cliente e conta 2
            ContaCorrente c2 = new ContaCorrente();
            Cliente cliente2 = new Cliente();
            Console.WriteLine("Digite o nome do Cliente: ");
            cliente2.Nome = Console.ReadLine();
            c2.Titular = cliente2;
            Console.WriteLine("Digite o saldo da conta: ");
            c2.Saldo = decimal.Parse(Console.ReadLine());


            /*Testando método PIX c1 -> c2*/
            Console.WriteLine("Quanto deseja transferir? " + c1.Titular.Nome + "-> " + c2.Titular.Nome);
            decimal valor = decimal.Parse(Console.ReadLine());
            if (c1.Pix(valor, c2))
            {
                Console.WriteLine("Transferência realizada com sucesso!");
                Console.WriteLine(c1.Saldo);
            }
            else
            {
                Console.WriteLine("Erro ao realizar transferência");
            }
            Console.ReadLine(); //só pra janela nao fechar
            

            /* Testes
            
            c1.Depositar(-1);
            Console.WriteLine("Saldo de " +  c1.saldo + " é " + c1.saldo);

            c1.Depositar(250.50m);
            Console.WriteLine("Saldo de " + c1.saldo + " é " + c1.saldo);

            c1.Sacar(400);
            Console.WriteLine("Saldo de " + c1.saldo + " é " + c1.saldo);

            c1.Sacar(200);
            Console.WriteLine("Saldo de " + c1.saldo + " é " + c1.saldo);
            
             */
        }
    }
}
