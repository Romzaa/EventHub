using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Models
{
    public class ProfilePage

    {
        public int OrganizerId { get; set; }
        public string Biography { get; set; } = string.Empty;
        public string WebsiteLink { get; set; } = string.Empty;
        public string Logo { get; set; } = string.Empty;

        public Organizer MyOrganizer { get; set; }

    }
}
