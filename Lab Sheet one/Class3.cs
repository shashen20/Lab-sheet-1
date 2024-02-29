4).using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer (N): ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("ERROR");
        }
        else
        {
            int sum = SumRecursively(n);

            Console.WriteLine($"The sum of numbers from 1 to {n} is: {sum}");
        }
    }

    static int SumRecursively(int n)
    {
        if (n == 0)
            return 0;
        else
            return n + SumRecursively(n - 1);
    }
}
