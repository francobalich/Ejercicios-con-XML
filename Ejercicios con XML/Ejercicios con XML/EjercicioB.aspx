<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" 
    CodeBehind="EjercicioB.aspx.cs" Inherits="Ejercicios_con_XML.EjercicioB" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        <form id="form1" runat="server">
        <section>
            <p>Los datos leidos del archivo XML son:</p>
            <div>
                <asp:Label ID="Label1" runat="server" Text="Apellido: " CssClass="textInfo"></asp:Label>
                <asp:Label ID="lblApellido" runat="server" Text="---"></asp:Label>
            </div>
            <div>
                <asp:Label ID="Label2" runat="server" Text="Sueldo: " CssClass="textInfo"></asp:Label>
                <asp:Label ID="lblSueldo" runat="server" Text="$--" ></asp:Label>
            </div>
            <asp:Label ID="lblMsg" runat="server" Text="¡El archivo XML no existe!" CssClass="msgNone">
            </asp:Label>
        </section>
    </form>
</asp:Content>
