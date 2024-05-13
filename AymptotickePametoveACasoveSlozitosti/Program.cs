namespace Maturita
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Big O - nejhorsi case scenario

            // Big Omega - nejlepsi case scenario

            // Bit Theta - stredni case scenario


            int[] array = new int[] { 1, 2, 3, 4, 5, 6 };

            // konstantni O(1)
            array[0] = 1;    // O(1)
            array[5] = 1; // O(1)  

            // logaritmicka O(log n)
            // binary search tree, merge sort, quick sort

            // linearni  O(n)
            int sum = array.Sum();

            sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }

            // kvadraticka O(n^2)
            int[,] doubleDimension = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < doubleDimension.GetLength(0); i++)
            {
                for (int j = 0; j < doubleDimension.GetLength(1); j++)
                {
                    Console.WriteLine(doubleDimension[i, j]);
                }
            }

            // kubicka O(n^3)
            int[] triplet = new int[] { 1, 2, 3 };

            for (int i = 0; i < triplet.Length; i++)
            {
                for (int j = 0; j < triplet.Length; j++)
                {
                    for (int k = 0; k < triplet.Length; k++)
                    {
                        Console.WriteLine($"{triplet[i]} {triplet[j]} {triplet[k]}");
                    }
                }
            }

            // faktorial O(n!)
            int a = Factorial(5);

            Console.WriteLine(a);
        }

        public static int Factorial(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            if (n == 1)
            {
                return 1;
            }

            return n * Factorial(n - 1);
        }
    }
}