using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace BindAspGridView
{
    public partial class LoadGridView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection("Data Source= MAAQ-HP; Initial Catalog=CloudHRIS_SML;Integrated Security=true");
            //SqlCommand cmd = new SqlCommand("Select * from Emp_Official_Info where Emp_Status ='Live' and unit_Id = 1", con);
            //con.Open();
            //SqlDataReader sdr = cmd.ExecuteReader();
            //GridView1.DataSource = sdr;
            //GridView1.DataBind();
            //con.Close();


            // Or

            // SqlConnection con = new SqlConnection("Data Source= MAAQ-HP; Initial Catalog=CloudHRIS_SML;Integrated Security=true");
            //try
            // {
            //     SqlCommand cmd = new SqlCommand("Select * from Emp_Official_Info where Emp_Status ='Live' and unit_Id = 1", con);
            //     con.Open();
            //     SqlDataReader sdr = cmd.ExecuteReader();
            //     GridView1.DataSource = sdr;
            //     GridView1.DataBind();
            // }
            // catch(Exception ex)
            // {

            // }
            // finally
            // {
            //     con.Close();
            // }

            using (SqlConnection con = new SqlConnection("Data Source= MAAQ-HP; Initial Catalog=CloudHRIS_SML;Integrated Security=true"))
            {
                SqlCommand cmd = new SqlCommand("Select * from Emp_Official_Info where Emp_Status ='Live' and unit_Id = 1", con);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                GridView1.DataSource = sdr;
                GridView1.DataBind();
            }
        }
    }
}