using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
namespace ibpen1._2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

         }

        protected void btnEntrar_Click(object sender, EventArgs e)
        {
            MySqlCommand com;
            //"datasource=db4free.net;port=3306;username=jorge_peralta;password=alefacumax;database=testeo;old guids=true"
            //"Server=MYSQL5013.site4now.net;Database=db_a47d48_ale;Uid=a47d48_ale;Pwd=YOUR_DB_PASSWORD"
           // string cCon = "Server=db4free.net;port=3306;Database=testeo;Uid=jorge_peralta;Pwd=alefacumax;old guids=true";
           string cCon= "Server=MYSQL5013.site4now.net;Database=db_a47d48_ale;Uid=a47d48_ale;Pwd=V3QmbvAPEMUXwrQ";
            string query = "Select * From persona where nombre ='" + txtUsuario.Text + "' and password ='" + txtPasswor.Text + "';";
           
            MySqlConnection con = new MySqlConnection(cCon);
            con.Open();

            com = new MySqlCommand(query, con);
            com.ExecuteNonQuery();

            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(com);
            da.Fill(dt);
             foreach (DataRow dr in dt.Rows)
            {
                Response.Write("<script>alert('Usuario Correcto.')</script>");
                Response.Redirect("PanelGeneral.aspx");
            }

       

           Label1.Text = "Usuario Invalido";
           con.Close();

                         
            }
        }
    }
  
