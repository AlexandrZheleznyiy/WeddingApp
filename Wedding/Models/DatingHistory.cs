using System.ComponentModel.DataAnnotations;
using Wedding.DTOs;

namespace Wedding.Models
{
    public class DatingHistory
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(300)]
        public string? Description { get; set; }

        public int GuestId { get; set; }
        public Guest? Guest { get; set; }

        public DatingHistory(DatingHistoryRequest request)
        {
            Description = request.Description;
            GuestId = request.GuestId;
        }
        public DatingHistory()
        {

        }
    }
}
