using System.ComponentModel.DataAnnotations;
using Wedding.DTOs;

namespace Wedding.Models
{
    public class Guest
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        public string? NameGuest { get; set; }


        public int WeddingDayId { get; set; }
        public WeddingDay? WeddingDay { get; set; }

        public Guest(GuestRequest request)
        {
            NameGuest = request.NameGuest;
            WeddingDayId = request.WeddingDayId;
        }
        public Guest()
        {

        }
    }
}
