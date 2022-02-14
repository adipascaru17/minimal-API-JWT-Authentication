using API.Example.Models;
using API.Example.Repositories;

namespace API.Example.Services
{
    public class MovieService : IMovieService
    {

        public Movie Create(Movie movie)
        {
            movie.Id = MovieRepository.Movies.Count + 1;
            MovieRepository.Movies.Add(movie);

            return movie;   
        }

        public Movie Get(int id)
        {
            var movie = MovieRepository.Movies.FirstOrDefault(x => x.Id == id);
            if (movie == null)
            {
                return null;
            }

            return movie;
        }

        public List<Movie> List()
        {
            return MovieRepository.Movies.ToList(); 
        }

        public Movie Update(Movie newMovie)
        {
            var oldMovie = MovieRepository.Movies.FirstOrDefault(x => x.Id == newMovie.Id);
            if (oldMovie == null)
            {
                return null;
            }
            oldMovie.Title = newMovie.Title;
            oldMovie.Description = newMovie.Description;
            oldMovie.Rating= newMovie.Rating;

            return newMovie;
        }

        public bool Delete (int id)
        {
            var oldMovie = MovieRepository.Movies.FirstOrDefault(x => x.Id == id);
            if (oldMovie == null)
            {
                return false;
            }

            MovieRepository.Movies.Remove(oldMovie);

            return true;
        }
    }
}
