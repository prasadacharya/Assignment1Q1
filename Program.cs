using System;

namespace AssignmentQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please provide your input number");

            string N = Console.ReadLine();

            int n = Convert.ToInt32(N);


            for (int i = 0; i <= n; i++)
            {
                for (int j = n-i; j >= 1; j--)
                {
                    Console.Write(j);
                }
                Console.Write("\n");
            }

        }
    }
}
