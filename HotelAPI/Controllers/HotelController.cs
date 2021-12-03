using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization.Formatters.Binary;

namespace HotelAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]/")]
    public class HotelController : ControllerBase
    {
        private List<Hotel> LoadData()
        {
            List<Hotel> items = new List<Hotel>();
            using (StreamReader r = new StreamReader("DataSource\\HotelData.Json"))
            {
                string json = r.ReadToEnd();
                items = JsonConvert.DeserializeObject<List<Hotel>>(json);
            }
            return items;
        }

        //private readonly IConfiguration _configuration;
        public HotelController()
        {
            //_configuration = configuration;
        }

        [HttpGet(Name = "GetHotels")]
        public List<Hotel> Get()
        {
            return LoadData();
        }


        [HttpGet("{hotelId}", Name = "GetHotelsById")]
        public Hotel Get(int hotelId)
        {
            return (Hotel)LoadData().First(h => h.HotelId == hotelId);
        }
    }
}
