using System.Collections.Generic;

namespace NptExplorer.Dto.Models
{
    public class ChallengeOverviewDto
    {
        public int LocationId { get; set; }
        public string? LocationNameEnglish { get; set; }
        public string? LocationNameWelsh { get; set; }
        public string? ChallengeImage { get; set; }
        public List<ChallengeBadgeDto> Badges { get; set; }

        public ChallengeOverviewDto()
        {
            Badges = new List<ChallengeBadgeDto>();
        }
    }
}