using System;

namespace Arrays_H01
{
	class MainClass
	{
		public static void Main()
		{
			int[] arrInt = new int[20]; //{ 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19};

			for (int j = 0; j < 20; j++)
			{
				arrInt[j] = j * 5;

			}


			for (int j = 0; j < 20; j++)

			{
				Console.WriteLine("За елемент " + j + " от масива цифрата е: " + arrInt[j]);
			}
		}

	}
}

