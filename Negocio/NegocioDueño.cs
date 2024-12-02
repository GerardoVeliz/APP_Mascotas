using System;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioDueño
    {
        public long RegistrarDueño(Dueño dueño)
        {

            using (AccesoDatos datos = new AccesoDatos())
                try
                {
                    datos.SetearQuery("insert into dueño(idUsuario, nombre, apellido, telefono, mail, direccion, estado) values(@idUsuario, @nombre, @apellido, @telefono, @mail, @direccion, @estado);SELECT SCOPE_IDENTITY();");

                    datos.setearParametros("@idUsuario", dueño.idUsuario);
                    datos.setearParametros("@nombre", dueño.nombre);
                    datos.setearParametros("@apellido", dueño.apellido);
                    datos.setearParametros("@telefono", dueño.telefono);
                    datos.setearParametros("@mail", dueño.mail);
                    datos.setearParametros("@direccion", dueño.direccion);
                    datos.setearParametros("@estado", 1);

                    long idDueño = Convert.ToInt64(datos.ejecutarScalar());



                    return idDueño;
                }
                catch (Exception ex)
                {

                    throw ex;
                }


        }


        public Boolean DueñoRegistrado(int idUsuario) {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetearQuery("select count(*) from dueño where idUsuario = @idUsuario");
                datos.setearParametros("@idUsuario", idUsuario);

                int resultado = Convert.ToInt32(datos.ejecutarScalar());

                if (resultado > 0)
                {
                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {

                datos.CerrarConexion();
            
            
            }
        
        
        
        
        }

        public void modificarDueño(Dueño nuevo) {

            AccesoDatos datos = new AccesoDatos();

            try
            {

                datos.SetearQuery("update dueño set nombre=@nombre , apellido=@apellido , telefono = @telefono , mail=@mail, direccion=@direccion where idDueño=@idDueño" );
                datos.setearParametros("@nombre", nuevo.nombre);
                datos.setearParametros("@apellido", nuevo.apellido);
                datos.setearParametros("@telefono", nuevo.telefono);
                datos.setearParametros("@mail", nuevo.mail);
                datos.setearParametros("@direccion", nuevo.direccion);
                datos.setearParametros("@idDueño", nuevo.id);

                datos.ejecutarAccion();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        
        
        }
    }
}
