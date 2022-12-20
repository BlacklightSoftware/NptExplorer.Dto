using System.Collections.Generic;

namespace NptExplorer.Dto.Models
{
    public class TrailRouteDto : TrailDto
    {
        public List<List<LatLongDto>> Route { get; set; }

        public TrailRouteDto()
        {
            Route = new List<List<LatLongDto>>();
        }
    }
}