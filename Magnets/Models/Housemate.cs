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
    
    public partial class Housemate
    {
        public int HousemateID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int HouseHouseID { get; set; }
    
        public virtual House House { get; set; }
    }
}
