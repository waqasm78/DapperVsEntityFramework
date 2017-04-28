using DapperVsEntityFramework._Entity;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DapperVsEntityFramework.EntityFramework
{
    public partial class InsertEF : Form
    {
        public InsertEF()
        {
            InitializeComponent();
        }

        private void InsertSingleRecord(object sender, EventArgs e)
        {
            My.Database.Reset();

            var invoice = new Invoice
            {
                Code = "Invoice_" + 1,
                Kind = InvoiceKind.WebInvoice
            };

            var clock = new Stopwatch();
            clock.Start();

            using (var context = new EntitiesContext())
            {
                context.Invoices.Add(invoice);
                context.SaveChanges();

                clock.Stop();

                My.Result.Show(this, sender, clock, 1);
            }
        }

        private void InsertMultipleRecords(object sender, EventArgs e)
        {
            My.Database.Reset();

            var clock = new Stopwatch();
            clock.Start();

            using (var context = new EntitiesContext())
            {
                for (var i = 0; i < My.AppSettings.NbTestItems; i++)
                {
                    var invoice = new Invoice
                    {
                        Code = "Invoice_" + i,
                        Kind = InvoiceKind.WebInvoice
                    };
                    context.Invoices.Add(invoice);
                    context.SaveChanges();
                }
            }
            clock.Stop();

            My.Result.Show(this, sender, clock, My.AppSettings.NbTestItems);
        }
    }
}
