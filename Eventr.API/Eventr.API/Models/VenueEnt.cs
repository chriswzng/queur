//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Eventr.API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class VenueEnt
    {
        public VenueEnt()
        {
            this.Bookings = new HashSet<BookingEnt>();
            this.Media = new HashSet<MediumEnt>();
            this.UserVenues = new HashSet<UserVenueEnt>();
        }
    
        public System.Guid Id { get; set; }
        public string Location { get; set; }
        public Nullable<int> MinPax { get; set; }
        public Nullable<int> MaxPax { get; set; }
        public Nullable<decimal> Cost { get; set; }
        public Nullable<System.DateTime> startDate { get; set; }
        public Nullable<System.DateTime> endDate { get; set; }
        public Nullable<System.TimeSpan> startTime { get; set; }
        public Nullable<System.TimeSpan> endTime { get; set; }
        public Nullable<bool> IsFullDay { get; set; }
        public Nullable<bool> IsSupportWeekDay { get; set; }
        public Nullable<bool> IsSupportWeekEnd { get; set; }
    
        public virtual ICollection<BookingEnt> Bookings { get; set; }
        public virtual ICollection<MediumEnt> Media { get; set; }
        public virtual ICollection<UserVenueEnt> UserVenues { get; set; }
    }
}
