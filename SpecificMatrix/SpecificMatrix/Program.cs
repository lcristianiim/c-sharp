using System;

// Creation of a matrix with form: 
// 111122223333
// 111122223333
// 444455556666
// 444455556666
// 777788889999
// 777788889999

namespace SpecificMatrix
{
	class MainClass
	{
		private static int [,] MatrixCreation (int m, int n) {
			int[,] x = new int[m,n];
			int k = 1;
			int count = 0;

			for (int i=0; i < m-1; i=i+2) {
				for (int j=0; j < n; j++) {
					x [i, j] = k;
					x [i + 1, j] = k;
					count++;
					if (count % 4 == 0) {k++;}

				}
			}
			return x;
		}

		private static void DisplayMatrix (int [,] x) {
			for (int i=0; i < x.GetLength(0); i++) {
				for (int j=0; j < x.GetLength(1); j++) {
					Console.Write ("{0,3} ",x[i,j]);
				}
				Console.WriteLine ();
			}
		}

		public static void Main (string[] args)
		{
			int[,] x = null;
			x = MatrixCreation (6, 12);
			DisplayMatrix (x);
		}
	}
}
