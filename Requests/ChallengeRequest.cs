using NptExplorer.Dto.Models;

namespace NptExplorer.Dto.Requests
{
    public class ChallengeRequest
    {
        public string? UserId { get; set; }
        public bool LocationServicesEnabled { get; set; }
        public string? SearchPhrase { get; set; }
        public int? MaxRecords { get; set; }
        public FiltersDto Filters { get; set; }
        public LatLongDto? CurrentLocation { get; set; }

        public ChallengeRequest()
        {
            LocationServicesEnabled = true;
            SearchPhrase = string.Empty;
            Filters = new FiltersDto();
        }
    }
}