//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurant1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class orderDetail
    {
        public int orderDetailId { get; set; }
        public int orderId { get; set; }
        public int ItemId { get; set; }
        public decimal unitPrice { get; set; }
        public decimal discount { get; set; }
        public decimal total { get; set; }
        public decimal quantity { get; set; }
    
        public virtual Order Order { get; set; }
    }
}