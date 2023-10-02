using System;
using System.ComponentModel.DataAnnotations;

namespace MovieList.Models
{
    public class Movie
    {
        public int MovieId { get; set; }

        [Required(ErrorMessage = "The movie name is required.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "The release year is required.")]
        [Range(1900, 2100, ErrorMessage = "Please enter a valid release year.")]
        public int Year { get; set; }

        [Required(ErrorMessage = "The rating is required.")]
        [Range(1, 5, ErrorMessage = "The rating must be between 1 and 5.")]
        public int Rating { get; set; }

        // You can add more properties as needed, such as GenreId, Director, Description, etc.
    }
}
