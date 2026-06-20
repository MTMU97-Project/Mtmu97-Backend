using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtmu97.Domain.Entities
{
    public class EventImage
    {
        public Guid Id { get; set; }

        public Guid EventId { get; set; }

        public string ImageUrl { get; set; } = null!;

        public string PublicId { get; set; } = null!;

        public Event Event { get; set; } = null!;
    }
}
