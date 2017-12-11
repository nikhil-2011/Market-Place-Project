﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class MarketPlaceDBContext : DbContext
    {
        public MarketPlaceDBContext()
            : base("name=MarketPlaceDBContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<SubCategory> SubCategories { get; set; }
        public virtual DbSet<User> Users { get; set; }
    
        public virtual int usp_GetCartId(ObjectParameter cartid)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_GetCartId", cartid);
        }
    
        public virtual int usp_GetCategoryId(ObjectParameter catid)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_GetCategoryId", catid);
        }
    
        public virtual int usp_GetItemId(ObjectParameter itemid)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_GetItemId", itemid);
        }
    
        public virtual int usp_GetOrderId(ObjectParameter orderid)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_GetOrderId", orderid);
        }
    
        public virtual int usp_GetSubCatId(ObjectParameter subid)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_GetSubCatId", subid);
        }
    
        public virtual int usp_GetUserId(ObjectParameter userid)
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("usp_GetUserId", userid);
        }
    }
}
