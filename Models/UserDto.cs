#nullable disable

using System.Collections.Generic;

namespace NptExplorer.Dto.Models
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public string ExplorerLevel { get; set; }
        public string Points { get; set; }
        public int Position { get; set; }
        public List<ChallengeBadgeDto> Badges { get; set; }
        public List<int> BadgeCollection { get; set; }
        public List<int> Friends { get; set; }
        public bool IsFriend { get; set; }
        public bool ExplorerBoard { get; set; }

        public UserDto()
        {
            Friends = new List<int>();
            Badges = new List<ChallengeBadgeDto>();
        }
    }
}
