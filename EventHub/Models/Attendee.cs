using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    public class Attendee
    {
        public int Id { get; set; }
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public HomeAddress Address { get; set; } = new();
        public Badge Badge { get; set; } = new();

        public Note Note { get; set; } = new();
        public DateTime RegistrationDate { get; set; }
    }
}
