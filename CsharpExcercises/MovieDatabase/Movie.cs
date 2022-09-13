using System;
namespace MovieDatabase
{
	public class Movie
	{

		public Movie(string title, string category)
		{
			Title = title;
			Category = category;
		}

        public string Title { get; set; }
        public string Category { get; set; }
    }
}

