//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EAS_DataBase
{
    using System;
    using System.Collections.Generic;
    
    public partial class Course
    {
<<<<<<< HEAD
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Course()
        {
            this.Course_Students = new HashSet<Course_Students>();
            this.Exams = new HashSet<Exam>();
            this.Semester_Courses = new HashSet<Semester_Courses>();
            this.Topics = new HashSet<Topic>();
        }
    
=======
>>>>>>> f0bbe600bddb1581549f1e674c7a777e5f078ec5
        public int Course_ID { get; set; }
        public string Course_Name { get; set; }
        public int Credit_Hours { get; set; }
        public string Course_Description { get; set; }
<<<<<<< HEAD
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Course_Students> Course_Students { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Exam> Exams { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Semester_Courses> Semester_Courses { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Topic> Topics { get; set; }
=======
>>>>>>> f0bbe600bddb1581549f1e674c7a777e5f078ec5
    }
}
