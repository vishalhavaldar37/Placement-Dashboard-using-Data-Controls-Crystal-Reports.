using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EXP9
{
    public partial class Companies : System.Web.UI.Page
    {
        private readonly string cs = ConfigurationManager
        .ConnectionStrings["ConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCompanies(); LoadPlacements();
            }
        }

        private void LoadCompanies()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT * FROM dbo.Students";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                rptCompanies.DataSource = dt;
                rptCompanies.DataBind();
            }
        }

        private void LoadPlacements()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                string query = "SELECT * FROM dbo.Students";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dlPlacements.DataSource = dt;
                dlPlacements.DataBind();
            }
        }
    }
}
