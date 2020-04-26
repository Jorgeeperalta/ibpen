using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using System.Data;
using System.Diagnostics;
using System.Reflection;

namespace ibpen1._2
{
    public partial class Altas : System.Web.UI.Page
    {
        static string cCon = Coneccion.str();
        string aula;
        string secretaria = "";
        string profesor = "";
        string materia = "";
        string alumno = "";
        string nota = "";
        int id_aula, id_materia;
        protected void Page_Load(object sender, EventArgs e)
        {
           // DropDownListAula.SelectedItem.Text = "--Seleccione--";
           // DropDownListSec.SelectedItem.Text = "--Seleccione--";
           // DropDownListMateria.SelectedItem.Text = "--Seleccione--";
           // DropDownListPro.SelectedItem.Text = "--Seleccione--";
           // alumno = DropDownListAlu.SelectedItem.Text;
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
                            DropDownListAula.DataBind();

                        }

                        con.Close();
                    }

                    aula = DropDownListAula.SelectedItem.Text;
                 
                }
                //Fin Drop AULA//
                //Drop SECRETARIA//
                using (var con = new MySqlConnection(cCon))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand("SELECT * FROM administrativo", con))
                    {

                        using (var reader = cmd.ExecuteReader())
                        {

                            DropDownListSec.DataSource = reader;
                            DropDownListSec.DataTextField = "apellido";
                            DropDownListSec.DataBind();

                        }

                    }
                    con.Close();
                    secretaria = DropDownListSec.SelectedItem.Text;
                    
                }
                //Fin SECRETARIA//
                //Drop PROFESOR//
                using (var con = new MySqlConnection(cCon))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand("SELECT * FROM profesor", con))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {

                            DropDownListPro.DataSource = reader;
                            DropDownListPro.DataTextField = "nombre";
                            DropDownListPro.DataBind();

                        }

                    }
                    con.Close();
                    profesor = DropDownListPro.SelectedItem.Text;
                   
                }
            //FIN PROFESOR//
            //DROP MATERIA//
            using (var con = new MySqlConnection(cCon))
            {
                con.Open();
                //Drop AULA////
                using (var cmd = new MySqlCommand("SELECT nombre FROM mat_todas", con))
                {

                    using (var reader = cmd.ExecuteReader())
                    {

                        DropDownListMateria.DataSource = reader;

                        DropDownListMateria.DataTextField = "nombre";
                        // DropDownListAula.DataValueField = "id_aula";
                        DropDownListMateria.DataBind();

                    }

                    con.Close();
                }

                materia = DropDownListMateria.SelectedItem.Text;

            }
            //FIN MATERIA
            using (var con = new MySqlConnection(cCon))
                {
                    con.Open();
                    using (var cmd = new MySqlCommand("SELECT * FROM alumno", con))
                    {
                        using (var reader = cmd.ExecuteReader())
                        {

                            DropDownListAlu.DataSource = reader;
                            DropDownListAlu.DataTextField = "nombre";
                            DropDownListAlu.DataBind();

                        }

                    }

                    con.Close();
                alumno = DropDownListAlu.SelectedItem.Text;

            }

         
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

        protected void DropDownListSec_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownListPro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownListMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var con = new MySqlConnection(cCon))
            {
                con.Open();
                //Asocia nombre del aula con su id y lo carga en materias////
                using (var cmd = new MySqlCommand("SELECT * FROM mat_todas", con))
                {

                    using (var reader = cmd.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            if (reader["nombre"].ToString().Equals(materia))
                            {

                                materia = reader["id_mat_todas"].ToString();
                                id_materia = Convert.ToInt32(materia);
                            }

                        }

                    }

                    con.Close();
                }
            }
        }

        protected void DropDownListAlu_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void DropDownListNota_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    

        private void DdlViaUtilizada_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

       
        protected void Button1_Click(object sender, EventArgs e)
        {
           
            nota = DropDownListNota.SelectedItem.Text;
            MySqlConnection con = new MySqlConnection(cCon);
            con.Open();
            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
           
            cmd.CommandText = "INSERT INTO `materia` (`id_materia`, `id_mat_todas`, `id_aula`) VALUES(NULL,'" + id_materia + "','" + id_aula + "')";
            cmd.ExecuteNonQuery();
            con.Close();
        
            Session.RemoveAll();
            Session.Abandon();
            Response.Cookies.Add(new HttpCookie("ASP.NET_SessionId", ""));
            Response.AppendHeader("Cache-Control", "no-store");
            Response.Redirect("Altas.aspx");
        }

       
    }
}