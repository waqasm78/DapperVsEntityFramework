using DapperVsEntityFramework._Entity;
using System.Data.Entity;

namespace DapperVsEntityFramework
{
    public class EntitiesContext : DbContext
    {
        public EntitiesContext() : base("Connection")
        {
        }

        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<InvoiceItem> InvoiceItems { get; set; }
    }
}
