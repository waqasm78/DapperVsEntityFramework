using DapperVsEntityFramework.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DapperVsEntityFramework.Dapper;

namespace DapperVsEntityFramework
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
        }

        private void ShowExample_Click(object sender, System.EventArgs e)
        {
            Form form = null;

            switch (((Button)sender).Name)
            {
                // Dapper vs Entity Framework
                case "uiInsertEF":
                    form = new InsertEF();
                    break;

                case "uiUpdateEF":
                    form = new UpdateEF();
                    break;

                case "uiQueryEF":
                    form = new QueryEF();
                    break;

                case "uiDeleteEF":
                    form = new DeleteEF();
                    break;

                case "uiInsertDapper":
                    form = new InsertDapper();
                    break;

                case "uiUpdateDapper":
                    form = new UpdateDapper();
                    break;

                case "uiQueryDapper":
                    form = new QueryDapper();
                    break;

                case "uiDeleteDapper":
                    form = new DeleteDapper();
                    break;

                default:
                    throw new Exception("Invalid Button Name");
            }

            form.StartPosition = FormStartPosition.CenterParent;
            form.ShowDialog();
        }
    }
}
