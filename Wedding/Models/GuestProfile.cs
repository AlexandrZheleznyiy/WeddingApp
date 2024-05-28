using System.ComponentModel.DataAnnotations;
using Wedding.DTOs;
using Wedding.Models.Enums;

namespace Wedding.Models
{
    public class GuestProfile
    {
        [Key]
        public int Id { get; set; }
        public string? ActionGuest { get; set; } = "Посещение";
        public GuestActionEnum GuestActionEnum { get; set; }
        public string? DrinkGuest { get; set; } = "Напиток";
        public GuestDrinkEnum GuestDrinkEnum { get; set; }

        public int GuestId { get; set; }
        public Guest? Guest { get; set; }

        public GuestProfile(GuestProfileRequest request)
        {
            GuestDrinkEnum = request.GuestDrinkEnum;
            GuestActionEnum = request.GuestActionEnum;
            GuestId = request.GuestId;
        }

        public GuestProfile()
        {

        }
    }
}
