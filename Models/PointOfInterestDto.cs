namespace NptExplorer.Dto.Models
{
    public class PointOfInterestDto
    {
        public int Id { get; set; }
        public string? NameEnglish { get; set; }
        public string? NameWelsh { get; set; }
        public string? DescriptionEnglish { get; set; }
        public string? DescriptionWelsh { get; set; }
        public string? Image { get; set; }
        public LatLongDto? Position { get; set; }
        public int BadgeId { get; set; }
        public int BadgeTypeId { get; set; }
        public bool Collected { get; set; }
    }
}