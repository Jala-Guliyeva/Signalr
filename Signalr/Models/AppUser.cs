using Microsoft.AspNetCore.Identity;

namespace Signalr.Models
{
    public class AppUser:IdentityUser
    {
        public string Fullname { get; set; }
        public string ConnectionId { get; set; }
    }
}
