using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtmu97.Domain.Entities
{
    public class Teacher
    {
        public Guid Id { get; set; }
        public string FullName { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public int ImagePublicId { get; set; }
        public DateTime BirthDate { get; set; }
        public int Experience { get; set; }
        public string? Motto { get; set; }
        public string Description { get; set; } = null!;
        public double Rating { get; set; } = 0.0;
        public int RatingCount { get; set; } = 0;
        public string Speciality { get; set; } = null!;
    }
}
