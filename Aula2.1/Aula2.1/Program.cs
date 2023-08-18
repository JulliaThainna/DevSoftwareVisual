namespace aula2{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor de saque: ");
            double saque = double.Parse(Console.ReadLine());
            int[] notas = new int[] {100, 50, 10, 5, 2};

            for(int i = 0; i < notas.Length; i++)
            {
                int qtdNotas = (int) saque / notas[i];
                saque -= qtdNotas * notas[i];
                Console.WriteLine("Notas de " + notas[i] + ": " + qtdNotas);
            }

            Console.ReadLine();
        }
    }
 }