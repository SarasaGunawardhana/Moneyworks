//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace WebAPI.Models
{
    using System;
    
    public partial class searchCards_Result
    {
        [Key]
        public int bankId { get; set; }
        public string bankName { get; set; }
        public string cardName { get; set; }
        public string imageUrl { get; set; }
        public string logoUrl { get; set; }
        public Nullable<decimal> intRate { get; set; }
        public Nullable<decimal> creditLimit { get; set; }
    }
}
