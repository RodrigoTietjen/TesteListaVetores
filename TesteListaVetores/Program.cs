using System;

namespace TesteListaVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            long numero = -1;

            while ((numero % 10 != 0) || (numero < 100 || numero > 1000))
            {
                Console.WriteLine("Informe um número entre 100 e 1000 que seja múltiplo de 10");
                numero = long.Parse(Console.ReadLine());
            }

            double[] vetor = new double[11];

            for (int i = 1; i <= 10; i++)
            {
                if (i % 3 != 0)
                {
                    vetor[i] = ((i * 0.1) * numero);
                }
                else
                {
                    vetor[i] = ((i * 0.3) * numero);
                }
            }

            string imparPar = "";

            double soma = 0;
            while (imparPar != "impares" && imparPar != "ímpares" && imparPar != "pares")
            {
                Console.WriteLine("Deseja saber a soma das posições ímpares ou pares do array? (digite pares ou impares)");
                imparPar = Console.ReadLine();
            }
            if (imparPar == "impares" || imparPar == "ímpares")
            {
                for (int i = 1; i <= 10; i++)
                {
                    if (i % 2 != 0)
                    {
                        soma += vetor[i];
                    }
                }
            }
            else if (imparPar == "pares")
            {
                for (int i = 1; i <= 10; i++)
                {
                    if (i % 2 == 0)
                    {
                        soma += vetor[i];
                    }
                }
            }
            Console.WriteLine("A soma das posições {0} é {1}", imparPar, soma);
            Console.ReadLine();
        }
    }
}
