using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Mail;

namespace facebookX
{
    public partial class KayitOl : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["baglanticonfig"].ConnectionString);
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (txtAd.Text != null && txtSoyad.Text != null && txtGmail.Text != null  &&  txtSifre.Text != null && txtSifreTekrar.Text != null && (txtSifre.Text == txtSifreTekrar.Text))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("insert into faceKulGiris values(@gmail,@ad,@soyad,@sifre,@ikon1,@banner1,0)", cn);
                cmd.Parameters.AddWithValue("@gmail", txtGmail.Text);
                cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@soyad", txtSoyad.Text);
                cmd.Parameters.AddWithValue("@sifre", txtSifre.Text);
                cmd.Parameters.AddWithValue("@ikon1",FileUpload1.FileName);
                cmd.Parameters.AddWithValue("@banner1",FileUpload2.FileName);
               
                cmd.ExecuteNonQuery();
                cn.Close();
                 FileUpload1.SaveAs(Server.MapPath("~/ikon1/"+FileUpload1.FileName));
                FileUpload2.SaveAs(Server.MapPath("~/Banner/"+FileUpload2.FileName));
                Image1.ImageUrl = "tik.png";
                lblUyari.Text = "Üyeliğiniz başarıyla oluşturuldu...";
                lblUyari.CssClass = "olumlu";

                //mail işlemi
                Random rnd = new Random();
                long a = rnd.Next(10000000,99999999);
                MailMessage email = new MailMessage();
                string Host = "smtp.gmail.com";
                string smtpUserName = "serafettingunes40@gmail.com";
                string smtpUserSifre = "haRIKA=1071++?";
                email.From=new MailAddress("serafettingunes40@gmail.com");
                int smtpPort = 587;
                email.IsBodyHtml = true;
                email.Subject = "Aktivasyon Şifresi";
                email.Body =a.ToString();
                email.To.Add(new MailAddress(txtGmail.Text.ToLower()));
                email.BodyEncoding = System.Text.Encoding.UTF8;
                SmtpClient smtp = new SmtpClient(Host,smtpPort);
                smtp.Credentials = new System.Net.NetworkCredential(smtpUserName,smtpUserSifre);
                smtp.EnableSsl = true;
                smtp.Send(email);
                Session["aktivasyonn"] = a.ToString();
                Session["gmail"] = txtGmail.Text;
                Response.Redirect("aktivasyon.aspx");
            }
            else
            {
                lblUyari.Text = "Boş alanları doldurunuz veya şifreyi aynı giriniz";
                Image1.ImageUrl = "çarpı.png";
                lblUyari.CssClass = "olumsuz";
            }
        }
    }
}