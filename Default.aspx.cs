using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_9
{
    public partial class Default : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["PlacementDB"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadSummary();
            LoadPlacement();
        }

        private void LoadSummary()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Students", con);
                TotalStudents.Text = cmd.ExecuteScalar().ToString();

                cmd.CommandText = "SELECT COUNT(*) FROM Students WHERE IsPlaced = 1";
                PlacedStudents.Text = cmd.ExecuteScalar().ToString();

                cmd.CommandText = "SELECT COUNT(*) FROM Students WHERE IsPlaced = 0";
                UnplacedStudents.Text = cmd.ExecuteScalar().ToString();

                cmd.CommandText = "SELECT MAX(PackageLPA) FROM Placements";
                HighestPkg.Text = cmd.ExecuteScalar().ToString();

                PlacementPercentageStudents.Text = (Convert.ToInt32(PlacedStudents.Text) * 100.0 / Convert.ToInt32(TotalStudents.Text)).ToString("0.00") + "%";
            }
            
        }

        private void LoadPlacement()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Placements", con);
                da.Fill(dt);
                StudentGrid.DataSource = dt;
                StudentGrid.DataBind();
            }
        }
    }
}