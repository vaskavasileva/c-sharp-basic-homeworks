using MovieApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieApp.Helpers
{
    public class GetMoviesHelper
    {
        public static List<Movie> GetListOfMovies()
        {
            return new List<Movie>()
            {
                new Movie(){ Title = "Joker", Year = 2019, Rating = 8.5f, Duration = 122 },
                new Movie(){ Title = "The Godfather", Year = 1972, Rating = 9.2f, Duration = 175 },
                new Movie(){ Title = "Pulp Fiction", Year = 1994, Rating = 8.9f, Duration = 154 },
                new Movie(){ Title = "Dunkirk", Year = 2017, Rating = 7.9f, Duration = 106 },
                new Movie(){ Title = "Pirates of the Caribbean : The Curse of the Black Pearl", Year = 2003, Rating = 8.0f, Duration = 153 },
                new Movie(){ Title = "Star Trek", Year = 2009, Rating = 7.9f, Duration = 127 },
                new Movie(){ Title = "A Dangerous Method", Year = 2011, Rating = 6.4f, Duration = 99 },
                new Movie(){ Title = "Harry Potter and the Sorcerer's Stone", Year = 2001, Rating = 7.6f, Duration = 152 },
                new Movie(){ Title = "The Silence of the Lambs", Year = 1991, Rating = 8.6f, Duration = 118 },
                new Movie(){ Title = "Leon: The Professional", Year = 1994, Rating = 8.5f, Duration = 110 },
                new Movie(){ Title = "Fantastic Beasts: The Crimes of Grindelwald", Year = 2018, Rating = 6.6f, Duration = 134 },
                new Movie(){ Title = "Hidden Figures", Year = 2016, Rating = 7.8f, Duration = 127 }
            };
        }
    }
}
