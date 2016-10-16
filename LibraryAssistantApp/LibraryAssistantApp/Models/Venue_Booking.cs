//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryAssistantApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Venue_Booking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Venue_Booking()
        {
            this.Questionnaires = new HashSet<Questionnaire>();
            this.Venue_Booking_Person = new HashSet<Venue_Booking_Person>();
        }
    
        public int Venue_Booking_Seq { get; set; }
        public string Venue_Booking_Name { get; set; }
        public System.DateTime DateTime_From { get; set; }
        public System.DateTime DateTime_To { get; set; }
        public int Send_Email_To_Topic_Person_Ind { get; set; }
        public int Max_Bookings { get; set; }
        public int Exclusive_ind { get; set; }
        public string Description { get; set; }
        public int Booking_Type_Seq { get; set; }
        public string Booking_Status { get; set; }
        public int Venue_ID { get; set; }
        public int Building_Floor_ID { get; set; }
        public int Building_ID { get; set; }
        public int Campus_ID { get; set; }
        public int Topic_Seq { get; set; }
    
        public virtual Booking_Status Booking_Status1 { get; set; }
        public virtual Booking_Type Booking_Type { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Questionnaire> Questionnaires { get; set; }
        public virtual Topic Topic { get; set; }
        public virtual Venue Venue { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venue_Booking_Person> Venue_Booking_Person { get; set; }
    }
}