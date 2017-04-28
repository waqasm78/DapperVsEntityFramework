using DapperVsEntityFramework._Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DapperVsEntityFramework
{
    public static class My
    {
        public static Func<DbConnection> ConnectionFactory = () => new SqlConnection(ConnectionString.Connection);

        static My()
        {
        }

        public static class AppSettings
        {
            public static int NbTestItems = Convert.ToInt32(ConfigurationManager.AppSettings["NbTestItems"]);
        }
        public static class ConnectionString
        {
            public static string Connection = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;
        }

        public static class SqlText
        {
            public static string Invoice_Select = "SELECT * FROM Invoices;";
            public static string Invoice_Select_WithDetail = "SELECT * FROM Invoices AS A INNER JOIN InvoiceDetail AS B ON A.InvoiceID = B.InvoiceID;";
            public static string Invoice_Select_WithItem = "SELECT * FROM Invoices AS A INNER JOIN InvoiceItem AS B ON A.InvoiceID = B.InvoiceID;";
            public static string Invoice_Select_ByKind = "SELECT * FROM Invoices WHERE Kind IN @Kind;";
            public static string Invoice_Select_ByCode = "SELECT * FROM Invoices WHERE Code = @Code;";
            public static string Invoice_Select_ByID = "SELECT * FROM Invoices WHERE InvoiceID = @InvoiceID;";
            public static string Invoice_Select_Then_Item_Select = "SELECT * FROM Invoices; SELECT * FROM InvoiceItem";
            public static string Invoice_Insert = "INSERT INTO Invoices (Kind, Code) Values (@Kind, @Code);";
            public static string Invoice_Update = "UPDATE Invoices SET Code = @Code WHERE InvoiceID = @InvoiceID";
            public static string Invoice_Delete = "DELETE FROM Invoices WHERE InvoiceID = @InvoiceID";
            public static string Proc_Invoice_Insert = "Invoice_Insert";
            public static string Invoice_ThenItem_Select_ByKind = "SELECT * FROM Invoices; SELECT * FROM InvoiceItem";
        }

        public static class Database
        {
            public static void Reset(int count = -1, bool includeDetail = true, bool includeItems = true)
            {
                if (count == -1)
                {
                    count = My.AppSettings.NbTestItems;
                }

                using (var ctx = new EntitiesContext())
                {
                    // ENSURE the database is created
                    {
                        var item = ctx.Invoices.FirstOrDefault();
                    }
                    // RESET
                    {
                        var connection = ctx.Database.Connection;

                        connection.Open();

                        var command = connection.CreateCommand();

                        command.CommandText = @"
-- DELETE all data
DELETE FROM InvoiceItems
DELETE FROM Invoices

-- RESEED Identity
DBCC CHECKIDENT (InvoiceItems, RESEED, 0)
DBCC CHECKIDENT (Invoices, RESEED, 0)
";
                        command.ExecuteNonQuery();

                        connection.Close();
                    }
                }

                using (var context = new EntitiesContext())
                {

                    var list = new List<Invoice>();

                    // ADD new items to INSERT
                    {
                        for (var i = 0; i < My.AppSettings.NbTestItems; i++)
                        {
                            list.Add(new Invoice { Code = "Invoice_" + i, Kind = InvoiceKind.WebInvoice });
                        }
                    }

                    context.Invoices.AddRange(list);
                    context.SaveChanges();
                }

            }
        }

        public static class Result
        {
            public static void Show(Form form, object button, Stopwatch clock, int nbItems)
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("Form: " + form.Text);
                sb.AppendLine("Example: " + ((Button)button).Text);

                if (nbItems != -1)
                {
                    sb.AppendLine("Rows Affected: " + nbItems);
                }

                sb.AppendLine("Elapsed Milliseconds: " + clock.Elapsed.TotalMilliseconds);

                MessageBox.Show(sb.ToString(), @"Result");
            }

            public static void Show(object result1, object result2)
            {
                if (result1 is Invoice && result2 is List<InvoiceItem>)
                {
                    MessageBox.Show(string.Format($"1 returned with {0} InvoiceItem(s)", ((List<InvoiceItem>)result2).Count), @"Result");
                }
                else if (result1 is Stopwatch && result2 is int)
                {
                    MessageBox.Show(string.Format("Row Affecteds: {1}; Time: {0}ms", ((Stopwatch)result1).Elapsed.TotalMilliseconds, result2), @"Result");
                }
                else
                {
                    MessageBox.Show(@"Unknown", @"Result");
                }
            }
        }
    }
}
