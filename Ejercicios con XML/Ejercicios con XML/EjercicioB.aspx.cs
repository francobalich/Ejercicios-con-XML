using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Ejercicios_con_XML
{
    public partial class EjercicioB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string path = Server.MapPath("Sueldos.xml");
            if (File.Exists(path))
            {
                XmlTextReader archivoXML = new XmlTextReader(path);
                Dictionary<string,string> datos = new Dictionary<string, string>();
                while (archivoXML.Read())
                {
                    if (archivoXML.Name=="Apellido")
                    {
                        archivoXML.Read();
                        lblApellido.Text = archivoXML.Value;
                        archivoXML.Read();
                    }
                    else if (archivoXML.Name == "Sueldo")
                    {
                        archivoXML.Read();
                        lblSueldo.Text = archivoXML.Value;
                        archivoXML.Read();
                    }
                }
                archivoXML.Close();
            }
            else
            {
                lblMsg.Attributes.Add("style", "opacity:1;");
            }
        }
    }
}