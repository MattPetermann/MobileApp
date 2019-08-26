using System;

namespace MovieProgram
{
	public class Movie
	{
		public string Name { get; set; }
		public Rating Rating { get; set; }
		public Genre Genre { get; set; }

		public Movie(string n, Rating r, Genre g)
		{
			Name = n;
			Rating = r;
			Genre = g;
		}

		public override bool Equals(Object o)
		{
			if (this == o)
				return true;
			if (!(o is Movie))
				return false;

			var movie = (Movie)o;
			return this.Name == movie.Name &&
					this.Rating == movie.Rating &&
					this.Genre == movie.Genre;
		}

		public override int GetHashCode()
		{
			return this.Name.GetHashCode() + this.Genre.GetHashCode() + this.Rating.GetHashCode();
		}

		public override string ToString()
		{
			return "Movie{" +
					"name='" + this.Name + '\'' +
					", rating=" + this.Rating +
					", genre=" + this.Genre +
					'}';
		}

	}
}
