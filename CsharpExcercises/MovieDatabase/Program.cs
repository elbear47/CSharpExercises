
using MovieDatabase;

List<Movie> movies = new List<Movie>()
{
    // add 10 movies
    new Movie("scaryMovie1","Horror"),
    new Movie("funnyMovie1","Comedy"),
    new Movie("LoveMovie1","Romantic"),
    new Movie("ActionMovie1","Action"),
    new Movie("LoveMovie2","Romantic"),
    new Movie("LoveMovie3","Romantic"),
    new Movie("ActionMovie2","Action"),
    new Movie("ActionMovie3","Action"),
    new Movie("scaryMovie2","Horror"),
    new Movie("scaryMovie3","Horror"),
};



Console.WriteLine("Welcome to the movies! ");
Console.WriteLine($"There are {movies.Count} movies in this list");
foreach (Movie m in movies)
{
    Console.WriteLine($"{m.Title} {m.Category}");
}

Console.WriteLine("What category are you interested in?");
string categoryWanted = Console.ReadLine().ToLower();
List<Movie> relevantMovies = movies.Where(x => x.Category.ToLower().Contains(categoryWanted)).ToList();
foreach (var m in relevantMovies)
{
    
    Console.WriteLine(m.Title);
    
}