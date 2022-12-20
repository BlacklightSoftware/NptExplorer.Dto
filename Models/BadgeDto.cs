using System;
using System.Collections.Generic;
using System.Text;

namespace NptExplorer.Dto.Models
{
    public class BadgeDto
    {

        public int Id { get; set; }
        public int LocationId { get; set; }
        public int BadgeTypeId { get; set; }
        public int? PointOfInterestId { get; set; }
        public int? TrailId { get; set; }
        public List<BadgeDto>? Badges { get; set; }
    }
}
