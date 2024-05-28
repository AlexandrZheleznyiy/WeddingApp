namespace Wedding.DTOs
{
    public class TimeTableRequest
    {
        public TimeOnly Collecting { get; set; }
        public TimeOnly Ceremony { get; set; }
        public TimeOnly Banquet { get; set; }
        public TimeOnly EndBanquet { get; set; }

        public int WeddingDayId { get; set; }

        public TimeTableRequest()
        {

        }
    }
}
