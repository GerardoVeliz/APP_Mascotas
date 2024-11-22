using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
     public class Mascota
    {
      public int idMascota {  get; set; }
      public   string nombre { get; set; }
      public   string raza { get; set; }
      public   DateTime fechaNacimiento { get; set; }
      public  bool estado { get; set; }
        public string urlImagen { get; set; }
    }
}
