using System;
using System.Collections.Generic;
using System.Text;

#nullable disable

namespace NptExplorer.Dto.Models
{
    public class PointOfInterestOverviewDto
    {
        public int Id { get; set; }
        public string NameEnglish { get; set; }
        public string NameWelsh { get; set; }
        public string Image { get; set; }
        public string DescriptionEnglish { get; set; }
        public string DescriptionWelsh { get; set; }
    }
}
