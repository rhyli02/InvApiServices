using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InvApiServices.Models.Context
{
    public class InvDBContext : DbContext
    {


        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //    => options.UseSqlite(@"Data Source=C:\InvDB\InvDB.db");
        public InvDBContext( DbContextOptions options) : base(options)
        {
        }
        public DbSet<ApprovalAssignment> ApprovalAssignments { get; set; }
        public DbSet<ApprovalTransaction> ApprovalTransactions { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<GoodReceipt> GoodReceipts { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<PurchaseOrder> PurchaseOrders { get; set; }
        public DbSet<SalesMasterData> SalesMasterDatas { get; set; }
        public DbSet<SalesMasterDataItem> SalesMasterDataItems { get; set; }
        public DbSet<Shipments> Shipments { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Terms> Terms { get; set; }
    }
}
