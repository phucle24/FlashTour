using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AspNetCoreSpa.Core.Entities
{
    public class TourBookingDetail : IEntityBase{
        [Key]
        public Guid Id {get; set;}
        public int TourId {get; set;}
        public Guid TourBookingId {get; set;}
        public TourBooking TourBooking { get; set; }
        public ICollection<BookingPrice> BookingPrices { get; set; }
    }
}