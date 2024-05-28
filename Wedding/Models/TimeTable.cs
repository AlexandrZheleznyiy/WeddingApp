using System.ComponentModel.DataAnnotations;
using Wedding.DTOs;

namespace Wedding.Models
{
    public class TimeTable
    {
        [Key]
        public int Id { get; set; }
        public TimeOnly Collecting { get; set; }
        public TimeOnly Ceremony { get; set; }
        public TimeOnly Banquet { get; set; }
        public TimeOnly EndBanquet { get; set; }

        public int WeddingDayId { get; set; }
        public WeddingDay? WeddingDay { get; set; }

        public TimeTable(TimeTableRequest request)
        {
           Collecting = request.Collecting;
           Ceremony = request.Ceremony;
           Banquet = request.Banquet; 
           EndBanquet = request.EndBanquet;
           WeddingDayId = request.WeddingDayId;
        }

        public TimeTable()
        {

        }
    }
}
