using eCommerceMovieTickets.Data;
using System.ComponentModel.DataAnnotations;

namespace eCommerceMovieTickets.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double Price { get; set; }
        public Cinema CinemaName { get; set; }
        public Actor Actor { get; set; }
        public MovieCategory MovieCategory { get; set; }
        public Producer Producer { get; set; }
        public string ImageURL { get; set; }
    }
}
