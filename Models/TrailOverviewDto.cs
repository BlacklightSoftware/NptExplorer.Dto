using System;
using System.Collections.Generic;
using System.Text;

#nullable disable
namespace NptExplorer.Dto.Models
{
    public class TrailOverviewDto
    {
        public int Id { get; set; }
        public string NameEnglish { get; set; }
        public string NameWelsh { get; set; }
        public string TrailImage { get; set; }
        public string TrailMapImage { get; set; }
        public int DifficultyId { get; set; }
        public int DistanceId { get; set; }
        public decimal DistanceMiles { get; set; }
        public decimal DistanceKm { get; set; }
        public int TimeId { get; set; }
        public int TimeHours { get; set; }
        public int TimeMinutes { get; set; }
        public decimal? StartLatitude { get; set; }
        public decimal? StartLongitude { get; set; }
        public string TrailRouteApi { get; set; }
        public bool DefaultSelection { get; set; }
        public string StartPointDetailsWelsh { get; set; }
        public string StartPointDetailsEnglish { get; set; }
    }
}
