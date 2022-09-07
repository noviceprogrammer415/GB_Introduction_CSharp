﻿using System;

namespace Task_4_4
{
	class Program
	{
		static void Main(string[] args)
		{
			// 4 Задача

			Console.Write("Введите число для вывода количества чисел последовательности Фибоначчи: ");
			int count = Convert.ToInt32(Console.ReadLine());
			int i = 0;

			int[] arrayNumbers = new int[count];

			GetSequence(1, 0, 0, count, i, arrayNumbers);

			foreach (var number in arrayNumbers)
				Console.Write(number + " ");

			Console.ReadLine();
		}

		static void GetSequence(int n, int k, int sum, int count, int i, int[] arrayNumbers)
		{
			i++;

			if (i < count)
			{
				sum = n + k;
				n = sum - n;
				k = sum;
				GetSequence(n, k, sum, count, i, arrayNumbers);
				arrayNumbers[i] = sum;
			}
		}
	}
}
