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
    
    public partial class Introduction
    {
        public int IntroductionId { get; set; }
        public Nullable<int> ProgramId { get; set; }
        public Nullable<int> SessionId { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public Nullable<int> FacultyId { get; set; }
        public Nullable<int> UniversityId { get; set; }
        public string DeptContacts { get; set; }
        public string FacultyMembers { get; set; }
        public string Intro { get; set; }
        public string MessageofVc { get; set; }
        public string MessageofChairman { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Program Program { get; set; }
        public virtual University University { get; set; }
    }
}