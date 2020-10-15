<%@ Page Title="Carrito de compras" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebForm.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    
    
    <asp:Label ID="lblCarrito" runat="server" Text="Nada"></asp:Label>

    <table class="table table-dark">
        <thead>
          <tr>
              <%--<th scope="col">#</th>--%>
              <th scope="col">Imagen </th>
              <th scope="col">Articulo</th>
              <th scope="col">Importe</th>           
          </tr>
       </thead>
    <%foreach(Dominio.Articulos item in carrito)
      { %>
         
            <tbody>
                <tr>
                    <%--<th scope="row">1</th>--%>
                    <td><img src="<%=item.ImagenUrl %>" alt="<%=item.ImagenUrl %>" width="150" height="150"></td>
                    <td><%=item.Nombre %></td>
                    <td><%=item.Precio %></td>
                    
               </tr>
           </tbody>   

    <%}%>
   </table> 

</asp:Content>
