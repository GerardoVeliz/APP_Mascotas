using System;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Negocio
{
    class NegocioMascota
    {

        public void RegistrarMascota( Mascota mascota, int idDueño ) {

            using (AccesoDatos datos = new AccesoDatos())
            {
                try
                {
                    datos.SetearQuery("insert into mascota (nombre,raza,fechaNacimiento,fotoUrl,estado,idDueño) values (@nombre,@raza,@fechaNacimiento,@fotoUrl,@estado,@idDueño)");
                    datos.setearParametros("@nombre", mascota.nombre); 
                    datos.setearParametros("@raza", mascota.raza);
                    datos.setearParametros("@fechaNaciento", mascota.fechaNacimiento );
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
    }
}
