//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NTPC_SAFETY.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public int EmpID { get; set; }
        public string ProjCode { get; set; }
        public string ProjName { get; set; }
        public string EmpName { get; set; }
        public string Password { get; set; }
        public bool Admin { get; set; }
    
        public virtual Project Project { get; set; }
    }
}