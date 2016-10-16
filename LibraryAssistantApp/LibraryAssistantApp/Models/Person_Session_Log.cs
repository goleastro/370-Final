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
    
    public partial class Person_Session_Log
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person_Session_Log()
        {
            this.Document_Access_Log = new HashSet<Document_Access_Log>();
            this.Person_Session_Action_Log = new HashSet<Person_Session_Action_Log>();
        }
    
        public int Session_ID { get; set; }
        public System.DateTime Login_DateTime { get; set; }
        public System.DateTime Logout_DateTime { get; set; }
        public string Person_ID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Document_Access_Log> Document_Access_Log { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Person_Session_Action_Log> Person_Session_Action_Log { get; set; }
        public virtual Registered_Person Registered_Person { get; set; }
    }
}