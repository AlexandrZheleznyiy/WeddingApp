using System.ComponentModel.DataAnnotations;

namespace Wedding.DTOs
{
    public class WeddingDayRequest
    {
        [Required]
        public string? WeddingAddress { get; set; }
        [Required]
        public string? WeddingPlace { get; set; }
        public DateTime? WeddingDate { get; set; }
    

        public WeddingDayRequest()
        {

        }
    }
}
