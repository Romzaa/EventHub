using EventHub.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHub.Configuration
{
    public class AttendeeConfiguration : IEntityTypeConfiguration<Attendee>
    {
        public void Configure(EntityTypeBuilder<Attendee> builder)
        {
            builder.HasOne(a => a.Note).WithOne(n => n.MyAttendee);
            builder.HasOne(a => a.Address).WithOne(a => a.MyAttendee);
            builder.HasOne(a => a.Badge).WithOne(b => b.MyAttendee);
        }
    }
}
