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
    public partial class Profesor : System.Web.UI.Page
    {
        

         static string cCon = Coneccion.str();
         MySqlConnection con = new MySqlConnection(cCon);
         static int id_aula;
         string aula;
        protected void Page_Load(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(cCon))
            {
                con.Open();
                //Drop AULA////
                using (var cmd = new MySqlCommand("SELECT nombre FROM aula", con))
                {

                    using (var reader = cmd.ExecuteReader())
                    {

                        DropDownListAula.DataSource = reader;

                        DropDownListAula.DataTextField = "nombre";
                        // DropDownListAula.DataValueField = "id_aula";
                        DropDownListAula.DataBind();

                    }

                    con.Close();
                }

                aula = DropDownListAula.SelectedItem.Text;

            }
        }

        protected void btnIngresarP_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO profesor VALUES(NULL,'" + txtDniP.Text + "','" 
                + txtNombreP.Text + "','" + txtTelefonoP.Text + "','" + id_aula + "')";
            cmd.ExecuteNonQuery();
            con.Close();

        }

        protected void btnActualizarP_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update  `profesor` set `administrativo`.`Telefono` ='" + txtTelefonoP + "' where DocumentoPro='" + txtDniP + "'";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void btnEliminarP_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM `profesor` WHERE `administrativo`.`DocumentoPro` ='" + txtDniP.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();

        }

        protected void btnBuscarP_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM profesor";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1Pro.DataSource = dt;
            GridView1Pro.DataBind();
            con.Close();
        }

        protected void DropDownListAula_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(cCon))
            {
                con.Open();
                //Asocia nombre del aula con su id y lo carga en secretaria////
                using (var cmd = new MySqlCommand("SELECT * FROM aula", con))
                {

                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            if (reader["nombre"].ToString().Equals(aula))
                            {

                                aula = reader["id_aula"].ToString();
                                id_aula = Convert.ToInt32(aula);
                            }

                        }

                    }

                    con.Close();
                }
            }
        }
    }
}