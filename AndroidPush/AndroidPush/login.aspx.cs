using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void btnIngresar_Click(object sender, EventArgs e)
    {
        String usuario = txtUsuario.Text;
        String contraseña = txtContraseña.Text;
        if (usuario != " " && contraseña != " ")
        {

            if (usuario=="administrador" && contraseña=="muniapp2016")
            {

                Response.Redirect("Default.aspx");

            }
            else
            {
                Response.Write("Usuario y/o Contraseña incorrectos");
            }

        }
        else {
            Response.Write("Debes ingresar los datos");
        }
    }
}