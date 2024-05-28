using System.ComponentModel.DataAnnotations;

namespace Wedding.DTOs
{
    public class DatingHistoryRequest
    {
        [MaxLength(300)]
        public string? Description { get; set; }

        public int GuestId { get; set; }

        public DatingHistoryRequest()
        {

        }
    }
}
