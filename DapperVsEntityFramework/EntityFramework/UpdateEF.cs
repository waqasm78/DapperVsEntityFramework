using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace DapperVsEntityFramework.EntityFramework
{
    public partial class UpdateEF : Form
    {
        public UpdateEF()
        {
            InitializeComponent();
        }

        private void UpdateSingleRecord(object sender, EventArgs e)
        {
            My.Database.Reset();

            var clock = new Stopwatch();
            clock.Start();

            using (var context = new EntitiesContext())
            {
                var invoice = context.Invoices.FirstOrDefault();

                if (invoice != null) invoice.Code = "Single_Update_1";

                context.SaveChanges();
            }

            clock.Stop();

            My.Result.Show(this, sender, clock, 1);
        }

        private void UpdateMultipleRecords(object sender, EventArgs e)
        {
            My.Database.Reset();

            var clock = new Stopwatch();
            clock.Start();

            using (var context = new EntitiesContext())
            {
                for (var i = 1; i < My.AppSettings.NbTestItems; i++)
                {
                    var invoice = context.Invoices.First(x => x.InvoiceId == i);

                    invoice.Code = "Multiple_Update_" + i;

                    context.SaveChanges();
                }
            }

            clock.Stop();

            My.Result.Show(this, sender, clock, My.AppSettings.NbTestItems);
        }
    }
}
