using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mtmu97.Domain.Entities
{
    public class Student
    {
        public Guid Id { get; set; }
        public string FullName { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
        public int ImagePublicId { get; set; }
        public string Rank { get; set; } = null!;
        public string Competition { get; set; } = null!;
        public string? Motto { get; set; } 
        public string Description { get; set; } = null!; 
    }
}
