using System;
using Dominio;
using Negocio;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class RegistrarMascota : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }
        protected void calFechaNacimiento_SelectionChanged(object sender, EventArgs e)
        {
            txtFechaNacimiento.Text = calFechaNacimiento.SelectedDate.ToString("yyyy-MM-dd");
        }

        protected void btnSubir_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que se haya seleccionado una imagen
                if (!fuImagen.HasFile)
                {
                    lblMensaje.Text = "Por favor, seleccione una imagen.";
                    return;
                }

                // Guardar la imagen localmente
                string nombreArchivo = Path.GetFileName(fuImagen.PostedFile.FileName);
                string rutaCarpeta = Server.MapPath("~/Imagenes/"); // Carpeta donde se guardarán las imágenes
                string rutaCompleta = Path.Combine(rutaCarpeta, nombreArchivo);

                // Crear la carpeta si no existe
                if (!Directory.Exists(rutaCarpeta))
                {
                    Directory.CreateDirectory(rutaCarpeta);
                }

                fuImagen.SaveAs(rutaCompleta);

                // Crear objeto mascota y llenar los datos
                Mascota nuevaMascota = new Mascota
                {
                    nombre = txtNombre.Text,
                    raza = txtRaza.Text,
                    fechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text),
                    urlImagen = "~/Imagenes/" + nombreArchivo // Guardar ruta relativa en la base de datos
                };

                // ID del dueño (puedes obtenerlo del contexto del usuario logueado)
                int idDueño = 1; // Reemplaza esto con el ID real del dueño

                // Registrar la mascota
                NegocioMascota negocio = new NegocioMascota();
                negocio.RegistrarMascota(nuevaMascota, idDueño);

                lblMensaje.Text = "Mascota registrada correctamente.";
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Ocurrió un error al registrar la mascota: " + ex.Message;
            }
        }


    }
}