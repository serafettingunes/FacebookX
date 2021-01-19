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
    public partial class islemler2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanticonfig"].ConnectionString);
        protected void Button1_Click(object sender, EventArgs e)
        {
            FileUpload1.SaveAs(Server.MapPath("~/ikon1/" + FileUpload1.FileName));
            cn.Open();
            SqlCommand cmd = new SqlCommand("update faceKulGiris set ikon1=@ikon1 where gmail='" + Session["gmail"].ToString() + "' ", cn);
            cmd.Parameters.AddWithValue("@ikon1", FileUpload1.FileName);
            cmd.ExecuteNonQuery();
            cn.Close();
        }
    }
}