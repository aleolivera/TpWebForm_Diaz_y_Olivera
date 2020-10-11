<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="WebForm.Detalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div class=" conteiner">
        <div class="jumbotron">
             <img src="<%=detalle.ImagenUrl %>" alt="alternative-text" width="280">
            <h1 class ="display-4" = ><% = detalle.Nombre %></h1>
            <p class ="lead =" >$<% = detalle.Precio %></p>
           </div>
        </div>   

</asp:Content>
