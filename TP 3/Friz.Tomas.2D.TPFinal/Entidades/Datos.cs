using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Entidades
{
    /// <summary>
    /// Hecho por Tomás Agustín Friz
    /// </summary>
    public class Datos
    {
        /// <summary>
        /// Conexion de base de datos.
        /// </summary>
        SqlConnection cn = new SqlConnection(@"Data Source = localhost\SQLEXPRESS; Database = DBTeam1; Trusted_Connection = True;");
        
        /// <summary>
        /// Sirve para iniciar sesion, ingresando el usuario y la contraseña atraves de la base de datos.
        /// </summary>
        /// <param name="obje"></param>
        /// <returns></returns>
        public DataTable D_login(Persona obje)
        {
            SqlCommand cmd = new SqlCommand("sp_logueo", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@usuario", obje.usuario);
            cmd.Parameters.AddWithValue("@contraseña", obje.clave);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Lista los usuarios atraves de la carga de la base de datos.
        /// </summary>
        /// <returns></returns>
        public DataTable D_listarusuarios()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_usuarios", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Busca los usuarios en la base de datos.
        /// </summary>
        /// <param name="obje"></param>
        /// <returns></returns>
        public DataTable D_buscarusuarios(Persona obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_usuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", obje.nombre);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Lista los tipo atraves de la bases de datos.
        /// </summary>
        /// <returns></returns>
        public DataTable D_listatipo()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_tipo", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Agrega los datos de los usuarios.
        /// </summary>
        /// <param name="obje"></param>
        /// <returns></returns>
        public String D_mantenimientousuarios(Persona obje)
        {
            String accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_usuario", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_codigo", obje.codigo);
            cmd.Parameters.AddWithValue("@nombre", obje.nombre);
            cmd.Parameters.AddWithValue("@usuario", obje.usuario);
            cmd.Parameters.AddWithValue("@id_tipo", obje.id_tipo);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;
        }
        /// <summary>
        /// Lista los curso atraves de la base de datos.
        /// </summary>
        /// <returns></returns>
        public DataTable D_listacurso()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_cursos", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Agrega los datos de los cursos.
        /// </summary>
        /// <param name="obje"></param>
        /// <returns></returns>
        public String D_mantenimientocurso(Persona obje)
        {
            String accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_cursos", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_cursos", obje.codigo);
            cmd.Parameters.AddWithValue("@curso_nombre", obje.nombre);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;
        }
        /// <summary>
        /// Lista los salones atraves de la base de datos.
        /// </summary>
        /// <returns></returns>
        public DataTable D_listasalon()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_salon", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Modifica los datos de los salones.
        /// </summary>
        /// <param name="obje"></param>
        /// <returns></returns>
        public String D_mantenimientosalon(Persona obje)
        {
            String accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_salon", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_salon", obje.codigo);
            cmd.Parameters.AddWithValue("@salon_nombre", obje.nombre);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;
        }
        /// <summary>
        /// Muestra el total de los alumnos.
        /// </summary>
        /// <returns></returns>
        public DataTable D_totalalumnos()
        {
            SqlCommand cmd = new SqlCommand("sp_total_alumnos", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Muestra el total de los cursos.
        /// </summary>
        /// <returns></returns>
        public DataTable D_totalcursos()
        {
            SqlCommand cmd = new SqlCommand("sp_total_cursos", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Muestra el total de los salones.
        /// </summary>
        /// <returns></returns>
        public DataTable D_totalsalones()
        {
            SqlCommand cmd = new SqlCommand("sp_total_salon", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Lista los alumnos atraves de la base de datos.
        /// </summary>
        /// <returns></returns>
        public DataTable D_listar_alumnos()
        {
            SqlCommand cmd = new SqlCommand("sp_listar_alumnos", cn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Busca los alumnos en la base de datos.
        /// </summary>
        /// <param name="obje"></param>
        /// <returns></returns>
        public DataTable D_buscaralumnos(Persona obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_alumnos", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombre", obje.nombre);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Agrega los datos de los alumnos.
        /// </summary>
        /// <param name="obje"></param>
        /// <returns></returns>
        public String D_mantenimientoalumno(Persona obje)
        {
            String accion = "";
            SqlCommand cmd = new SqlCommand("sp_mantenimiento_alumnos", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_alumno", obje.id_alumno);
            cmd.Parameters.AddWithValue("@nombre", obje.nombre);
            cmd.Parameters.AddWithValue("@telefono", obje.telefono);
            cmd.Parameters.AddWithValue("@matricula", obje.matricula);
            cmd.Parameters.AddWithValue("@id_curso", obje.id_curso);
            cmd.Parameters.AddWithValue("@id_salon", obje.id_salon);
            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obje.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cn.State == ConnectionState.Open) cn.Close();
            cn.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cn.Close();
            return accion;
        }
        /// <summary>
        /// Busca los alumnos por los cursos en la base de datos.
        /// </summary>
        /// <param name="obje"></param>
        /// <returns></returns>
        public DataTable D_buscaralumnosXcurso(Persona obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_alumnos_curso", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_curso", obje.id_cod);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        /// <summary>
        /// Busca los alumnos por los salones en la base de datos.
        /// </summary>
        /// <param name="obje"></param>
        /// <returns></returns>
        public DataTable D_buscaralumnosXsalon(Persona obje)
        {
            SqlCommand cmd = new SqlCommand("sp_buscar_alumnos_salon", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id_salon", obje.id_cod);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
