//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MarketPlaceDAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cart
    {
        public string cartid { get; set; }
        public string userid { get; set; }
        public string itemid { get; set; }
        public string itemname { get; set; }
        public Nullable<int> quantity { get; set; }
        public Nullable<decimal> price { get; set; }
    }
}