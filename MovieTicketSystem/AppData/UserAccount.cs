using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketSystem.AppData
{
    public partial class UserAccount
    {
        public UserAccount() { this.UserInformation = new HashSet<UserInformation>(); }

        public string userName { get; set; }
        public string password { get; set; }
        public string userType { get; set; }

        public virtual ICollection<UserInformation> UserInformation { get; set; }

    }
}
