using System;
using Dominio;
using Negocio;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web
{
    public partial class altaUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                NegocioUsuario usuario = new NegocioUsuario();
                Usuario user = new Usuario();
                user.nombre = txtNombre.Text;
                user.contraseña = txtPass.Text;

                // Verificar si el nombre de usuario ya existe
                if (usuario.ComprobarNombreUsuario(user))
                {
                    lblmsj.Text = "Este nombre de usuario ya está en uso, por favor utilice otro.";
                    return; 
                }

                
                if (usuario.AltaUsuario(user) > 0)
                {
                    lblmsj.Text = "Usuario agregado correctamente!";


                }
                else
                {
                    lblmsj.Text = "Error al registrar, intente nuevamente.";
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}