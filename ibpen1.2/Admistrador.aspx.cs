using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;

namespace ibpen1._2
{
    public partial class CopiaMaster : System.Web.UI.Page
    {
// nnn

        static string cCon = Coneccion.str();
        static int id_aula;
        string aula;
        MySqlConnection con = new MySqlConnection(cCon);
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

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnIngresarA_Click(object sender, EventArgs e)
        {

            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;  
            
            cmd.CommandText = "INSERT INTO administrativo (`id_secretaria`, `Documento`, `Apellido`, `Telefono`, `id_aula`)" +
                " VALUES(NUll, '" + txtDni.Text + "', '" + txtNombre.Text + "','" + txtTelefono.Text + "','" + id_aula + "')";
            cmd.ExecuteNonQuery();
            con.Close();
        
        }

        protected void btnEliminarA_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM `administrativo` WHERE `administrativo`.`Documento` ='"+txtDni.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();
           
        }

        protected void btnActualizarA_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update  `administrativo` set `administrativo`.`Telefono` ='" + txtNombre.Text + "' where Documento='"+txtDni.Text+"'";
            cmd.ExecuteNonQuery();
            con.Close();

        }

        protected void btnBuscarA_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM administrativo";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1Admin.DataSource = dt;
            GridView1Admin.DataBind();
            con.Close();

        }
        /////////////////////////////PROFESOR///////////////////////////////
        protected void btnIngresarP_Click(object sender, EventArgs e)
        {
            
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "INSERT INTO profesor VALUES('" + txtProDoc.Text + "','" + txtProNom.Text + "','" + txtProTel.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
        }

        protected void btnEliminarP_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "DELETE FROM `profesor` WHERE `administrativo`.`Documento` ='" + txtProDoc.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();

        }

        protected void btnActualizarP_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Update  `profesor` set `administrativo`.`Telefono` ='" + txtProTel.Text + "' where Documento='" + txtProDoc.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();

        }

        protected void btnBuscarP_Click(object sender, EventArgs e)
        {
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT Documento As DNI, Apellido AS Apellido_Nombre, Telefono AS Telefono FROM administrativo";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1Admin.DataSource = dt;
            GridView1Admin.DataBind();
            con.Close();

        }


        ///FIN DE PROFESOR////////////////////////////////////////////////// 
        protected void GridView1Admin_SelectedIndexChanged(object sender, EventArgs e)
        {
           
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