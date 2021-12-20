using System;
using System.ComponentModel.DataAnnotations;
using belt_exam;

namespace belt_exam.Models
{
    public class Rating
    {
        [Key]
        public int RatingId { get; set; }
        public int UserId { get; set; }
        public User RatedBy { get; set; }
        public int TVShowId { get; set; }
        public TVShow ShowRated { get; set; }

        [Required(ErrorMessage = "Please leave a rating")]
        [Range(1, 5, ErrorMessage = "You can only leave between 1 and 5 stars")]
        public double StarRating { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
    }
}