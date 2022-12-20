using System;
using System.Collections.Generic;
using System.Text;

namespace NptExplorer.Dto.Models
{
    public class LocationDetailsDto
    {
        public int Id { get; set; }
        public string? NameEnglish { get; set; }
        public string? NameWelsh { get; set; }
        public string? DescriptionEnglish { get; set; }
        public string? DescriptionWelsh { get; set; }
        public string? PrimaryImage { get; set; }
        public string? MapImage { get; set; }
        public string? Type { get; set; }
        public string? Address { get; set; }
        public string? What3Words { get; set; }
        public string? NearestBusStop { get; set; }
        public string? Website { get; set; }
        public string? ResourceLink { get; set; }
        public List<int>? Facilities { get; set; }
        public List<int>? Habitats { get; set; }
        public List<int>? Activites { get; set; }
    }
}
