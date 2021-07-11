using System;
using System.Collections.Generic;
using System.IO;
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
                while (archivoXML.Read())
                {
                    if (archivoXML.Name=="Apellido")
                    {
                        archivoXML.Read();
                        Session["apellido"] = archivoXML.Value;
                        archivoXML.Read();
                    }
                    else if (archivoXML.Name == "Sueldo")
                    {
                        archivoXML.Read();
                        Session["sueldo"] = archivoXML.Value;
                        archivoXML.Read();
                    }
                }
                archivoXML.Close();
                Response.Redirect("respuestaEjercicioB.aspx");
            }
        }
    }
}