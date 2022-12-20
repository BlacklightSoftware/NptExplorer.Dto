using NptExplorer.Dto.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NptExplorer.Dto.Models
{
    public class CategoryPointsDto
    {
        public int Id { get; set; }
        public int BadgeTypeId { get; set; }
        public int Adventurer { get; set; }
        public int Champion { get; set; }
        public int Hero { get; set; }
        public int Rockstar { get; set; }
        public List<int>? BadgeType { get; set; }
    }
}
