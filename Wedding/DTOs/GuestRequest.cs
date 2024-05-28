using System.ComponentModel.DataAnnotations;

namespace Wedding.DTOs
{
    public class GuestRequest
    {
        [MaxLength(50)]
        public string? NameGuest { get; set; }

        public int WeddingDayId { get; set; }

        public GuestRequest()
        {

        }
    }
}
