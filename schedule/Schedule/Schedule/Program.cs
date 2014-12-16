using System;
using System.IO;

namespace Schedule
{
	class MainClass
	{
		public static string Delimiter(){
			string dashed_line = "---------------------------------";
			Console.WriteLine (dashed_line);
			return dashed_line;
		}

		public static string Option1Delimiter(){
			string dashed_line = "--------Toate Intalnirile--------";
			Console.WriteLine (dashed_line);
			return dashed_line;
		}

		public static string Option2Delimiter(){
			string dashed_line = "--Cauta intalnire dupa descriere--";
			Console.WriteLine (dashed_line);
			return dashed_line;
		}

		public static string Option5Delimiter(){
			string dashed_line = "-------Afisarea examenelor-------";
			Console.WriteLine (dashed_line);
			return dashed_line;
		}

		public static int DisplayMenu(){
			int option = 0;

			Delimiter ();
			Console.WriteLine ("PROGRAMARI");
			Console.WriteLine("1. Afiseaza toate programarile");
			Console.WriteLine("2. Cauta intalnire dupa descriere");
			Console.WriteLine("3. Cauta intalnire dupa data");
			Console.WriteLine("4. Introduceti o intalnire noua");

			Delimiter ();
			Console.WriteLine ("PROGRAMARI EXAMENE");
			Console.WriteLine ("5. Afiseaza toate examenele");
			Console.WriteLine ("6. Cauta examenul dupa materie");
			Console.WriteLine ("7. Programati un alt examen");

			Delimiter ();
			Console.WriteLine("8. Iesire din program");
			Delimiter ();

			return option = Convert.ToInt32 (Console.ReadLine ()); 
		}

		public static string SearchDocByText(string file, string input_search){
			StreamReader sr = new StreamReader (file);
			string line = "";
			int var2 = -1;
			Console.Clear();
			while ((line = sr.ReadLine()) != null) {
				int var1 = line.IndexOf(input_search);


				if (var1 != -1) {
					Delimiter ();
					Console.WriteLine (line);
					var2 = var1;
				} 

			}
			if (var2 == -1) {
				Console.WriteLine ("Nu au fost gasite inregistrari cu datele cerute");

			}
			sr.Close();
			return " ";
		}

		public static void InsertNewSchedule (string file, string new_date, string description){
			StreamWriter sw = new StreamWriter(file, true);
			sw.WriteLine (new_date + " " + description);
			sw.Close();

		}

		public static void Main (string[] args)
		{
			int opt = 0;
			string db_file = "schedule.txt"; //schedules records
			string db_file2 = "exams.txt"; // exams records


			while (opt !=8) {
				opt = DisplayMenu ();
				switch (opt) {
				
				case 1:
					Console.Clear ();
					string lines = "";
					Option1Delimiter ();

					StreamReader sr = new StreamReader (db_file);
					while ((lines = sr.ReadLine()) != null) {
						Console.WriteLine (lines);
					}
					Delimiter ();

					Console.WriteLine ();
					Console.WriteLine ("Apasati enter pentru revenire la meniul principal");
					Console.ReadLine ();
					Console.Clear ();
					sr.Close ();
				break;

				case 2:
					string input = "";
					Delimiter ();
					Console.WriteLine ("Scrieti cuvantul de cautare:");
					input = Console.ReadLine ();

					if (input == "") {
						break;
					} else {
						SearchDocByText (db_file, input);
					}

					Delimiter ();

					Console.WriteLine ();
					Console.WriteLine ("Apasati enter pentru revenire la meniul principal");
					Console.ReadLine ();
					Console.Clear ();
				break;

				case 3:
					string input2 = "";
					Delimiter ();
					Console.WriteLine ("Scrieti data la care doriti sa fie afisate programarile:");
					input = Console.ReadLine ();

					if (input == "") {
						break;
					} else {
						SearchDocByText (db_file, input2);
					}

					Delimiter ();

					Console.WriteLine ();
					Console.WriteLine ("Apasati enter pentru revenire la meniul principal");
					Console.ReadLine ();
					Console.Clear ();
				break;

				case 4:
					Console.WriteLine ("Introduceti data pentru noua programarile. (dd.mm.yyyy)");
					string new_date = Console.ReadLine ();

					Console.WriteLine ("Introduceti descrierea pentru noua programare");
					string new_description = Console.ReadLine ();

					InsertNewSchedule (db_file, new_date, new_description);

					Console.WriteLine ();
					Console.WriteLine ("Apasati enter pentru revenire la meniul principal");
					Console.ReadLine ();
					Console.Clear ();
				break;

				case 5:
					Console.Clear ();
					string lines1 = "";
					Option5Delimiter ();

					StreamReader sr1 = new StreamReader (db_file2);
					while ((lines1 = sr1.ReadLine()) != null) {
						Console.WriteLine (lines1);
					}
					Delimiter ();

					Console.WriteLine ();
					Console.WriteLine ("Apasati enter pentru revenire la meniul principal");
					Console.ReadLine ();
					Console.Clear ();
					sr1.Close ();
				break;

				case 6:
					string input6 = "";
					Delimiter ();
					Console.WriteLine ("Scrieti cuvantul de cautare:");
					input6 = Console.ReadLine ();

					if (input6 == "") {
						break;
					} else {
						SearchDocByText (db_file2, input6);
					}

					Delimiter ();

					Console.WriteLine ();
					Console.WriteLine ("Apasati enter pentru revenire la meniul principal");
					Console.ReadLine ();
					Console.Clear ();
				break;

				case 7:

					Console.WriteLine ("Introduceti data pentru noul examen. (dd.mm.yyyy)");
					string new_date1 = Console.ReadLine ();

					Console.WriteLine ("Introduceti disciplina examenului");
					string new_description1 = Console.ReadLine ();

					InsertNewSchedule (db_file2, new_date1, new_description1);

					Console.Clear ();
					string lines2 = "";
					Option5Delimiter ();

					StreamReader sr2 = new StreamReader (db_file2);
					while ((lines2 = sr2.ReadLine()) != null) {
						Console.WriteLine (lines2);
					}
					Delimiter ();

					Console.WriteLine ();
					Console.WriteLine ("Apasati enter pentru revenire la meniul principal");
					Console.ReadLine ();
					Console.Clear ();
					sr2.Close ();

				break;

				case 8:
				break;
				}
			}



		}
	}
}
