using NptExplorer.Dto.Models;

namespace NptExplorer.Dto.Requests
{
    public class LocationRequest
    {
        public bool LocationServicesEnabled { get; set; }
        public string? SearchPhrase { get; set; }
        public int? MaxRecords { get; set; }
        public ExploreFiltersDto Filters { get; set; }
        public LatLongDto? CurrentLocation { get; set; }

        public LocationRequest()
        {
            Filters = new ExploreFiltersDto();
            LocationServicesEnabled = true;
        }
    }
}
