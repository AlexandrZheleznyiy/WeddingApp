using Wedding.DTOs;

namespace Wedding.Services
{
    public interface IWeddingService
    {
        Task CreateClothesColour(ClothesColourRequest request);
        Task CreateDatingHistory(DatingHistoryRequest request);
        Task<int> CreateGuest(GuestRequest request);
        Task CreateGuestProfile(GuestProfileRequest request);
        Task CreateTimeTable(TimeTableRequest request);
        Task<int> CreateWeddingDay(WeddingDayRequest request);
    }
}