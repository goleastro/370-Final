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
    
    public partial class Questionnaire_Questions
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Questionnaire_Questions()
        {
            this.Person_Questionnaire_Result = new HashSet<Person_Questionnaire_Result>();
        }
    
        public int Questionnaire_ID { get; set; }
        public int Question_Seq { get; set; }
        public int Display_Order { get; set; }
        public int Answer_Optional_Ind { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Person_Questionnaire_Result> Person_Questionnaire_Result { get; set; }
        public virtual Question_Bank Question_Bank { get; set; }
        public virtual Questionnaire Questionnaire { get; set; }
    }
}