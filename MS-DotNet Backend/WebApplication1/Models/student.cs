//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class student
    {
        public student()
        {
            this.projectDetails = new HashSet<projectDetail>();
            this.technicals = new HashSet<technical>();
        }
    
        public int studentId { get; set; }
        public string name { get; set; }
        public string dateOfBirth { get; set; }
        public string gender { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
    
        public virtual ICollection<projectDetail> projectDetails { get; set; }
        public virtual ICollection<technical> technicals { get; set; }
    }
}
