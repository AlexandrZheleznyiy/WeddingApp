using Wedding.Models.Enums;

namespace Wedding.DTOs
{
    public class GuestProfileRequest
    {
        public GuestActionEnum GuestActionEnum { get; set; }
        public GuestDrinkEnum GuestDrinkEnum { get; set; }

        public int GuestId { get; set; }

        public GuestProfileRequest()
        {

        }
    }
}
