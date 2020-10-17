<%@ Page Title="Carrito de compras" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebForm.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br/>
    <h2><%: Title %></h2>
    <br />
    

    <table class="table table-dark">
        <thead>
          <tr>
              <th colspan="5"><asp:Label ID="lblCarrito"  runat="server" Text="Nada"></asp:Label></th></tr>
            <tr>
              <th scope="col" style="width:15%; text-align:center;">#</th>
              <th scope="col">Imagen </th>
              <th scope="col">Articulo</th>
              <th scope="col">Importe</th>  
              <th scope="col"></th> 
          </tr>
       </thead>
        <%System.Data.SqlTypes.SqlMoney acu = 0;
                                        int i = 0;%>
    <%foreach(Dominio.Articulos item in carrito)
      { %>
         <%acu += item.Precio;
           i++;%>
            <tbody>
                <tr>
                    <th scope="row"  style="font-size:20px; width:5%; text-align:center;"><% = i.ToString() %></th>
                    <td><img src="<%=item.ImagenUrl %>" alt="<%=item.ImagenUrl %>" width="100" height="100"></td>
                    <td style="font-size:20px"><%=item.Nombre %></td>
                    <td style="font-size:20px"><%=item.Precio %></td>
                    <td style="font-size:20px"><a href="/about.aspx?idArticulo=<% = item.Id.ToString() %>&quitar=<%= true.ToString() %> " class="btn btn-primary">Quitar</a></td>
               </tr>
           </tbody>   

    <%}%>
        <tr>
             <td colspan="2" style="text-align:center"><a href="Default.aspx" class="btn btn-primary">Seguir Comprando</a></td>
             <td>
                 <asp:Button ID="btnComprar" runat="server" Text="Comprar" onclick="btnComprar_Click" Class="btn btn-primary" style="text-align:center"/> </td>
             <td> <p style="text-align:center; font-size:30px; color:white; font-weight:700;"  >Total: $<% = acu.ToString() %></p></td>
          </tr>
   </table> 
    

</asp:Content>
