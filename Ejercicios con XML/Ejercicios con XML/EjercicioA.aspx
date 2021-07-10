<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EjercicioA.aspx.cs" Inherits="Ejercicios_con_XML.EjercicioA" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <form id="form1" runat="server">
        <section>
            <p>Por favor, ingrese los datos solicitados para crear un archivo XML.</p>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Apellido"></asp:Label>
                <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator
                    class="alerta" controltovalidate="txtApellido"
                    text="Este campo debe llenarse" runat="server"  CssClass="msgError">
                </asp:RequiredFieldValidator>
            </div>

            <div>
                <asp:Label ID="Label2" runat="server" Text="Sueldo"  CssClass="positionRight"></asp:Label>
                <asp:TextBox ID="txtSueldo" runat="server" CssClass="positionRight"></asp:TextBox>
                <asp:RequiredFieldValidator
                    class="alerta" controltovalidate="txtSueldo"
                    text="Este campo debe llenarse" runat="server"  CssClass="msgError positionRight">
                </asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator
                    class="alerta alerta-regex" controltovalidate="txtSueldo" text="El valor debe ser númerico"
                    validationexpression="^\d+" runat="server"  CssClass="msgError positionLeft"/>
            </div>

            <asp:Button ID="btnCrearXML" runat="server" onClick="crearXML_OnClick" Text="Crear XML" CssClass="button"/>
            <br />
            <asp:Label ID="lblMsg" runat="server" Text="¡Se creo exitosamente el archivo XML!" CssClass="msgOK"></asp:Label>
        </section>
       
    </form>
</asp:Content>
