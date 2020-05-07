using MovieApp.Helpers;
using System;
using System.Linq;

namespace MovieApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var movies = GetMoviesHelper.GetListOfMovies();

            // *Find all movies that their titles starts with "L"

            var moviesTitlesStartingWithL = movies.Where(movie => movie.Title.StartsWith('L')).ToList();

            Console.WriteLine("Movies starting with L are: ");
            moviesTitlesStartingWithL.ForEach(movie => Console.WriteLine(movie.Title));


            //* Find the NUMBER of movies that have rating higher than 7.5

            var ratingHigher = movies.Where(movie => movie.Rating > 7.5).ToList();
            var numberOfMovies = ratingHigher.Count();

            Console.WriteLine("The number of movies with rating higher than 7.5 is: " + numberOfMovies);

            //* Find all movies TITLES with year of production before 2005

            var moviesTitlesBefore2005 = movies.Where(movie => movie.Year < 2005)
                                            .Select(movie => movie.Title).ToList();

            Console.WriteLine("All movie titles with year of production before 2005 are: ");
            moviesTitlesBefore2005.ForEach(title => Console.WriteLine(title));

            //* Find all movies TITLES and RATING that have rating higher then 8.0

            var titlesAndRatingsSpecifiedRating = movies.Where(movie => movie.Rating > 8.0)
                                                        .Select(movie => new { movie.Title, movie.Rating }).ToList();
            Console.WriteLine("The titles and ratings of movies with higher rating than 8.0 are: ");
            titlesAndRatingsSpecifiedRating.ForEach(movie => Console.WriteLine($"Title: {movie.Title} , Rating: {movie.Rating}"));

            //* Find first 5 movies that have duration time longer then 2 hours

            var firstFiveDurationMoreThan2Hours = movies.Where(movie => movie.Duration > 120)
                                                         .Take(5).ToList();
            Console.WriteLine("The first five movies with duration more than 2 hours are: " );
            firstFiveDurationMoreThan2Hours.ForEach(movie => Console.WriteLine(movie.Title));

            //* Find last 3 movies TITLES and DURATION that have duration less then 2 hours

            var last3DurationLessThan2Hours = movies.Where(movie => movie.Duration < 120)
                                                    .TakeLast(3)
                                                    .Select(movie => new { movie.Title, movie.Duration }).ToList();
            Console.WriteLine("The last 3 movie titles and durations with duration less than 2 hours are: ");
            last3DurationLessThan2Hours.ForEach(movie => Console.WriteLine($"Title: {movie.Title} , Duration: {movie.Duration}"));

            //* Find all movies TITLES and RATING and order them by DURATION(DESC) -no condition needed

            var orderMoviesByDuration = movies.OrderByDescending(movie => movie.Duration)
                                                .Select(movie => new { movie.Title, movie.Rating }).ToList();
            Console.WriteLine("Movies titles and ratings ordered by duration(descending)are: ");
            orderMoviesByDuration.ForEach(movie => Console.WriteLine($"Title: {movie.Title}, Rating: {movie.Rating}"));

            //* Find all movies with TITLES that don't start with A and TITLES include more than 7 characters

            var moviesTitleCheck = movies.Where(movie => !movie.Title.StartsWith('A'))
                                            .Where(movie => movie.Title.Length > 7).ToList();
            Console.WriteLine("All movie titles that don't start with A and include more than 7 characters are: ");
            moviesTitleCheck.ForEach(movie => Console.WriteLine(movie.Title));

            //* Find all movies RATINGS that have RATINGS higher than 7.2, DURATIONS less then 1hour and 50min

            var movieRatings = movies.Where(movie => movie.Rating > 7.2 && movie.Duration < 110)
                                    .Select(movie => movie.Rating).ToList();
            Console.WriteLine("All movie ratings higher than 7.2 with duration less than 1 hour 50 min are: ");
            movieRatings.ForEach(rating => Console.WriteLine(rating));

            //*Find all movies TITLES and RATINGS that have TITLES with less than 10 characters, DURATION longer than 2 hours, RATING higher then 6.7 and order them by TITLE(ASC)

            var complexSolution = movies.Where(movie => movie.Title.Length < 10)
                                        .Where(movie => movie.Duration > 120)
                                        .Where(movie => movie.Rating > 6.7)
                                        .OrderBy(movie => movie.Title)
                                        .Select(movie => new { movie.Title, movie.Rating }).ToList();

            Console.WriteLine("All movie titles and ratings that have less than 10 characters, duration longer than 2 hours, rating higher than 6.7, ordered by title are: ");
            complexSolution.ForEach(movie => Console.WriteLine($"Title: {movie.Title}, Rating: {movie.Rating}"));

        }
    }
}
