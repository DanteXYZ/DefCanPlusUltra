//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DefCanApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Item
    {
        public int ItemID { get; set; }
        public string Name { get; set; }
        public int StockQty { get; set; }
        public float Cost { get; set; }
        public string Category { get; set; }
        public string PicUrl { get; set; }
        public string AslPicUrl { get; set; }
        public string Audio { get; set; }
    }
}
