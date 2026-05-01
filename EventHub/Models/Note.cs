using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    public class Note
    {
        public int Id { get; set; }
        public Attendee MyAttendee { get; set; }
        [ForeignKey("MyAttendee")]
        public int AttendeeId { get; set; }
        public Event MyEvent { get; set; }
        [ForeignKey("MyEvent")]
        public int EventId { get; set; }
        public string ShortNote { get; set; } = string.Empty;

    }
}
