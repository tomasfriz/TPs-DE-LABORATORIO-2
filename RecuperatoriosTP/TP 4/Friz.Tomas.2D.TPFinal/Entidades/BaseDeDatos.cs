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
        private static string cadena_conexion;
        private static SqlConnection conexion;
        private static SqlCommand comando;

        /// <summary>
        /// Constructor estatico que inicializa los atributos que voy a utilizar en la base de datos
        /// </summary>
        static BaseDeDatos()
        {
            comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            cadena_conexion = @"Data Source=localhost\SQLEXPRESS;Database=Competencia;Trusted_Connection=True;";
            conexion = new SqlConnection(BaseDeDatos.cadena_conexion);
            comando.Connection = conexion;
        }
        /// <summary>
        /// Trae una lista con todos los juegos de la base de datos
        /// </summary>
        /// <returns></returns>
        public static List<Juego> ObtenerTodos()
        {
            List<Juego> lista = new List<Juego>();

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
            List<Ajedrez> lista = new List<Ajedrez>();

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
            catch (Exception)
            {
                throw;
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
            List<Quemados> lista = new List<Quemados>();

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
            List<Carrera> lista = new List<Carrera>();

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
            bool isOk = true;
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
                    isOk = false;
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
            return isOk;
        }
        /// <summary>
        /// Modifica un juego de la base de datos
        /// </summary>
        /// <param name="juego"></param>
        /// <param name="codigo"></param>
        /// <returns></returns>
        public static bool Modificar(Juego juego, int codigo)
        {
            bool isOk = false;
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
                isOk = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: ", ex);
            }
            finally
            {
                conexion.Close();
            }
            return isOk;
        }
        /// <summary>
        /// Elimina un juego de la base de datos
        /// </summary>
        /// <param name="juego"></param>
        /// <returns></returns>
        public static bool Eliminar(Juego juego)
        {
            bool isOk = false;
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
                isOk = true;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: ", ex);
            }
            finally
            {
                conexion.Close();
            }

            return isOk;
        }
        /// <summary>
        /// Verifica que la conexion con la base de datos se pueda establecer
        /// </summary>
        /// <returns></returns>
        public static bool IsConnected()
        {
            using (SqlConnection connection = new SqlConnection(cadena_conexion))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }
    }
}
