using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Magnets.Models
{
    public class Community
    {
        public int CommunityID { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Place { get; set; }
        public virtual ICollection<Member> Members { get; set; }
    }
}