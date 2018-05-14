using SpotzerOrderApi.Models;
using System;
using System.Data.Entity;

namespace SpotzerOrderApi.Context
{
  public  interface IOrderContext : IDisposable
    {
         DbSet<Order> Orders { get;  }
         DbSet<LineItem> LineItems { get; }
         DbSet<WebsiteDetails> WebsiteDetails { get; }
         DbSet<AdWordCampaign> AdWordCampaigns { get;}
        int SaveChanges();


    }
}
