namespace crud_filmes_api_aspnetcore.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }
        public string MovieSynopsis { get; set; }
        public int MovieReleaseYear { get; set; }
        public bool MovieCurrentlyInTheaters { get; set; }
    }
}