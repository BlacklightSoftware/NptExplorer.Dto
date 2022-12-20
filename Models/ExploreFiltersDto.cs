using System.Collections.Generic;

namespace NptExplorer.Dto.Models
{
    public class ExploreFiltersDto
    {
        public IList<int>? FacilitiesFilters { get; set; }
        public IList<int>? ActivitiesFilters { get; set; }
        public int DistancesInMilesFilters { get; set; }
    }
}