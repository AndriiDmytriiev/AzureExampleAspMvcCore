using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication2.Pages
{
    public class CalcModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public CalcModel(ILogger<IndexModel> logger)
        {
            var connectionString = "Server=tcp:server14235.database.windows.net,1433;Initial Catalog=newdb;Persist Security Info=False;User ID=sa124312;Password=123123Ye$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            using (var conn = new SqlConnection(connectionString))
            {
                var strQuery = "SELECT [Body] FROM [dbo].[Articles] where ID=1";
                conn.Open();
                SqlCommand command1 = new SqlCommand(strQuery, conn);
                var cmdSelectFromProduct = command1.ExecuteScalar();

                System.Data.DataTable table = new System.Data.DataTable();




                SqlDataReader dr = command1.ExecuteReader();
                //cmbRefCpv.Items.Add("All");
                //cmbRefCpv.Text = "All";
                //chkAllRefCpv.Checked = true;

                while (dr.Read())
                {
                    //clbRefCpv.Items.Add(dr["REFERENCED_CPV"].ToString());
                    ViewData["result"] = dr[0].ToString();
                }

                dr.Close();
                conn.Close();
            }
            _logger = logger;
        }

        public void OnGet()
        {
            var connectionString = "Server=tcp:server14235.database.windows.net,1433;Initial Catalog=newdb;Persist Security Info=False;User ID=sa124312;Password=123123Ye$;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            using (var conn = new SqlConnection(connectionString))
            {
                var strQuery = "SELECT [Body] FROM [dbo].[Articles] where ID=1";
                conn.Open();
                SqlCommand command1 = new SqlCommand(strQuery, conn);
                var cmdSelectFromProduct = command1.ExecuteScalar();

                System.Data.DataTable table = new System.Data.DataTable();


                

                SqlDataReader dr = command1.ExecuteReader();
                //cmbRefCpv.Items.Add("All");
                //cmbRefCpv.Text = "All";
                //chkAllRefCpv.Checked = true;

                while (dr.Read())
                {
                    //clbRefCpv.Items.Add(dr["REFERENCED_CPV"].ToString());
                    ViewData["result"] = dr[0].ToString();
                }

                dr.Close();
                conn.Close();
            }
            //ViewData["result"] = "Calculator 1";
        }
    }
}
