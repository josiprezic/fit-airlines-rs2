//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FitAirlines_API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Reservation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Reservation()
        {
            this.Grades = new HashSet<Grade>();
            this.ReservedSeats = new HashSet<ReservedSeat>();
        }
    
        public int ReservationID { get; set; }
        public System.DateTime ReservationDate { get; set; }
        public double BaseTicketPrice { get; set; }
        public double TotalDiscountPercentage { get; set; }
        public bool IsValid { get; set; }
        public string Notes { get; set; }
    
        public virtual Flight Flight { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grade> Grades { get; set; }
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReservedSeat> ReservedSeats { get; set; }
    }
}
