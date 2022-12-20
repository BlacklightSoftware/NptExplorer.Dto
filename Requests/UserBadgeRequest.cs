namespace NptExplorer.Dto.Requests
{
    public class UserBadgeRequest
    {
        public string? UserId { get; set; }
        public int BadgeId { get; set; }
        public bool CheckedIn { get; set; }
    }
}
