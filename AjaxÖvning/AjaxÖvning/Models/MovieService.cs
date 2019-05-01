using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AjaxÖvning.Models
{
    public class MovieService
    {
        static int IndexCount = 0;

        List<Movie> movies = new List<Movie>
        { new Movie { ID=1, Name="The green book",Description="En bra film om en musiker i USA"},
          new Movie { ID=2, Name="Nattbus 807",Description="Daniels fav film"},
          new Movie { ID=3, Name="Matrix",Description="Good one, must chek out"}
        };


        public void AddDog(Movie movie)
        {
            movie.ID = IndexCount++;
            movies.Add(movie);

        }
        public Movie GetMovieById(int id)
        {
            return movies.Find(x => x.ID == id);
        }
        public Movie[] GetAllMovies()
        {
            return movies.ToArray();
        }
    }
}
