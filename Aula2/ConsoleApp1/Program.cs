namespace aula2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Receber uma idade e acompanhante (bool)
            // só entra maior de 18 acompanhado
            Console.WriteLine("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine()); //readline só retorna string
            Console.WriteLine("Acompanhado? false - Não / true - Sim");
            bool isAcompanhado = bool.Parse(Console.ReadLine());

            if (idade >= 18 && isAcompanhado == true)
            {
                Console.WriteLine("Acesso autorizado");
            }
            else
            {
                Console.WriteLine("Acesso não autorizado");
            }
            Console.ReadLine(); //Serve para não fechar a janela antes de acabar a execução (gambiarra)
        }
    }
}