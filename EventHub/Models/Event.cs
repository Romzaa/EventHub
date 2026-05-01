using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int MaxCapicity { get; set; }
        
        public Organizer MyOrganizer { get; set; }
        [ForeignKey("MyOrganizerId")]
        public int MyOrganizerId { get; set; }



        public ICollection<Session> Sessions { get; set; } = new HashSet<Session>();
        public ICollection<Note> Notes { get; set; } = new HashSet<Note>();

    }
}
