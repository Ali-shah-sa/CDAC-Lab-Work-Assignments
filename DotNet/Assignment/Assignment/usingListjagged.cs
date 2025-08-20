using System;

class Programj
{
    static void Main()
    {
        Console.Write("Enter number of batches: ");
        int batchCount = int.Parse(Console.ReadLine()!);

        int[][] marks = new int[batchCount][];

        for (int i = 0; i < batchCount; i++)
        {
            Console.Write($"Enter number of students in batch {i + 1}: ");
            int studentCount = int.Parse(Console.ReadLine()!);

            marks[i] = new int[studentCount];

            for (int j = 0; j < studentCount; j++)
            {
                Console.Write($"Enter mark for student {j + 1} in batch {i + 1}: ");
                marks[i][j] = int.Parse(Console.ReadLine()!);
            }
        }

        Console.WriteLine("\nDisplaying all marks:");
        for (int i = 0; i < marks.Length; i++)
        {
            Console.WriteLine($"Batch {i + 1}:");
            for (int j = 0; j < marks[i].Length; j++)
            {
                Console.WriteLine($"  Student {j + 1}: {marks[i][j]}");
            }
        }
    }
}
