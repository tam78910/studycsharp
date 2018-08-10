using System;
namespace Movie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime PublishDate { get; set; }

        public Genre Genre { get; set; }

        public int GenreId { get; set; }
    }
}