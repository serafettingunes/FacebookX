using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace facebookX
{
    public partial class faceMaster : System.Web.UI.Page
    {
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanticonfig"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

            cn.Open();
            SqlCommand cmd = new SqlCommand("select*from faceKulGiris where gmail='" + Session["gmail"].ToString() + "'", cn);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Image2.ImageUrl = "~/ikon1/" + dr["ikon1"].ToString();
                Image1.ImageUrl = "~/Banner/" + dr["banner1"].ToString();
            }

            cn.Close();










        }
    }
}