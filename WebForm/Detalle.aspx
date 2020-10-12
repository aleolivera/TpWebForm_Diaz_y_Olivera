<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Detalle.aspx.cs" Inherits="WebForm.Detalle" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <%--<div class=" conteiner">
        <div class="jumbotron">

             <img src="<%=detalle.ImagenUrl %>" alt="alternative-text" width="280">
            <h3 class ="display-4" = ><% = detalle.Nombre %></h3>
            <p class ="lead =" >$<% = detalle.Precio %></p>
            <div class="card-body">
    <h4 class="card-title">Categoria</h4>
    <p class="card-text="><%=detalle.marca%></p>
    <h5 class="card-title">Detalle</h5>
    <p class="card-text="><%=detalle.Descripcion%></p>
    <a href="#" class="btn btn-primary">Agregalo al carrito!</a>
  </div>
</div>
           </div>--%>
        
<!--DEJE UN FORMATO ARRIBA, COMENTADO, PARA QUE VEAS CUAL DE LOS DOS TE GUSTA MAS-->

 <div class=" conteiner">
        <div class="jumbotron">

             <img src="<%=detalle.ImagenUrl %>" alt="alternative-text" width="280">
            <h3 class ="display-4" = ><% = detalle.Nombre %></h3>
            <p class ="lead =" >Precio: $<% = detalle.Precio %></p>
            <div class="card-body">
            <a href="#" class="btn btn-primary">Agregalo al carrito!</a>
                
  </div>
</div>
           </div>

<div class="card w-50">
  <div class="card-body">
    <h5 class="card-title">Marca</h5>
    <p class="card-text"><%=detalle.marca%></p>
   
  </div>
</div>

<div class="card w-50">
  <div class="card-body">
    <h5 class="card-title">Descripcion</h5>
    <p class="card-text"><%=detalle.Descripcion%></p>
   
  </div>
</div>   

</asp:Content>
