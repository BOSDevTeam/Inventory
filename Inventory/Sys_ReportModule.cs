//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Inventory
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sys_ReportModule
    {
        public int ReportModuleID { get; set; }
        public Nullable<int> MainModuleID { get; set; }
        public string ReportModuleName { get; set; }
        public Nullable<int> SortCode { get; set; }
    
        public virtual Sys_MainModule Sys_MainModule { get; set; }
    }
}
