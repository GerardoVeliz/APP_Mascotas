using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NegocioUsuario
    {
        public int AltaUsuario(Usuario nuevo)
        {

            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearQuery(
                            "INSERT INTO usuario (nombre, contraseña, estado) " +
                            "VALUES (@nombre, @contraseña, @estado); " +
                            "SELECT SCOPE_IDENTITY();"
                        ); datos.setearParametros("@nombre", nuevo.nombre);
                datos.setearParametros("@contraseña", nuevo.contraseña);
                datos.setearParametros("@estado", 1);
                int idusuario = Convert.ToInt32(datos.ejecutarScalar());

                return idusuario;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void modificarUsuario(Usuario nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearQuery("update usuario set nombre=@nombre,contraseña=@contraseña where idUsuario=@idUsuario");
                datos.setearParametros("@nombre", nuevo.nombre);
                datos.setearParametros("@contraseña", nuevo.contraseña);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }




        }

        public void bajaUsuario(int idUsuario) {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("update usuario set estado = 0 where idUsuario=@idUsuario");
                datos.setearParametros("idUsuario",idUsuario);
                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        
        
        }

        public bool Loguear(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearQuery("SELECT COUNT(*) FROM usuario WHERE nombre = @nombre AND contraseña = @contraseña");
                datos.setearParametros("@nombre", usuario.nombre);
                datos.setearParametros("@contraseña", usuario.contraseña);

                int resultado = Convert.ToInt32(datos.ejecutarScalar());
                return resultado > 0;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar loguear", ex);
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public bool ComprobarNombreUsuario (Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.SetearQuery("SELECT COUNT(*) FROM usuario WHERE nombre = @nombre ");
                datos.setearParametros("@nombre", usuario.nombre);
               

                int resultado = Convert.ToInt32(datos.ejecutarScalar());
                return resultado > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public Usuario ObtenerUsuarioPorNombre(string nombreUsuario)
        {
            AccesoDatos datos = new AccesoDatos();
            Usuario usuario = null;

            try
            {
                // Consulta SQL para obtener el usuario por nombre
                datos.SetearQuery("SELECT idUsuario, nombre, contraseña, estado FROM Usuario WHERE nombre = @nombreUsuario");

                // Parámetro para evitar inyección SQL
                datos.Comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                // Ejecutar lectura
                datos.EjecutarLectura();

                // Si encuentra un resultado, crea el objeto Usuario
                if (datos.lector.Read())
                {
                    usuario = new Usuario
                    {
                        id = (int)datos.lector["idUsuario"],
                        nombre = (string)datos.lector["nombre"],
                        contraseña = (string)datos.lector["contraseña"],
                        Estado = (bool)datos.lector["estado"]
                    };
                }

                return usuario; // Retorna el usuario encontrado o null si no hay resultados
            }
            catch (Exception ex)
            {
                throw ex; // Maneja la excepción según sea necesario
            }
            finally
            {
                datos.CerrarConexion(); // Asegúrate de cerrar la conexión
            }
        }




    }






}