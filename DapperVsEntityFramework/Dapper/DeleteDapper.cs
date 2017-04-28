using Dapper;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DapperVsEntityFramework.Dapper
{
    public partial class DeleteDapper : Form
    {
        public DeleteDapper()
        {
            InitializeComponent();
        }

        private void DeleteSingleRecord(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Delete;

            var clock = new Stopwatch();
            clock.Start();

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var affectedRows = connection.Execute(sql, new { InvoiceID = 1 });

                clock.Stop();

                My.Result.Show(this, sender, clock, affectedRows);
            }
        }

        private void DeleteMultipleRecords(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Delete;

            var clock = new Stopwatch();
            clock.Start();

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                for (var i = 1; i < My.AppSettings.NbTestItems; i++)
                {
                    var affectedRows = connection.Execute(sql, new {InvoiceID = i});
                }
            }

            clock.Stop();

            My.Result.Show(this, sender, clock, My.AppSettings.NbTestItems);
        }
    }
}
