using Microsoft.AspNetCore.Mvc;
using Wedding.DTOs;
using Wedding.Services;

namespace Wedding.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeddingController : ControllerBase
    {
        private readonly IWeddingService _service;
        public WeddingController(IWeddingService service) => _service = service;


        [HttpPost("CreateGuest")]
        public async Task<int> CreateGuest(GuestRequest request)
        {
            return await _service.CreateGuest(request);
        }

        [HttpPost("CreateWeddingDay")]
        public async Task<int> CreateWeddingDay(WeddingDayRequest request)
        {
            return await _service.CreateWeddingDay(request);
        }

        [HttpPost("CreateDatingHistory")]
        public async Task CreateDatingHistory(DatingHistoryRequest request)
        {
            await _service.CreateDatingHistory(request);
        }

        [HttpPost("CreateTimeTable")]
        public async Task CreateTimeTable(TimeTableRequest request)
        {
            await _service.CreateTimeTable(request);
        }

        [HttpPost("CreateClothesColour")]
        public async Task CreateClothesColour(ClothesColourRequest request)
        {
            await _service.CreateClothesColour(request);
        }

        [HttpPost("CreateGuestProfile")]
        public async Task CreateGuestProfile(GuestProfileRequest request)
        {
            await _service.CreateGuestProfile(request);
        }






        //[HttpPost("CreateGuest")]
        //public async Task<int> CreateGuest(GuestRequest request)
        //{
        //    WeddingS? weddingS = _service.CreateGuest;
        //    return await weddingS.Invoke(request);
        //}
    }

    delegate Task<int> WeddingS(GuestRequest request);
}
