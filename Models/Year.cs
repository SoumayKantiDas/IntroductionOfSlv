//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntroductionOfSlv.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Year
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Year()
        {
            this.Departments = new HashSet<Department>();
        }
    
        public int YearId { get; set; }
        public string YearName { get; set; }
        public Nullable<int> SessionId { get; set; }
        public Nullable<int> SemisterId { get; set; }
        public Nullable<int> ProgramId { get; set; }
        public Nullable<int> UniversityId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Department> Departments { get; set; }
        public virtual Program Program { get; set; }
        public virtual Semister Semister { get; set; }
        public virtual Session Session { get; set; }
        public virtual University University { get; set; }
    }
}