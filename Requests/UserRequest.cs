using System;
using System.Collections.Generic;
using System.Text;

namespace NptExplorer.Dto.Requests
{
    public class UserRequest
    {
        public string UserId { get; set; }
        public string FriendId { get; set; }
        public string Name { get; set; }
    }
}
