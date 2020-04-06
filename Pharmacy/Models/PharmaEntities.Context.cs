﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pharmacy.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class dbPharmaEntities : DbContext
    {
        public dbPharmaEntities()
            : base("name=dbPharmaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Auth> Auths { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Ledger> Ledgers { get; set; }
        public virtual DbSet<Payment_Mode> Payment_Mode { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<purchase> purchases { get; set; }
        public virtual DbSet<PurchaseInvoice> PurchaseInvoices { get; set; }
        public virtual DbSet<PurchaseLedger> PurchaseLedgers { get; set; }
        public virtual DbSet<Sale> Sales { get; set; }
        public virtual DbSet<SalesInvoice> SalesInvoices { get; set; }
        public virtual DbSet<SalesLedger> SalesLedgers { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<YourTable> YourTables { get; set; }
    
        public virtual ObjectResult<getLedgerByDateRange_Result> getLedgerByDateRange(Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate, Nullable<int> supplierId)
        {
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("startDate", startDate) :
                new ObjectParameter("startDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("endDate", endDate) :
                new ObjectParameter("endDate", typeof(System.DateTime));
    
            var supplierIdParameter = supplierId.HasValue ?
                new ObjectParameter("supplierId", supplierId) :
                new ObjectParameter("supplierId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getLedgerByDateRange_Result>("getLedgerByDateRange", startDateParameter, endDateParameter, supplierIdParameter);
        }
    
        public virtual ObjectResult<getSalesLedgerByDateRange_Result> getSalesLedgerByDateRange(Nullable<System.DateTime> startDate, Nullable<System.DateTime> endDate, Nullable<int> customerId)
        {
            var startDateParameter = startDate.HasValue ?
                new ObjectParameter("startDate", startDate) :
                new ObjectParameter("startDate", typeof(System.DateTime));
    
            var endDateParameter = endDate.HasValue ?
                new ObjectParameter("endDate", endDate) :
                new ObjectParameter("endDate", typeof(System.DateTime));
    
            var customerIdParameter = customerId.HasValue ?
                new ObjectParameter("customerId", customerId) :
                new ObjectParameter("customerId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getSalesLedgerByDateRange_Result>("getSalesLedgerByDateRange", startDateParameter, endDateParameter, customerIdParameter);
        }
    
        public virtual ObjectResult<getAllPurchases_Result> getAllPurchases()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAllPurchases_Result>("getAllPurchases");
        }
    
        public virtual ObjectResult<getAllSales_Result> getAllSales()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<getAllSales_Result>("getAllSales");
        }
    }
}
