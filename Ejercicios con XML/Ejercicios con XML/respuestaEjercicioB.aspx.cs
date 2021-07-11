using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Ejercicios_con_XML
{
    public partial class respuestaEjercicioB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["apellido"]!=null)
            {
                lblApellido.Text = Session["apellido"].ToString();
            }

            if (Session["sueldo"] != null)
            {
                int sueldo = Convert.ToInt32(Session["sueldo"].ToString());
                lblSueldo.Text = sueldo.ToString();
                if (sueldo>150000)
                {
                    lblMsg.Text="¡Tiene que pagar ganancias!";
                    lblMsg.Attributes.Add("style", "opacity:1;");
                }
                else
                {
                    lblMsg.Text = "¡NO tiene que pagar ganancias!";
                    lblMsg.Attributes.Add("style", "opacity:1;");
                }
            }
            
        }
    }
}