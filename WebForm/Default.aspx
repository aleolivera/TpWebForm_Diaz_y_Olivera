<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="jumbotron">
        <h1>TUSHOPPING.COM</h1>
        <p class="lead">En TUSHOPPING.COM encontrarás el articulo de electronica que buscas, al mejor precio y de la mejor calidad. Si queres saber mas de nosotros </p>
        <p><a href="/contact" class="btn btn-primary btn-lg">Contactanos &raquo;</a></p>
    </div>

    <div class="input-group mb-3">
         <input type="text" class="form-control" placeholder="Articulo" aria-label="Recipient's username" aria-describedby="button-addon2" onkeypress=""/>
            <div class="input-group-append">
              
                <button class="btn btn-outline-secondary" type="button" id="button-addon2">Buscar</button>
            </div>
    </div>

    <%--<div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                ASP.NET Web Forms lets you build dynamic websites using a familiar drag-and-drop, event-driven model.
            A design surface and hundreds of controls and components let you rapidly build sophisticated, powerful UI-driven sites with data access.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301948">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Get more libraries</h2>
            <p>
                NuGet is a free Visual Studio extension that makes it easy to add, remove, and update libraries and tools in Visual Studio projects.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301949">Learn more &raquo;</a>
            </p>
        </div>
        <div class="col-md-4">
            <h2>Web Hosting</h2>
            <p>
                You can easily find a web hosting company that offers the right mix of features and price for your applications.
            </p>
            <p>
                <a class="btn btn-default" href="https://go.microsoft.com/fwlink/?LinkId=301950">Learn more &raquo;</a>
            </p>
        </div>
    </div>--%>

    <!--El codigo de arriba podriamos quitarlo porque es el que viene por defecto, desde div-->


    <div class="row">
        <%foreach (Dominio.Articulos item in listaarticulo)
            {%>

        <div class="col-md-4">
            <div class="card" style="width: 18rem;">
                <img src="<%=item.ImagenUrl %>" class="card-img-top" alt="alternative-text" width="280">
                <div class="card-body">
                    <h5 class="card-title">Precio:<% = item.Nombre %></h5>
                    <h5 class="card-title">$<% = item.Precio %></h5>
                    <a href="#" class="btn btn-primary">Agregalo al carrito!</a>
                     <!--<a href="#" class="btn btn-secondary">Detalle!</a>-->
                    <a href= "Detalle.aspx?idArticulo= <%= item.Id.ToString()%>" class="btn btn-primary">Detalle!</a>
                    
                </div>
            </div>

        </div>

        <% } %>
    </div>

</asp:Content>
