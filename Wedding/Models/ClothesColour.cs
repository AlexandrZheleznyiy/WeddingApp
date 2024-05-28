using System.ComponentModel.DataAnnotations;
using Wedding.DTOs;
using Wedding.Models.Enums;

namespace Wedding.Models
{
    public class ClothesColour
    {
        [Key]
        public int Id { get; set; }
        public string? ClothesCollor { get; set; } = "Цвет";
        public ClothesColourEnum ClothesEnum { get; set; }


        public int GuestId { get; set; }
        public Guest? Guest { get; set; }

        public ClothesColour(ClothesColourRequest request)
        {
            ClothesEnum = request.ClothesEnum;
            GuestId = request.GuestId;
        }

        public ClothesColour()
        {

        }
    }
}
