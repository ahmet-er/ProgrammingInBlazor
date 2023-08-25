using BlazorMovies.Shared.Entities;

namespace BlazorMovies.Client.Helpers
{
    public class RepositoryInMemory : IRepository
    {
        public List<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie(){ 
                    Title = "Spider-Man: Far From Home", 
                    ReleaseDate = new DateTime(2019, 7, 2), 
                    Poster = "https://m.media-amazon.com/images/I/91BnGt-Y8UL._AC_UF894,1000_QL80_.jpg" },
                new Movie(){ 
                    Title = "Moana", 
                    ReleaseDate = new DateTime(2016, 11, 23), 
                    Poster ="https://m.media-amazon.com/images/I/A1JOaV3B6fL._AC_UF894,1000_QL80_.jpg" },
                new Movie(){ Title = "Inception", 
                    ReleaseDate = new DateTime(2010, 7, 16), 
                    Poster = "https://m.media-amazon.com/images/I/91Rc8cAmnAL._AC_UF1000,1000_QL80_.jpg" }
            };
        }
    }
}
