using System;

namespace MovieProgram
{
	class Program
	{
		static void Main(string[] args)
		{
			var movieDb = new MovieDb();
			var moreTasks = true;

			do
			{
				var choice = ConsoleUi.GetChoice();

				switch(choice)
				{
					case Choices.LIST: ConsoleUi.OutputMovies(movieDb.Movies); break;
					case Choices.BYRATING: ConsoleUi.OutputMovies(movieDb.GetAllMoviesByRating(ConsoleUi.GetRating())); break;
					case Choices.BYGENRE: ConsoleUi.OutputMovies(movieDb.GetAllMoviesByGenre(ConsoleUi.GetGenre())); break;
					case Choices.DELETE: Console.WriteLine(movieDb.DeleteMovieByIndex(ConsoleUi.GetMovieToDelete(movieDb.Movies))); break;
					case Choices.EXIT: moreTasks = false; break;
				}
			} while (moreTasks);

			//Pause
			Console.ReadLine();
		}
	}
}
