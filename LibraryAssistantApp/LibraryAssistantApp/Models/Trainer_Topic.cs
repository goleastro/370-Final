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
    
    public partial class Trainer_Topic
    {
        public string Person_ID { get; set; }
        public int Topic_Seq { get; set; }
        public int Trainer_Topic_ID { get; set; }
    
        public virtual Registered_Person Registered_Person { get; set; }
        public virtual Topic Topic { get; set; }
    }
}