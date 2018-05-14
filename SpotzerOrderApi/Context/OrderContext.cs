namespace SpotzerOrderApi.Context
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using SpotzerOrderApi.Models;
    using System.Data.Common;

    public partial class OrderContext : DbContext, IOrderContext
    {
        public OrderContext()
            : base("name=OrderContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<OrderContext, SpotzerOrderApi.Migrations.Configuration>());
        }



        public DbSet<Order> Orders { get; set; }
        public DbSet<LineItem> LineItems { get; set; }
        public DbSet<WebsiteDetails> WebsiteDetails { get; set; }
        public DbSet<AdWordCampaign> AdWordCampaigns { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LineItem>().HasKey(s => s.LineItemID);
            base.OnModelCreating(modelBuilder);

        }
    }
}
