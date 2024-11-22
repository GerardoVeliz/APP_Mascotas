using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class MostrarMascota : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarMascotas();
            }
        }

        private void CargarMascotas()
        {
            try
            {
                // Verificar si el usuario está en la sesión
                if (Session["Usuario"] != null)
                {
                    // Obtener el objeto Usuario completo desde la sesión
                    Usuario usuarioEnSesion = (Usuario)Session["Usuario"];

                    // Obtener el idUsuario desde el objeto Usuario
                    int idUsuario = usuarioEnSesion.id;

                    // Obtener el idDueño usando el idUsuario
                    NegocioMascota negocio = new NegocioMascota();
                    int idDueño = negocio.ObtenerIdDueñoPorUsuario(idUsuario);

                    // Pasar el idDueño al método ListarMascotas
                    List<Mascota> listaMascotas = negocio.ListarMascotas(idDueño);

                    // Asignar la lista al Repeater
                    rptMascotas.DataSource = listaMascotas;
                    rptMascotas.DataBind();
                }
                else
                {
                    // Si no hay sesión, redirigir al login
                    Response.Redirect("Login.aspx");
                }
            }
            catch (Exception ex)
            {
                Response.Write($"<script>alert('Error: {ex.Message}');</script>");
            }
        }


    }
}