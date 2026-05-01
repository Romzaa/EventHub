using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    public class Organizer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? CompanyName { get; set; }
        public bool VerifiedStatus { get; set; }

        public ProfilePage Profile { get; set; }
        public int ProfileId { get; set; }

        public ICollection<Event> Events { get; set; } = new HashSet<Event>();
    }

}
