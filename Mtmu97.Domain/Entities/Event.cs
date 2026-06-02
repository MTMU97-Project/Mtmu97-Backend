using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtmu97.Domain.Entities
{
    public class Event
    {
        public Guid Id { get; set; }
        public string Title { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public int ImagePublicId { get; set; }
        public DateTime EventDate { get; set; }
        public string Location { get; set; } = null!;

    }
}
