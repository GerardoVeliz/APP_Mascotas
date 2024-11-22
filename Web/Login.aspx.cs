using System;
using Negocio;
using Dominio; 
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed3_Click(object sender, EventArgs e)
        {
            try
            {
                // Inicializa la sesión de intentos si aún no existe
                if (Session["IntentosFallidos"] == null)
                {
                    Session["IntentosFallidos"] = 0;
                }

                // Carga el número actual de intentos
                int intentosFallidos = (int)Session["IntentosFallidos"];

                // Verifica si ya se excedieron los intentos
                if (intentosFallidos >= 3)
                {
                    lblMensaje.Text = "Usuario bloqueado por demasiados intentos fallidos.";
                    return;
                }

                // Realiza el intento de login
                NegocioUsuario dueño = new NegocioUsuario();
                Usuario user = new Usuario
                {
                    nombre = TxtbNombreUsuario.Text,
                    contraseña = txtbContraseña.Text
                };

                // Verifica si el login es exitoso
                if (dueño.Loguear(user))
                {
                    lblMensaje.ForeColor = System.Drawing.Color.Green;
                    lblMensaje.Text = "Inicio de sesión exitoso. ¡Bienvenido!";

                    // Reinicia los intentos fallidos
                    Session["IntentosFallidos"] = 0;

                    // Obtén los datos completos del usuario desde la base de datos
                    Usuario usuarioCompleto = dueño.ObtenerUsuarioPorNombre(user.nombre);

                    // Guarda el usuario en la sesión
                    Session["Usuario"] = usuarioCompleto;

                    // Redirige al usuario a la página principal
                    Response.Redirect("index.aspx");
                }
                else
                {
                    intentosFallidos++;
                    Session["IntentosFallidos"] = intentosFallidos;
                    lblMensaje.Text = $"Error al iniciar sesión. Intentos restantes: {3 - intentosFallidos}";

                    if (intentosFallidos >= 3)
                    {
                        lblMensaje.Text = "Usuario bloqueado por demasiados intentos fallidos.";
                    }
                }
            }
            catch (Exception ex)
            {
                lblMensaje.Text = "Error: " + ex.Message;
            }
        }



    }
}
