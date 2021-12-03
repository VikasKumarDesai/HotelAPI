using HotelAPI;
using HotelAPI.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HotelAPITest
{
    [TestClass]
    public class HoteAPITest
    {
        HotelController controller = null;
        [TestMethod]
        public void GetTestCount()
        {
            controller = new HotelController();
            int dataCount = controller.Get().Count;
            Assert.AreEqual(20, dataCount);
        }


        [TestMethod]
        public void GetSpecificRecordTest()
        {
            controller = new HotelController();
            Hotel hotel = controller.Get(1);
            Assert.AreEqual(hotel.HotelId, 1);
            Assert.AreEqual(hotel.HotelName, "Park Plaza Westminster Bridge London");
        }
    }
}