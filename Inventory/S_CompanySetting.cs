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
    
    public partial class S_CompanySetting
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public byte[] Logo { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Tax { get; set; }
        public string ServiceCharges { get; set; }
        public Nullable<bool> IsMultiCurrency { get; set; }
        public Nullable<bool> IsMultiUnit { get; set; }
        public Nullable<bool> IsMultiBranch { get; set; }
        public Nullable<bool> IsDifProductByBranch { get; set; }
        public Nullable<bool> IsBarcode { get; set; }
        public Nullable<bool> IsProductPhoto { get; set; }
        public Nullable<bool> IsQRcode { get; set; }
        public Nullable<bool> IsProductVariant { get; set; }
        public Nullable<bool> IsBankPayment { get; set; }
        public Nullable<bool> IsProductColor { get; set; }
        public Nullable<bool> IsProductSize { get; set; }
        public Nullable<int> ShopTypeID { get; set; }
    }
}
