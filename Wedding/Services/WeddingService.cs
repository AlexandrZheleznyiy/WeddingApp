using Wedding.Contexts;
using Wedding.DTOs;
using Wedding.Models;

namespace Wedding.Services
{
    public class WeddingService : IWeddingService
    {
        private readonly WeddingContext _services;
        public WeddingService(WeddingContext services) => _services = services;

        public async Task<int> CreateGuest(GuestRequest request)
        {
            Guest guests = new Guest(request);
            await _services.Guests.AddAsync(guests);
            await _services.SaveChangesAsync();
            return guests.Id;
        }

        public async Task<int> CreateWeddingDay(WeddingDayRequest request)
        {
            WeddingDay weddingDay = new WeddingDay(request);
            await _services.WeddingDays.AddAsync(weddingDay);
            await _services.SaveChangesAsync();
            return weddingDay.Id;
        }

        public async Task CreateDatingHistory(DatingHistoryRequest request)
        {
            DatingHistory datingHistory = new DatingHistory(request);
            await _services.DatingHistories.AddAsync(datingHistory);
            await _services.SaveChangesAsync();
        }

        public async Task CreateTimeTable(TimeTableRequest request)
        {
            TimeTable timeTable = new TimeTable(request);
            await _services.TimeTables.AddAsync(timeTable);
            await _services.SaveChangesAsync();
        }

        public async Task CreateClothesColour(ClothesColourRequest request)
        {
            ClothesColour clothesColour = new ClothesColour(request);
            //if (collour == "красный") clothesColour.ClothesEnum = ClothesColourEnum.Red;
            //if (collour == "синий") clothesColour.ClothesEnum = ClothesColourEnum.Blue;
            //if (collour == "желтый") clothesColour.ClothesEnum = ClothesColourEnum.Yellow;
            //if (collour == "фиолетовый") clothesColour.ClothesEnum = ClothesColourEnum.Violet;
            //if (collour == "черный") clothesColour.ClothesEnum = ClothesColourEnum.Black;
            await _services.ClothesColours.AddAsync(clothesColour);
            await _services.SaveChangesAsync();
        }

        public async Task CreateGuestProfile(GuestProfileRequest request)
        {
            GuestProfile guestProfile = new GuestProfile(request);
            //if (action == "Приду") guestProfile.GuestActionEnum = GuestActionEnum.IWillCome;
            //else guestProfile.GuestActionEnum = GuestActionEnum.IWillNotCome;

            //if (action == "Вино") guestProfile.GuestDrinkEnum = GuestDrinkEnum.Wine;
            //if (action == "Виски") guestProfile.GuestDrinkEnum = GuestDrinkEnum.Whiskey;
            //if (action == "Водка") guestProfile.GuestDrinkEnum = GuestDrinkEnum.Vodka;
            //if (action == "Шампанское") guestProfile.GuestDrinkEnum = GuestDrinkEnum.Champagne;
            //if (action == "Беаркогольное") guestProfile.GuestDrinkEnum = GuestDrinkEnum.SoftDrink;
            await _services.GuestProfiles.AddAsync(guestProfile);
            await _services.SaveChangesAsync();
        }
    }
}
