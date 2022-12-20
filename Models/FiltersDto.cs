using System.Collections.Generic;

namespace NptExplorer.Dto.Models
{
    public class FiltersDto
    {
        public string? SortBy { get; set; }
        public IList<int>? BadgeFilters { get; set; }
        public IList<int>? DifficultyFilters { get; set; }
        public IList<int>? DistanceFilters { get; set; }
        public IList<int>? HabitatFilters { get; set; }
        public IList<int>? TrailTimeFilters { get; set; }
        public IList<int>? FacilitiesFilters { get; set; }
        public IList<int>? ActivitiesFilters { get; set; }
        public int DistancesInMilesFilters { get; set; }
    }
}