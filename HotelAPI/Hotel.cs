using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;

namespace HotelAPI
{
    public class Hotel
    {

        public int HotelId { get; set; }

        public float Rating { get; set; }

        [Required]
        public string HotelName { get; set; }

        [Required]
        public Address Address { get; set; }

        [Required]
        public string Description { get; set; }

        public string PhoneNumber { get; set; }

    }
}
