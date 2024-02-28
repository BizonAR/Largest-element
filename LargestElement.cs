using System;

namespace LargestElement
{
	internal class LargestElement
	{
		static void Main(string[] args)
		{
			int[,] matrix = new int[10, 10];

			Random random = new Random();
			int maxValue = 101;

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					matrix[i, j] = random.Next(maxValue);
				}
			}

			int maxNumber = matrix[0, 0];

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					if (matrix[i, j] > maxNumber)
						maxNumber = matrix[i, j];
				}
			}

			Console.WriteLine($"Максимальное число в матрице: {maxNumber}");
			Console.WriteLine("\nИсходная матрица:");

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write(matrix[i, j] + "  ");
				}
				Console.WriteLine();
			}

			Console.WriteLine("\nИзменённая матрица:");
			int replacementValue = 0;

			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					if (matrix[i, j] == maxNumber)
						matrix[i, j] = replacementValue;

					Console.Write(matrix[i, j] + "  ");
				}
				Console.WriteLine();
			}
		}
	}
}
