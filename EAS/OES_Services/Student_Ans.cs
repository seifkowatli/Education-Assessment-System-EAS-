//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OES_Services
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student_Ans
    {
        public string STD_Id { get; set; }
        public int Quest_Id { get; set; }
        public int Exam_Id { get; set; }
        public string STD_Ans { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
        public virtual Exam Exam { get; set; }
        public virtual Question Question { get; set; }
    }
}