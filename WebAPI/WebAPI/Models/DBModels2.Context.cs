﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebAPI.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class moneyworksSearch : DbContext
    {
        public moneyworksSearch()
            : base("name=moneyworksSearch")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<bank> banks { get; set; }
        public virtual DbSet<card> cards { get; set; }
    
        public virtual ObjectResult<GetCards_Result> GetCards()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetCards_Result>("GetCards");
        }
    
        public virtual ObjectResult<searchCards_Result> searchCards(string searchName)
        {
            var searchNameParameter = searchName != null ?
                new ObjectParameter("searchName", searchName) :
                new ObjectParameter("searchName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<searchCards_Result>("searchCards", searchNameParameter);
        }

        public System.Data.Entity.DbSet<WebAPI.Models.GetCards_Result> GetCards_Result { get; set; }

        public System.Data.Entity.DbSet<WebAPI.Models.searchCards_Result> searchCards_Result { get; set; }
    }
}