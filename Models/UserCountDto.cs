using System;
using System.Collections.Generic;
using System.Text;

#nullable disable
namespace NptExplorer.Dto.Models
{
    public class UserCountDto
    {
        public List<int> Location { get; set; }
        public List<int?> Trail { get; set; }
    }
}
