using System;

namespace SelectionSort
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Quantos dados deseja classificar?");
            Console.WriteLine("ENTER para 100");
            var ehNumero = int.TryParse(Console.ReadLine(), out int dimensao);

            if (!ehNumero)
                dimensao = 100;

            string opcao = "0";

            while (opcao != "1" && opcao != "2")
            {
                Console.WriteLine();
                Console.WriteLine("Escolha a opção de classificação:");
                Console.WriteLine("[1] Ascendente    [2] Descendente");
                opcao = Console.ReadKey().KeyChar.ToString();
            }

            Console.Clear();

            double[] sortArray = new double[dimensao];

            for (int i = 0; i < dimensao; i++)
            {
                ehNumero = false;

                while (!ehNumero)
                {
                    Console.WriteLine($"Digite o valor do {i + 1}º elemento:");
                    ehNumero = double.TryParse(Console.ReadLine(), out sortArray[i]);
                }
            }

            Console.Clear();
            Console.WriteLine("** Início do processamento - Aguarde **");

            if (opcao == "1")
                Classifica.Ascende(dimensao, sortArray);
            else
                Classifica.Descende(dimensao, sortArray);

            
        }
    }
}
