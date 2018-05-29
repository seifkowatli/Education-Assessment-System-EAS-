//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Database
{
    using System;
    using System.Collections.Generic;
    
    public partial class Questions_Bank
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Questions_Bank()
        {
            this.Question_Answers = new HashSet<Question_Answers>();
            this.Student_Answers = new HashSet<Student_Answers>();
            this.Exams = new HashSet<Exam>();
        }
    
        public int Question_ID { get; set; }
        public string Question_Text { get; set; }
        public string Expected_Time { get; set; }
        public Nullable<int> Difficulty_Level { get; set; }
        public Nullable<int> Question_Frequency { get; set; }
        public string Thinking_Skills { get; set; }
        public Nullable<int> Question_Mark { get; set; }
        public Nullable<int> ILO_ID { get; set; }
    
        public virtual ILO ILO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Question_Answers> Question_Answers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Answers> Student_Answers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exam> Exams { get; set; }
    }
}