<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="respuestaEjercicioB.aspx.cs" 
    Inherits="Ejercicios_con_XML.respuestaEjercicioB" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
     <section>
            <p>Los datos leidos del archivo XML y leidos de las variables de sesion son:</p>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Apellido: " CssClass="textInfo"></asp:Label>
                <asp:Label ID="lblApellido" runat="server" Text="---"></asp:Label>
            </div>
            <div>
                <asp:Label ID="Label2" runat="server" Text="Sueldo: " CssClass="textInfo"></asp:Label>
                <asp:Label ID="lblSueldo" runat="server" Text="$--" ></asp:Label>
            </div>
        </section>
</asp:Content>
