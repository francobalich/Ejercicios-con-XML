using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Ejercicios_con_XML
{
    public partial class EjercicioA : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void crearXML_Click(object sender, EventArgs e)
        {
            try
            {
                string path = Server.MapPath("Sueldos.xml");
                XmlTextWriter archivoXML = new XmlTextWriter(path, null);

                
                archivoXML.Formatting = Formatting.Indented;
                archivoXML.WriteStartDocument();

                archivoXML.WriteComment("Ejercicio de escritura en un archivo XML");

                archivoXML.WriteStartElement("Persona");
                archivoXML.WriteStartElement("Datos");

                archivoXML.WriteStartElement("Apellido","");
                archivoXML.WriteString(txtApellido.Text);
                archivoXML.WriteEndElement();

                archivoXML.WriteStartElement("Sueldo","");
                archivoXML.WriteString(txtSueldo.Text);
                archivoXML.WriteEndElement();

                archivoXML.Flush();
                archivoXML.Close();

                lblMsg.Attributes.Add("style", "opacity:1;");
                btnLeerXML.Attributes.Add("style", "display:inline-block;");
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
                lblMsg.Attributes.Add("style", "opacity:1;");
            }
            
        }
        protected void leerMsg_Click(object sender, EventArgs e)
        {
            Response.Redirect("/EjercicioB.aspx");
        }
    }
}