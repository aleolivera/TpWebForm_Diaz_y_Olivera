<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebForm._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">


    <div class="jumbotron">
        <h1>TUSHOPPING.COM</h1>
        <p class="lead">En TUSHOPPING.COM encontrarás el articulo de electronica que buscas, al mejor precio y de la mejor calidad. Si queres saber mas de nosotros </p>
        <p><a href="/contact" class="btn btn-primary btn-lg">Contactanos &raquo;</a></p>
    </div>

    <%--<div class="input-group mb-3">
        <input type="Search" class="form-control" placeholder="Articulo" aria-label="Recipient's username" aria-describedby="button-addon2" onkeypress="" list="listaarticulos" />
        <div class="input-group-append">

            <%--<button class="btn btn-outline-secondary" type="button" id="button-addon2">Buscar</button>--%>
       <%--<asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click"/>

        </div>
        <datalist id="listaarticulos">
            <%foreach (var articulos in listaarticulo)
                {%>

            <option value=" <% =articulos.Nombre.ToString()%>">

                <%}%>
        </datalist>
    </div>--%>

  <%--  DEJO COMENTADO EL CODIGO DEL BUSCADOR PARA QUE LO PUEDAS VER, ES SOLO EL DE ABAJO PORQUE GENERA EL ONCLICK--%> 

   <div>
    <asp:TextBox ID="txtArticulo" name= "art" runat="server" TextMode="Search" list="listaarticulos"
        CausesValidation="False" AutoCompleteType="None" Width="800" />
       <asp:Button ID="Button1" runat="server" Text="Buscar" OnClick="btnBuscar_Click"/>
         </div>
    <div>



        <datalist id="listaarticulos">
            <select name="art">
            <%foreach (var articulos in listaarticulo)
                {%>
            
            <option value=" <% =articulos.Nombre.ToString()%>">
                
                <a href="Detalle.aspx?IDArticulo= <%= articulos.Id.ToString()%>" </a>

               <%}%>
                </select>
        </datalist>
    </div>
   <%-- <div>
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click"/>
    </div>--%>

   


    <div class="row">
        <%foreach (Dominio.Articulos item in listaarticulo)
            {%>

        <div class="col-md-4">
            <div class="card" style="width: 18rem;">
                <img src="<%=item.ImagenUrl %>" class="card-img-top" alt="alternative-text" width="280">
                <div class="card-body">
                    <h5 class="card-title"><% = item.Nombre %></h5>
                    <h5 class="card-title">$<% = item.Precio %></h5>
                    <a href="/about.aspx?idArticulo=<% = item.Id.ToString() %>" class="btn btn-primary">Agregalo al carrito!</a>
                    
                    <a href="Detalle.aspx?IDArticulo= <%= item.Id.ToString()%>" class="btn btn-primary">Detalle!</a>

                </div>
            </div>

        </div>

        <% } %>
    </div>

</asp:Content>
