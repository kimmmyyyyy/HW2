using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        List<List<double>> numbers = new List<List<double>>();
        double sum = 0;

        Console.Write("Enter row: ");
        int row = int.Parse(Console.ReadLine());

        Console.Write("Enter column: ");
        int col = int.Parse(Console.ReadLine());

        for (int i = 0; i < row; i++)
        {
            Console.WriteLine($"Row  {i + 1}");
            List<double> rows = new List<double>();

            for (int j = 0; j < col; j++)
            {
                Console.Write($"Enter number {j + 1}: ");
                double num = double.Parse(Console.ReadLine());
                rows.Add(num);
                sum += num;
            }

            numbers.Add(rows);
        }

        Console.WriteLine("The numbers are:");
        foreach (var rows in numbers)
        {
            foreach (var num in rows)
            {
                Console.Write(num.ToString("0.0") + " ");
            }
            Console.WriteLine();
        }

        double average = sum / (row * col);
        Console.WriteLine($"Sum: {sum:0.00} ; Average: {average:0.00}");

        Console.ReadKey();

    }
}
