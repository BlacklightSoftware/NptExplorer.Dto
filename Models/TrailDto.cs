namespace NptExplorer.Dto.Models
{
    public class TrailDto
    {
        public int Id { get; set; }
        public int LocationId { get; set; }
        public string? NameEnglish { get; set; }
        public string? NameWelsh { get; set; }
        public string? LocationNameEnglish { get; set; }
        public string? LocationNameWelsh { get; set; }
        public string? TrailImage { get; set; }
        public string? TrailMapImage { get; set; }
        public int Difficulty { get; set; }
        public decimal DistanceMiles { get; set; }
        public decimal DistanceKm { get; set; }
        public int TimeHours { get; set; }
        public int TimeMinutes { get; set; }
        public LatLongDto? StartingPosition { get; set; }
        public string? StartPointDetailsEnglish { get; set; }
        public string? StartPointDetailsWelsh { get; set; }
        public int BadgeId { get; set; }
        public bool Collected { get; set; }
    }
}
