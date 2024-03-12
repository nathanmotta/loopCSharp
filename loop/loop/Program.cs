namespace loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de Variaveis
            int t;

            // Calculo da velocidade a cada instante
            for (t = 1; t < 5; t++)
            {
                Console.WriteLine("Velocidade = " + (60 - 5 * t));
            }

            // Verificação do valor de t
            Console.WriteLine(t);

            // Aguarda a digitação de uma tecla para encerrar o programa
            Console.ReadKey();
        }
    }
}
