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
    
    public partial class UserEnt
    {
        public UserEnt()
        {
            this.Bookings = new HashSet<BookingEnt>();
            this.UserVenues = new HashSet<UserVenueEnt>();
        }
    
        public System.Guid Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string token { get; set; }
    
        public virtual ICollection<BookingEnt> Bookings { get; set; }
        public virtual ICollection<UserVenueEnt> UserVenues { get; set; }
    }
}
