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
    public partial class islemler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanticonfig"].ConnectionString);
        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        public void FileUpload1_DataBinding(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            FileUpload1.SaveAs(Server.MapPath("~/Banner/"+FileUpload1.FileName));
            cn.Open();
            SqlCommand cmd = new SqlCommand("update faceKulGiris set banner1=@banner1 where gmail='"+Session["gmail"].ToString()+"' ", cn);
            cmd.Parameters.AddWithValue("@banner1",FileUpload1.FileName);
            cmd.ExecuteNonQuery();
            cn.Close();

        }
    }
}