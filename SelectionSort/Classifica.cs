using System;

namespace SelectionSort
{
    public static class Classifica
    {
        public static void Ascende(int dimensao, double[] sortArray)
        {
            var startTime = DateTime.Now;

            for (int i = dimensao - 1; i > 0; i--)
            {
                var maior = sortArray[0];
                int index = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (sortArray[j] > maior)
                    {
                        maior = sortArray[j];
                        index = j;
                    }
                }

                var calice = sortArray[i];
                sortArray[i] = maior;
                sortArray[index] = calice;
            }

            var totalTime = DateTime.Now - startTime;

            PrintArray(sortArray, totalTime);
        }

        public static void Descende(int dimensao, double[] sortArray)
        {
            var startTime = DateTime.Now;

            for (int i = dimensao - 1; i > 0; i--)
            {
                var maior = sortArray[0];
                int index = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (sortArray[j] < maior)
                    {
                        maior = sortArray[j];
                        index = j;
                    }
                }

                var calice = sortArray[i];
                sortArray[i] = maior;
                sortArray[index] = calice;
            }

            var totalTime = DateTime.Now - startTime;

            PrintArray(sortArray, totalTime);
        }

        private static void PrintArray(double[] sortArray, TimeSpan totalTime)
        {
            foreach (var item in sortArray)
                Console.WriteLine(item);

            Console.WriteLine();
            Console.WriteLine($"Tempo de processamento: {totalTime}");
        }
    }
}
