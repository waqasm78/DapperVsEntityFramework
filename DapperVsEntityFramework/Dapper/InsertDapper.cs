using Dapper;
using DapperVsEntityFramework._Entity;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DapperVsEntityFramework.Dapper
{
    public partial class InsertDapper : Form
    {
        public InsertDapper()
        {
            InitializeComponent();
        }

        private void InsertSingleRecord(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Insert;

            var clock = new Stopwatch();
            clock.Start();

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var affectedRows = connection.Execute(sql, new { Kind = InvoiceKind.WebInvoice, Code = "Single_Insert_1" });

                clock.Stop();

                My.Result.Show(this, sender, clock, affectedRows);
            }

        }

        private void InsertMultipleRecords(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Insert;

            var clock = new Stopwatch();
            clock.Start();

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                for (var i = 0; i < My.AppSettings.NbTestItems; i++)
                {

                    var affectedRows = connection.Execute(sql,
                        new {Kind = InvoiceKind.WebInvoice, Code = "Invoice_" + i });
                }
            }

            clock.Stop();

            My.Result.Show(this, sender, clock, My.AppSettings.NbTestItems);
        }
    }
}
