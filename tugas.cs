using System;

class Program
{
    static void Main()
    {
        int treeRows = 7;
        for (int i = 1; i <= treeRows; i++)
        {
            for (int j = 0; j < treeRows - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 0; k < 2 * i - 1; k++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        for (int i = 0; i < 7; i++)
        {
            for (int j = 0; j < treeRows - 1; j++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("*");
        }
    }
}