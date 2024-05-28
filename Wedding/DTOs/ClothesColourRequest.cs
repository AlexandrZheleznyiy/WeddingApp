using Wedding.Models.Enums;

namespace Wedding.DTOs
{
    public class ClothesColourRequest
    {
        public ClothesColourEnum ClothesEnum { get; set; }
        public int GuestId { get; set; }
        public ClothesColourRequest()
        {

        }
    }

   
}
