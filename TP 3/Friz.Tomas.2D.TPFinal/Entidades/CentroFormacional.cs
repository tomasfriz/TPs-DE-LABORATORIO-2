using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Entidades
{
    /// <summary>
    /// Hecho por Tomás Agustín Friz
    /// </summary>
    public class CentroFormacional : Datos
    {
        /// <summary>
        /// Sirve para iniciar sesion, ingresando el usuario y la contraseña atraves de la base de datos.
        /// </summary>
        /// <param name="obje"></param>
        /// <returns></returns>
        public DataTable N_login(Persona obje)
        {
            return D_login(obje);
        }
        /// <summary>
        /// Lista los usuarios atraves de la carga de la base de datos.
        /// </summary>
        /// <returns></returns>
        public DataTable N_listar_usuarios()
        {
            return D_listarusuarios();
        }
        /// <summary>
        /// Busca los usuarios en la base de datos.
        /// </summary>
        /// <param name="obje"></param>
        /// <returns></returns>
        public DataTable N_buscarusuario(Persona obje)
        {
            return D_buscarusuarios(obje);
        }
        /// <summary>
        /// Lista los tipo atraves de la bases de datos.
        /// </summary>
        /// <returns></returns>
        public DataTable N_listar_tipo()
        {
            return D_listatipo();
        }
        /// <summary>
        /// Agrega los datos de los usuarios.
        /// </summary>
        /// <param name="obje"></param>
        /// <returns></returns>
        public String N_mantenimientousuario(Persona obje)
        {
            return D_mantenimientousuarios(obje);
        }
        /// <summary>
        /// Lista los salones atraves de la base de datos.
        /// </summary>
        /// <returns></returns>
        public DataTable N_listar_salon()
        {
            return D_listasalon();
        }
        /// <summary>
        /// Lista los curso atraves de la base de datos.
        /// </summary>
        /// <returns></returns>
        public DataTable N_listar_curso()
        {
            return D_listacurso();
        }
        /// <summary>
        /// Modifica los datos de los salones.
        /// </summary>
        /// <param name="obje"></param>
        /// <returns></returns>
        public String N_mantenimientosalon(Persona obje)
        {
            return D_mantenimientosalon(obje);
        }
        /// <summary>
        /// Agrega los datos de los cursos.
        /// </summary>
        /// <param name="obje"></param>
        /// <returns></returns>
        public String N_mantenimientocurso(Persona obje)
        {
            return D_mantenimientocurso(obje);
        }
        /// <summary>
        /// Muestra el total de los cursos.
        /// </summary>
        /// <returns></returns>
        public DataTable N_totalcurso()
        {
            return D_totalcursos();
        }
        /// <summary>
        /// Muestra el total de los salones.
        /// </summary>
        /// <returns></returns>
        public DataTable N_totalsalones()
        {
            return D_totalsalones();
        }
        /// <summary>
        /// Muestra el total de los alumnos.
        /// </summary>
        /// <returns></returns>
        public DataTable N_totalalumnos()
        {
            return D_totalalumnos();
        }
        /// <summary>
        /// Lista los alumnos atraves de la base de datos.
        /// </summary>
        /// <returns></returns>
        public DataTable N_listaralumnos()
        {
            return D_listar_alumnos();
        }
        /// <summary>
        /// Busca los alumnos en la base de datos.
        /// </summary>
        /// <param name="obje"></param>
        /// <returns></returns>
        public DataTable N_buscaralumnos(Persona obje)
        {
            return D_buscaralumnos(obje);
        }
        /// <summary>
        /// Agrega los datos de los alumnos.
        /// </summary>
        /// <param name="obje"></param>
        /// <returns></returns>
        public String N_mantenimientoalumno(Persona obje)
        {
            return D_mantenimientoalumno(obje);
        }
        /// <summary>
        /// Busca los alumnos por los cursos en la base de datos.
        /// </summary>
        /// <param name="obje"></param>
        /// <returns></returns>
        public DataTable N_buscaralumnosXcurso(Persona obje)
        {
            return D_buscaralumnosXcurso(obje);
        }
        /// <summary>
        /// Busca los alumnos por los salones en la base de datos.
        /// </summary>
        /// <param name="obje"></param>
        /// <returns></returns>
        public DataTable N_buscaralumnosXsalon(Persona obje)
        {
            return D_buscaralumnosXsalon(obje);
        }
    }
}
