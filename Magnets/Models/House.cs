//------------------------------------------------------------------------------
// <auto-generated>
//    Dieser Code wurde aus einer Vorlage generiert.
//
//    Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten Ihrer Anwendung.
//    Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Magnets.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class House
    {
        public House()
        {
            this.Housemates = new HashSet<Housemate>();
        }
    
        public int HouseID { get; set; }
        public string Name { get; set; }
    
        public virtual ICollection<Housemate> Housemates { get; set; }
    }
}
