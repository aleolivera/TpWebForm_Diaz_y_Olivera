<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePageSinMaster.aspx.cs" Inherits="WebForm.HomePageSinMaster" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <!-- Required meta tags -->
    <meta charset="utf-8"/>
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no"/>
    <!-- Bootstrap CSS -->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css" integrity="sha384-JcKb8q3iqJ61gNV9KGb8thSsNjpSL0n8PARn9HuZOnIxN0hoP+VmmDGMN5t9UJ0Z" crossorigin="anonymous"/>
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
        <nav class="navbar navbar-expand-lg navbar-dark bg-dark">
            <a class="navbar-brand" href="#">Nombre App</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavAltMarkup" aria-controls="navbarNavAltMarkup" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarNavAltMarkup">
                <div class="navbar-nav">
                   
                    <ul class="nav navbar-nav">
                        <li><a runat="server" href="~/">Home</a></li>
                        
                        <li><a runat="server" href="~/About">About</a></li>
                        
                        <li><a runat="server" href="~/Contact">Contacto</a></li>
                    </ul>
                </div>
            </div>
        </nav>

        

       <div class="row">
        <%foreach (Dominio.Articulos item in listaArticulos)
            {%>

        <div class="col-md-4">
            <div class="card" style="width: 18rem;">
                <img src="<%=item.ImagenUrl %>" class="card-img-top" alt="alternative-text" width="280">
                <div class="card-body">
                    <h5 class="card-title"><% = item.Nombre %></h5>
                    <h5 class="card-title">$<% = item.Precio %></h5>
                    <a href="#" class="btn btn-primary">Agregalo al carrito!</a>
                </div>
            </div>

        </div>

        <% } %>
    </div>
    </form>

    <!-- Optional JavaScript -->
    <!-- jQuery first, then Popper.js, then Bootstrap JS -->
    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js" integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj" crossorigin="anonymous"></script>
    <script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.1/dist/umd/popper.min.js" integrity="sha384-9/reFTGAW83EW2RDu2S0VKaIzap3H66lZH81PoYlFhbGU+6BZp6G7niu735Sk7lN" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js" integrity="sha384-B4gt1jrGC7Jh4AgTPSdUtOBvfO8shuf57BaghqFfPlYxofvL8/KUEfYiJOMMV+rV" crossorigin="anonymous"></script>
</body>
</html>
