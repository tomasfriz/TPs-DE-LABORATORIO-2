using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// FRIZ TOMÁS AGUSTÍN
/// </summary>

namespace Entidades
{
    public class BaseDeDatos
    {
        private static readonly string cadena_conexion;
        private static readonly SqlConnection conexion;
        private static readonly SqlCommand comando;

        /// <summary>
        /// Constructor estatico que inicializa los atributos que voy a utilizar en la base de datos
        /// </summary>
        static BaseDeDatos()
        {
            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            cadena_conexion = @"Data Source=localhost\SQLEXPRESS;Database=Competencia;Trusted_Connection=True;";
            conexion = new SqlConnection(cadena_conexion);
            comando.Connection = conexion;
        }
        /// <summary>
        /// Trae una lista con todos los juegos de la base de datos
        /// </summary>
        /// <returns></returns>
        public static List<Juego> ObtenerTodos()
        {
            List<Juego> lista = new();
            try
            {
                conexion.Open();
                comando.CommandText = "SELECT * FROM juegos";
                SqlDataReader sqlDataReader = comando.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    lista.Add(new Juego(int.Parse(sqlDataReader["codigo"].ToString()),
                        (Equipo)Enum.Parse(typeof(Equipo), sqlDataReader["ganador"].ToString()),
                        int.Parse(sqlDataReader["rojos"].ToString()),
                        int.Parse(sqlDataReader["verdes"].ToString()),
                        int.Parse(sqlDataReader["puntos"].ToString()),
                        double.Parse(sqlDataReader["tiempo"].ToString())));
                }
                sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: ", ex);
            }
            finally
            {
                conexion.Close();
            }
            return lista;
        }
        /// <summary>
        /// Trae una lista con todos los ajedrez de la base de datos
        /// </summary>
        /// <returns></returns>
        public static List<Ajedrez> ObtenerAjedrez()
        {
            List<Ajedrez> lista = new();
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"SELECT * FROM juegos WHERE juego = @juego";
                comando.Parameters.AddWithValue("@juego", "Ajedrez");
                SqlDataReader sqlDataReader = comando.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    lista.Add(new Ajedrez(int.Parse(sqlDataReader["codigo"].ToString()),
                        (Equipo)Enum.Parse(typeof(Equipo), sqlDataReader["ganador"].ToString()),
                        int.Parse(sqlDataReader["rojos"].ToString()),
                        int.Parse(sqlDataReader["verdes"].ToString()),
                        int.Parse(sqlDataReader["puntos"].ToString()),
                        double.Parse(sqlDataReader["tiempo"].ToString())));
                }
                sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: ", ex);
            }
            finally
            {
                conexion.Close();
            }
            return lista;
        }
        /// <summary>
        /// Trae una lista con todos los quemados de la base de datos
        /// </summary>
        /// <returns></returns>
        public static List<Quemados> ObtenerQuemados()
        {
            List<Quemados> lista = new();
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"SELECT * FROM juegos WHERE juego = @juego";
                comando.Parameters.AddWithValue("@juego", "Quemados");
                SqlDataReader sqlDataReader = comando.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    lista.Add(new Quemados(int.Parse(sqlDataReader["codigo"].ToString()),
                        (Equipo)Enum.Parse(typeof(Equipo), sqlDataReader["ganador"].ToString()),
                        int.Parse(sqlDataReader["rojos"].ToString()),
                        int.Parse(sqlDataReader["verdes"].ToString()),
                        int.Parse(sqlDataReader["puntos"].ToString()),
                        double.Parse(sqlDataReader["tiempo"].ToString())));
                }
                sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: ", ex);
            }
            finally
            {
                conexion.Close();
            }
            return lista;
        }
        /// <summary>
        /// Trae una lista con todas las carreras de la base de datos
        /// </summary>
        /// <returns></returns>
        public static List<Carrera> ObtenerCarrera()
        {
            List<Carrera> lista = new();
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"SELECT * FROM juegos WHERE juego = @juego";
                comando.Parameters.AddWithValue("@juego", "Carrera");
                SqlDataReader sqlDataReader = comando.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    lista.Add(new Carrera(int.Parse(sqlDataReader["codigo"].ToString()),
                        (Equipo)Enum.Parse(typeof(Equipo), sqlDataReader["ganador"].ToString()),
                        int.Parse(sqlDataReader["rojos"].ToString()),
                        int.Parse(sqlDataReader["verdes"].ToString()),
                        int.Parse(sqlDataReader["puntos"].ToString()),
                        double.Parse(sqlDataReader["tiempo"].ToString())));
                }
                sqlDataReader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: ", ex);
            }
            finally
            {
                conexion.Close();
            }
            return lista;
        }
        /// <summary>
        /// Agrega un juego a la base de datos
        /// </summary>
        /// <param name="juego"></param>
        /// <param name="tipo"></param>
        /// <returns></returns>
        public static bool Agregar(Juego juego, string tipo)
        {
            bool estado = true;
            try
            {
                comando.Parameters.Clear();
                string sql = "INSERT INTO juegos (juego, rojos, verdes, puntos, tiempo, ganador) VALUES(@juego, @rojos, @verdes, @puntos, @tiempo, @ganador)";
                comando.Parameters.AddWithValue("@codigo", juego.Codigo);
                comando.Parameters.AddWithValue("@tiempo", juego.Minutos);
                comando.Parameters.AddWithValue("@juego", tipo);
                comando.Parameters.AddWithValue("@rojos", juego.ParticipantesRojos);
                comando.Parameters.AddWithValue("@verdes", juego.ParticipantesVerdes);
                comando.Parameters.AddWithValue("@puntos", juego.Puntos);
                comando.Parameters.AddWithValue("@ganador", juego.Ganador.ToString());
                comando.CommandText = sql;
                comando.Connection = conexion;
                conexion.Open();
                int filasAfectadas = comando.ExecuteNonQuery();
                if (filasAfectadas == 0)
                {
                    estado = false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: ", ex);
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                {
                    conexion.Close();
                }
            }
            return estado;
        }
        /// <summary>
        /// Modifica un juego de la base de datos
        /// </summary>
        /// <param name="juego"></param>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public static bool Modificar(Juego juego, int codigo)
        {
            bool estado = false;
            try
            {
                comando.Parameters.Clear();
                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }
                comando.CommandText = $"UPDATE juegos SET rojos = @rojos , verdes = @verdes , puntos = @puntos , ganador = @ganador , tiempo = @tiempo WHERE codigo = @codigo";
                comando.Parameters.AddWithValue("@codigo", codigo);
                comando.Parameters.AddWithValue("@tiempo", juego.Minutos);
                comando.Parameters.AddWithValue("@rojos", juego.ParticipantesRojos);
                comando.Parameters.AddWithValue("@verdes", juego.ParticipantesVerdes);
                comando.Parameters.AddWithValue("@puntos", juego.Puntos);
                comando.Parameters.AddWithValue("@ganador", juego.Ganador.ToString());
                comando.ExecuteNonQuery();
                estado = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: ", ex);
            }
            finally
            {
                conexion.Close();
            }
            return estado;
        }
        /// <summary>
        /// Elimina un juego de la base de datos
        /// </summary>
        /// <param name="juego"></param>
        /// <returns></returns>
        public static bool Eliminar(Juego juego)
        {
            bool estado = false;
            try
            {
                comando.Parameters.Clear();
                if (conexion.State != System.Data.ConnectionState.Open)
                {
                    conexion.Open();
                }
                comando.CommandText = $"DELETE FROM juegos WHERE codigo = @codigo";
                comando.Parameters.AddWithValue("@codigo", juego.Codigo);
                comando.ExecuteNonQuery();
                estado = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: ", ex);
            }
            finally
            {
                conexion.Close();
            }
            return estado;
        }
        /// <summary>
        /// Verifica que la conexion con la base de datos se pueda establecer
        /// </summary>
        /// <returns></returns>
        public static bool Conectado()
        {
            using SqlConnection conexion = new(cadena_conexion);
            try
            {
                conexion.Open();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
    }
}
