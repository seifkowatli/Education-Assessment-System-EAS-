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
    
    public partial class Question_Answers
    {
        public int Answer_ID { get; set; }
        public int Question_ID { get; set; }
        public string Answer { get; set; }
        public Nullable<bool> is_True { get; set; }
    }
}
