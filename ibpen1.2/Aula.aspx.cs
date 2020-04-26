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
    public partial class Aula : System.Web.UI.Page
    {
         static string cCon = Coneccion.str();


        MySqlConnection con = new MySqlConnection(cCon);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresarAu_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO aula VALUES(NULL,'" + txtNumero.Text + "','" + txtDireccion.Text + "','" + txtTelefonoAu.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void btnActualizarAu_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update  `aula` set `aula`.`Telefono` ='" + txtTelefonoAu.Text + "' where Documento='" + txtNumero + "'";
            cmd.ExecuteNonQuery();
            con.Close();

        }

        protected void btnEliminarAu_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM `aula` WHERE `administrativo`.`Documento` ='" + txtNumero + "'";
            cmd.ExecuteNonQuery();
            con.Close();

        }

        protected void btnBuscarAu_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM aula";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1Au.DataSource = dt;
            GridView1Au.DataBind();
            con.Close();

        }
    }
}