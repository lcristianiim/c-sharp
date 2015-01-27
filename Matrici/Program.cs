using System;
using System.IO;
// Probleme cu matrici. Cel mai mare numar din matrice. Cel mai mic numar din matrice. Cel mai mic numar de pe fiecare linie.
// Cel mai mare numar de pe fiecare linie. Suma de pe fiecare linie, coloana. Linia care are cea mai mare suma a elementelor.

// Suma diagonalei
// Suma elementelor sub diagonala
// Produsul matricilor

namespace Matrici
{
	class MainClass
	{


		private static int [,] initializerandommatrix (int [,] m, int value_interval)
		{
			Random r = new Random ();
			for (int i = 0; i<m.GetLength(0); i++)
				for (int j = 0; j < m.GetLength(1); j++)
					m [i,j] = r.Next (0, value_interval);
			return m;
		}

		private static void displaymatrix(int [,] m)
		{

			for (int i = 0; i < m.GetLength(0); i++) {
				for (int j = 0; j < m.GetLength(1); j++) {
					Console.Write("{0,4}", m[i,j]);
				}
				Console.WriteLine();
			}
		}

		private static void BiggestNumer (int [,] m)
		{
			int max = 0;

			for (int i = 0; i < m.GetLength(0); i++) {
				for (int j = 0; j < m.GetLength(1); j++) {
					if (m[i,j] > max) {
						max = m [i, j];
					}
				}
			}
			Console.WriteLine ("Cel mai mare numar din matrice este: {0}", max);
		}

		private static void SmallestNumber (int [,] m, int value_interval)
		{
			int min = value_interval;

			for (int i = 0; i < m.GetLength(0); i++) {
				for (int j = 0; j < m.GetLength(1); j++) {
					if (m[i,j] < min) {
						min = m [i, j];
					}
				}
			}
			Console.WriteLine ("Cel mai mic numar din matrice este: {0}", min);
		}

		private static void SmallestFromLine (int [,] m, int value_interval) {
			Console.WriteLine ();

			for (int i = 0; i < m.GetLength(0); i++) {
				int min = value_interval;

				for (int j = 0; j < m.GetLength(1); j++) {
					if (m[i,j] < min) {
						min = m [i, j];
					}
				}
				Console.WriteLine ("Minimul de pe linia {0} este {1}", i+1, min);
			}
		}

		private static void BiggestFromLine (int [,] m) {
			Console.WriteLine ();

			for (int i = 0; i < m.GetLength(0); i++) {
				int max = 0;

				for (int j = 0; j < m.GetLength(1); j++) {
					if (m[i,j] > max) {
						max = m [i, j];
					}
				}

				Console.WriteLine ("Maximul de pe linia {0} este {1}", i+1, max);
			}
		}

		private static void SumOfEachLine (int [,] m) {
			for (int i = 0; i < m.GetLength(0); i++) {
				int sum = 0;
				for (int j = 0; j < m.GetLength(1); j++) {
						sum = sum + m[i,j];
				}
				Console.WriteLine ("Suma elementelor de pe linia {0} este {1}", i+1, sum);
			}
		}

		private static void SumOfEachColumn (int [,] m) {
			for (int i = 0; i < m.GetLength(0); i++) {
				int sum = 0;
				for (int j = 0; j < m.GetLength(1); j++) {
					sum = sum + m[j,i];
				}
				Console.WriteLine ("Suma elementelor de pe coloana {0} este {1}", i+1, sum);
			}
		}

		private static void SumOfMatrixDiag (int [,] m) {
			int sum = 0;
			for (int i = 0; i < m.GetLength(0); i++) {
				sum = sum + m [i,i];
			}
			Console.WriteLine ("Suma elementelor de pe diagonala matricei este: {0}", sum);
		}

		private static void SumOfSecondaryDiag (int [,] m) {
			int sum = 0;
			int count = m.GetLength(0)-1;
			for (int i = 0; i < m.GetLength(0); i++) {
				sum = sum + m [i, count];
				count--;
			
				}
			Console.WriteLine ("Suma elementelor de pe diagonala secundara este: {0}", sum);
		}
				
		private static void MultiplyMaxtrixes(int [,] m, int[,] n) {
			int r_m1 = m.GetLength(0);
			int c_m2 = n.GetLength (1);

			int [,] x = new int[r_m1, c_m2];

			for (int i = 0; i < r_m1; i++){
				for (int j = 0; j < c_m2; j++) {
					x[i, j] = 0;
					for (int k = 0; k < m.GetLength(1); k++)
						x[i, j] = x[i, j] + m[i, k] * n[k, j];
				}
			}
			displaymatrix (x);

		}

		public static void Main (string[] args)
		{
			int[,] m = new int[3, 3];
			//This value_interval sets the max value which the elements of the matrix can have
			int value_interval = 5;

			m = initializerandommatrix (m, value_interval);
			displaymatrix (m);
			Console.WriteLine ();
			BiggestNumer (m);
			SmallestNumber (m, value_interval);
			SmallestFromLine (m, value_interval);
			BiggestFromLine (m);
			Console.WriteLine ();
			SumOfEachLine (m);
			SumOfEachColumn (m);
			Console.WriteLine ();
			SumOfMatrixDiag (m);
			SumOfSecondaryDiag (m);
			MultiplyMaxtrixes (m,m);

			ReadMatrixFromFile()
		}


	}
}
