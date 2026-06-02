namespace Mtmu97.Domain.Entities
{
    public class Slide
    {
        public Guid Id { get; set; }
        public string ImageUrl { get; set; } = null!;
        public int ImagePublicId { get; set; }
        public string Title { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}
