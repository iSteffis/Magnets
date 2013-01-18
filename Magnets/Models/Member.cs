using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Magnets.Models
{
    public class Member
    {
        public int MemberID { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public int CommunityID { get; set; }
        public virtual Community Community { get; set; }
    }
}