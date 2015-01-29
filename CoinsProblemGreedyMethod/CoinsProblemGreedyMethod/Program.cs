using System;

namespace CoinsProblemGreedyMethod
{
	class MainClass
	{
		//This function uses the greedy method
		private static int GetMinimumNumberOfCoins (int sum, int [] v) {
			int count = 0;

			for (int i = 0; i < v.Length; i++) {
				while (sum - v[i] > 0) {
					if (sum >= v[i]) {
						sum = sum - v[i];
						count++;
					}
				}
			}
			return count;
		}

		public static void Main (string[] args)
		{
			int[] v = {25, 10, 5, 1};
			Console.WriteLine("Monezile disponibile sunt: ");
			for (int i = 0; i < v.Length; i++){ Console.Write("{0} ", v[i]); }
			Console.WriteLine();
			Console.WriteLine ("Introduceti suma pentru a se returna numarul minim de monezi: ");
			int x = int.Parse(Console.ReadLine());

			int number_of_coins = GetMinimumNumberOfCoins(x, v);

			Console.WriteLine(number_of_coins);
		}
	}
}
