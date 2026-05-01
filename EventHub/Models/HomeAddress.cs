using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    public class HomeAddress
    {
        public int Id { get; set; }
        public Attendee MyAttendee { get; set; }
        public int AttendeeId { get; set; }
        public string Street { get; set; } = string.Empty;
        public string City { get; set; }  =string.Empty;
        public string Country { get; set; } = string.Empty;
        public int PostalCode { get; set; }


    }
}
