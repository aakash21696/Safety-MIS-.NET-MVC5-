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
    using System.ComponentModel.DataAnnotations;

    public partial class Report
    {
        public int Id { get; set; }
        public string ProjCode { get; set; }
        public string ProjName { get; set; }

        [DataType(DataType.Date)]
        public System.DateTime LastSubmitDate { get; set; }
        public bool IsThisMonthReport { get; set; }
    
        public virtual Project Project { get; set; }
    }
}