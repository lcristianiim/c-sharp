using System;

namespace AlgoritmDeSortare
{
	class MainClass
	{
		private static void DisplayVector (int [] v) {
			for (int i = 0; i < v.Length; i++) {
				Console.Write ("{0} ", v[i]);
			}
		}

		//Insertion sort
		private static int [] InsertionSort (int [] v) {
			int n = v.Length;
			int m;
			for (int i = 1; i < n; i++) {
				m = v [i];
				int j = i - 1;
				while (j >= 0 && v[j] > m) {
					v [j+1] = v [j];
					--j;
				}
				v [j + 1] = m;
			}
			return v;
		}

		//Optimized buble sort function
		private static int [] BubleSort(int [] v) {
			int n = v.Length;
			bool sorted = true;

			for (int j = 0; j < n-1 || sorted == false; j++) {
				sorted = true;
				for (int i = 0; i < n - 1 - j; i++) {
					if (v[i] > v[i+1]) {
						int temp = v [i];
						v [i] = v [i + 1];
						v [i + 1] = temp;
						sorted = false;
					}
				}
			}
			return v;
		}

		//Selection sort function
		private static int [] SelectionSort (int [] v) {
			int n = v.Length;
			int min;

			for (int i = 0; i < n-1; i++) {
				min = i;
				for (int j = i ; j < n; j++) {
					if (v[j] < v[min]) {
						min = j;
					}
				}
				if (min != i) {
					int temp = v [min];
					v [min] = v [i];
					v [i] = temp;
				}
			}
			return v;
		}

		// This function creates a random vector of 'x' length
		private static int [] InitializeRandomVector (int x) {
			int [] v = new int[x];
			Random r = new Random();

			for (int i = 0; i < x; i++) {
				v [i] = r.Next (0,10);
			}
			return v;
		}

		public static void Main (string[] args)
		{
			//the x var is the length of the vector
			int x = 10;
			int [] v1 = new int[x];

			v1 = InitializeRandomVector (x);
			DisplayVector (v1);
			// Here you must assign to v1 one of the tree sort functions ( BubleSort(), SelectionSort(), InsertionSort() );
			v1 = InsertionSort (v1);
			Console.WriteLine ();
			DisplayVector (v1);
		}
	}
}