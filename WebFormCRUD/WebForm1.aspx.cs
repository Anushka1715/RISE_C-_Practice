using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebFormCRUD
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection _conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            _conn.Open();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Insert into Student values('"+TextBox1.Text+"','"+TextBox2.Text+"','"+TextBox3.Text+"')",_conn);
            cmd.ExecuteNonQuery();
           _conn.Close();
            Label1.Text = "Data has been inserted";
            GridView1.DataBind();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Update Student set Name = '"+TextBox2.Text+"', age = '"+TextBox3.Text+"' where Id = '"+TextBox1.Text+"'", _conn);
            cmd.ExecuteNonQuery();
            _conn.Close();
            Label1.Text = "Data has been updated";
            GridView1.DataBind();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("Delete from Student where Id = '"+TextBox1.Text+"'", _conn);
            cmd.ExecuteNonQuery();
            _conn.Close();
            Label1.Text = "Data has been deleted";
            GridView1.DataBind();
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
        }
    }
}