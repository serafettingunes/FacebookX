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
    public partial class GirisYap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanticonfig"].ConnectionString);
        protected void Button1_Click(object sender, EventArgs e)
        {
           


            cn.Open();
            SqlCommand cmd = new SqlCommand("select*from faceKulGiris where gmail=@gmail and sifre=@sifre and durum=1",cn);
            cmd.Parameters.AddWithValue("@gmail",txtgmail.Text);
            cmd.Parameters.AddWithValue("@sifre",txtSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {

                Session["gmail"] = txtgmail.Text;
                Session["sifre"] = txtSifre.Text;
                
                Session["ikon1"]= dr["ikon1"].ToString();
                Session["banner1"] = dr["banner1"].ToString();
                Response.Redirect("faceMaster.aspx");
            }
            cn.Close();
        }
    }
}