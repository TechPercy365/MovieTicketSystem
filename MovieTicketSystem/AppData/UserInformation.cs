using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MovieTicketSystem.AppData
{
    public partial class UserInformation
    {
        public int idNum { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int phoneNum { get; set; }
        public string gender { get; set; }
        public string userAcc { get; set; }

        public virtual UserAccount UserAccount { get; set; }
        
    }
}
