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
    
    public partial class T_TranSale
    {
        public int ID { get; set; }
        public int TranID { get; set; }
        public Nullable<int> ProductID { get; set; }
        public Nullable<int> Quantity { get; set; }
        public Nullable<decimal> SalePrice { get; set; }
        public Nullable<decimal> DiscountAmt { get; set; }
        public Nullable<decimal> TotalAmount { get; set; }
        public string Variant { get; set; }
        public Nullable<int> UnitID { get; set; }
    }
}