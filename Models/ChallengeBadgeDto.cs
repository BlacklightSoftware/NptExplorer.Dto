namespace NptExplorer.Dto.Models
{
    public class ChallengeBadgeDto
    {
        public int BadgeId { get; set; }
        public int BadgeTypeId { get; set; }
        public bool Collected { get; set; }
        public int? PointOfInterestId { get; set; }
        public int? TrailId { get; set; }
    }
}