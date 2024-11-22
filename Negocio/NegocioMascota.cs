using System;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Negocio
{
    public class NegocioMascota
    {

        public void RegistrarMascota( Mascota mascota, int idDueño ) {

            using (AccesoDatos datos = new AccesoDatos())
            {
                try
                {
                    datos.SetearQuery("insert into mascota (nombre,raza,fechaNacimiento,fotoUrl,estado,idDueño) values (@nombre,@raza,@fechaNacimiento,@fotoUrl,@estado,@idDueño)");
                    datos.setearParametros("@nombre", mascota.nombre); 
                    datos.setearParametros("@raza", mascota.raza);
                    datos.setearParametros("@fechaNacimiento", mascota.fechaNacimiento );
                    datos.setearParametros("@fotoUrl",mascota.urlImagen);
                    datos.setearParametros("@estado", 1);
                    datos.setearParametros("@idDueño", idDueño);
                    datos.ejecutarAccion();




                }

                catch (Exception ex )
                {

                    throw ex ;
                }



            }
        
        }

       

        public void modificarMascota(Mascota nueva) {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("update mascota set nombre=@nombre, raza=@raza,fechaNacimiento=@fechaNacimiento, fotoUrl=@fotoUrl where idMascota = @idMascota ");
                datos.setearParametros("@nombre", nueva.nombre);
                datos.setearParametros("@raza",nueva.raza);
                datos.setearParametros("@fechaNacimiento",nueva.fechaNacimiento);
                datos.setearParametros("@fotoUrl",nueva.urlImagen);

                datos.ejecutarAccion();





            }
            catch (Exception ex)
            {

                throw ex;
            }
        
        
        }

        public List<Mascota> ListarMascotas(int idDueño)
        {
            List<Mascota> Lista = new List<Mascota>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                // Consulta SQL para filtrar por el id del dueño
                datos.SetearQuery("SELECT idMascota, nombre, raza, fechaNacimiento, fotoUrl, estado " +
                  "FROM mascota " +
                  "WHERE idDueño = @idDueño");


                // Parámetro para evitar inyección SQL
                datos.Comando.Parameters.AddWithValue("@idDueño", idDueño);

                datos.EjecutarLectura();

                while (datos.lector.Read())
                {
                    Mascota aux = new Mascota();

                    aux.idMascota = (int)datos.lector["idMascota"];
                    aux.nombre = (string)datos.lector["nombre"];
                    aux.raza = (string)datos.lector["raza"];
                    aux.fechaNacimiento = (DateTime)(datos.lector["fechaNacimiento"] != DBNull.Value
                                          ? (DateTime)datos.lector["fechaNacimiento"]
                                          : (DateTime?)null);
                    aux.urlImagen = datos.lector["fotoUrl"] != DBNull.Value
                                  ? (string)datos.lector["fotoUrl"]
                                  : null;
                    aux.estado = (bool)datos.lector["estado"];

                    Lista.Add(aux);
                }

                return Lista;
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

        public int ObtenerIdDueñoPorUsuario(int idUsuario)
        {
            int idDueño = 0;
            AccesoDatos datos = new AccesoDatos();

            try
            {
                // Consulta SQL con JOIN entre 'usuario' y 'dueño' para obtener 'idDueño'
                datos.SetearQuery("SELECT d.idDueño FROM usuario u " +
                                  "INNER JOIN dueño d ON u.idUsuario = d.idUsuario " +
                                  "WHERE u.idUsuario = @idUsuario");

                // Agregar parámetro para evitar inyección SQL
                datos.Comando.Parameters.AddWithValue("@idUsuario", idUsuario);

                datos.EjecutarLectura();

                if (datos.lector.Read())
                {
                    // Recupera el idDueño de la consulta
                    idDueño = (int)datos.lector["idDueño"];
                }

                return idDueño;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener el idDueño: " + ex.Message);
            }
            finally
            {
                datos.CerrarConexion();
            }
        }



    }
}
