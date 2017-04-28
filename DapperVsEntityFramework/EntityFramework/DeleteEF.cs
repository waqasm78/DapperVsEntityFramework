using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DapperVsEntityFramework.EntityFramework
{
    public partial class DeleteEF : Form
    {
        public DeleteEF()
        {
            InitializeComponent();
        }

        private void DeleteSingleRecord(object sender, EventArgs e)
        {
            My.Database.Reset();

            var clock = new Stopwatch();
            clock.Start();

            using (var context = new EntitiesContext())
            {
                var invoice = context.Invoices.FirstOrDefault();

                if (invoice != null) context.Invoices.Remove(invoice);

                context.SaveChanges();
            }

            clock.Stop();

            My.Result.Show(this, sender, clock, 1);
        }

        private void DeleteMultipleRecords(object sender, EventArgs e)
        {
            My.Database.Reset();

            var clock = new Stopwatch();
            clock.Start();

            using (var context = new EntitiesContext())
            {
                for (var i = 1; i < My.AppSettings.NbTestItems; i++)
                {
                    var invoice = context.Invoices.First(x => x.InvoiceId == i);

                    context.Invoices.Remove(invoice);

                    context.SaveChanges();
                }
            }

            clock.Stop();

            My.Result.Show(this, sender, clock, My.AppSettings.NbTestItems);
        }
    }
}
