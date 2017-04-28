using Dapper;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace DapperVsEntityFramework.Dapper
{
    public partial class UpdateDapper : Form
    {
        public UpdateDapper()
        {
            InitializeComponent();
        }

        private void UpdateSingleRecord(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Update;

            var clock = new Stopwatch();
            clock.Start();

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();

                var affectedRows = connection.Execute(sql, new { InvoiceID = 1, Code = "Single_Update_1" });
            }

            clock.Stop();

            My.Result.Show(this, sender, clock, My.AppSettings.NbTestItems);
        }

        private void UpdateMultipleRecords(object sender, EventArgs e)
        {
            My.Database.Reset();

            var sql = My.SqlText.Invoice_Update;

            var clock = new Stopwatch();
            clock.Start();

            using (var connection = My.ConnectionFactory())
            {
                connection.Open();
                for (var i = 0; i < My.AppSettings.NbTestItems; i++)
                {
                    var affectedRows = connection.Execute(sql, new {InvoiceID = i, Code = "Multiple_Update_" + i});
                }
            }

            clock.Stop();

            My.Result.Show(this, sender, clock, My.AppSettings.NbTestItems);
        }
    }
}
