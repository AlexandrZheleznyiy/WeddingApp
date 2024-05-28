using System.ComponentModel.DataAnnotations;
using Wedding.DTOs;

namespace Wedding.Models
{
    public class WeddingDay
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? WeddingAddress { get; set; }
        [Required]
        public string? WeddingPlace { get; set; }

        public DateTime? WeddingDate { get; set; }
        public DateTime DateTime { get; set; } = DateTime.UtcNow;
        public TimeSpan TimeSpan { get; set; }



        public WeddingDay(WeddingDayRequest request)
        {
            WeddingAddress = request.WeddingAddress;
            WeddingPlace = request.WeddingPlace;
            WeddingDate = request.WeddingDate;
        }

        public WeddingDay()
        {
            
        }

    }
}
