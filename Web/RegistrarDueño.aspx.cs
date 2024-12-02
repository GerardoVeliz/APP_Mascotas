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
    public partial class RegistrarDueño : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Usuario"] == null)
                {
                    Response.Redirect("login.aspx");
                    return;
                }

                Usuario usuario = (Usuario)Session["Usuario"];
                NegocioDueño negocio = new NegocioDueño();
                if (negocio.DueñoRegistrado(usuario.id))
                {
                    panelFormulario.Visible = false;
                    lblRegistrado.Text = "Este usuario ya tiene un dueño registrado.";
                    lblRegistrado.ForeColor= System.Drawing.Color.Red;
                    ScriptManager.RegisterStartupScript(this, GetType(), "redirect",
                        "setTimeout(function() { window.location = 'index.aspx'; }, 3000);", true);
                }
            }


        }

        protected void btnClose_Click(object sender, EventArgs e)
        {
            Response.Redirect("index.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {

            try
            {
                Usuario usuario = (Usuario)Session["Usuario"];
                int idUsuario = usuario.id;
                NegocioDueño negocio = new NegocioDueño();
                Dueño nuevo = new Dueño();
                nuevo.idUsuario = idUsuario;
                nuevo.nombre = txtbNombre.Text;
                nuevo.apellido = txtApellido.Text;
                nuevo.direccion = txtbDireccion.Text;
                nuevo.telefono = Convert.ToInt64(txtbTelefono.Text);
                nuevo.mail = txtbMail.Text;
                nuevo.estado = true;

                long resultado = negocio.RegistrarDueño(nuevo);

                if (resultado > 0)
                {
                  
                    lblmsj.Text = "Registrado Correctamente! ";
                    lblmsj.ForeColor = System.Drawing.Color.Green;

                    // Usar un script para redirigir después de mostrar el mensaje
                    ScriptManager.RegisterStartupScript(this, GetType(), "redirect",
                        "setTimeout(function() { window.location = 'index.aspx'; }, 3000);", true);




                }
                else {

                    lblmsj.Text = "No se pudo registrar, intente nuevamente";
                    lblmsj.ForeColor = System.Drawing.Color.Red;
                }

            

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}