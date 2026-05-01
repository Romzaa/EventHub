using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    public class Badge
    {
        public int Id { get; set; }
        public DateTime DateIssued { get; set; }
        public BadgeTier BadgeType { get; set; }
        public int AttendeeId { get; set; }
        public Attendee MyAttendee { get; set; }

    }
}
