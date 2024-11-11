using System;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    class NegocioDueño
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
    }
}
