using System.Collections.Generic;

namespace NptExplorer.Dto.Models
{
    public class ChallengeDto
    {
        public int LocationId { get; set; }
        public string? LocationNameEnglish { get; set; }
        public string? LocationNameWelsh { get; set; }
        public LatLongDto? Position { get; set; }
        public List<PointOfInterestDto> PointsOfInterest { get; set; }

        public ChallengeDto()
        {
            PointsOfInterest = new List<PointOfInterestDto>();
        }
    }
}