using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace facebookX
{
    public partial class aktivasyon : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanticonfig"].ConnectionString);
        protected void Button1_Click(object sender, EventArgs e)
        {
           string aktivasyonn= Session["aktivasyonn"].ToString();
            if (aktivasyonn==txtKod.Text)
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("update faceKulGiris set durum=1 where gmail='"+Session["gmail"].ToString()+"'  ", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
                Response.Redirect("GirisYap.aspx");
            }

        }
    }
}