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
    public partial class Alumno : System.Web.UI.Page
    {
        static string cCon = Coneccion.str();


        MySqlConnection con = new MySqlConnection(cCon);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnIngresarAlu_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO alumno VALUES(NULL,'" + txtDniAlu.Text + "','" + txtNombreAlu.Text + "','" + txtTelefonoAlu.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();

        }

        protected void btnActualizarAlu_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update  `alumno` set `alumno`.`Telefono` ='" + txtTelefonoAlu.Text + "' where Documento='" + txtDniAlu.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void btnEliminarAlu_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM `alumno` WHERE `alumno`.`Documento` ='" + txtDniAlu.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void btnBuscarAlu_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Documento as Documento, nombre as Nombre_Apellido, Telefono as Telefono FROM alumno";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1Alu.DataSource = dt;
            GridView1Alu.DataBind();
            con.Close();
        }
    }
}