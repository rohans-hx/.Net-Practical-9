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
    public partial class Company : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["PlacementDB"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadCompany();
            LoadPlacedStudent();
        }

        private void LoadCompany()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                DataTable dt = new DataTable();

                SqlDataAdapter da = new SqlDataAdapter("SELECT CompanyName, COUNT(*) AS StudentsHired, MIN(PackageLPA) AS MinimumPackage, MAX(PackageLPA) AS HighestPackage, AVG(PackageLPA) AS AveragePackage FROM dbo.Placements GROUP BY CompanyName ORDER BY CompanyName", con);
                da.Fill(dt);
                gvCompanySummary.DataSource = dt;
                gvCompanySummary.DataBind();
            }
        }

        private void LoadPlacedStudent()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT p.PlacementId, s.StudentName, s.Department, p.CompanyName, p.JobRole, p.PackageLPA FROM dbo.Placements p INNER JOIN dbo.Students s ON p.StudentId = s.StudentId ORDER BY p.CompanyName, s.StudentName", con);
                da.Fill(dt);
                gvPlacedStudentDetails.DataSource = dt;
                gvPlacedStudentDetails.DataBind();
            }
        }
    }
}