using System.Collections.Generic;

namespace NptExplorer.Dto.Models
{
    public class LocationOverviewDto
    {
        public int Id { get; set; }
        public string? NameEnglish { get; set; }
        public string? NameWelsh { get; set; }
        public string? PrimaryImage { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public List<int> Facilities { get; set; }

        public LocationOverviewDto()
        {
            Facilities = new List<int>(); 
        }
    }
}