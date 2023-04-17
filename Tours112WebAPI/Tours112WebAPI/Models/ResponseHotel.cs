using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Tours112WebAPI.Entities;

namespace Tours112WebAPI.Models
{
    public class ResponseHotel
    {
        public ResponseHotel(Hotel hotel)
        {
            Id = hotel.Id;
            Name = hotel.Name;
            CountOfStars = (int)hotel.CountOfStars;
            CountryName = hotel.Country.Name;
            HotelImage = hotel.HotelImages.ToList().FirstOrDefault()?.ImageSource;

        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CountOfStars { get; set; }
        public string CountryName { get; set; }
        public byte[] HotelImage { get; set; }
    }
}