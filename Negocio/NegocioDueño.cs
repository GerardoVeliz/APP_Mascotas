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
        public long RegitrarDueño(Dueño dueño) {

            using (AccesoDatos datos = new AccesoDatos())
                try
                {
                    datos.SetearQuery("insert into dueño (nombre,apellido,telefono,mail,direccion,estado) values (@nombre,@apellido,@telefono,@mail,@direccion,@estado)"); 
                    datos.setearParametros("@nombre",dueño.nombre);
                    datos.setearParametros("@apellido", dueño.apellido);
                    datos.setearParametros("@telefono",dueño.telefono);
                    datos.setearParametros("@mail",dueño.mail);
                    datos.setearParametros("@direccion",dueño.direccion);
                    datos.setearParametros("@estado",1);

                    long idUsuario = Convert.ToInt64(datos.ejecutarScalar());



                    return idUsuario;
                }
                catch (Exception ex)
                {

                    throw ex;
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
