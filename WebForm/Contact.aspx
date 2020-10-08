<%@ Page Title="Contacto" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebForm.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Atención al Cliente.</h3>

    <div class="row">
  <div class="col-sm-6">
    <div class="card">
      <div class="card-body">
        <h5 class="card-title">Online</h5>
        <p class="card-text">Consultas sobre compras online.</p>
        <a href="#" class="btn btn-primary">Mail</a>
      </div>
    </div>
  </div>
  <div class="col-sm-6">
    <div class="card">
      <div class="card-body">
        <h5 class="card-title">Tiendas y empresa</h5>
        <p class="card-text">Consultas sobre nuestras tiendas.</p>
        <a href="#" class="btn btn-primary"> Ver que ponemos</a>
      </div>
    </div>
  </div>
</div>
    <br> 
     <address>
         <p>
        Programacion III<br />
        Pacheco, Av. Hipólito Yrigoyen 288<br />
        <abbr title="Telefono">T:</abbr>
        Sin Telefono  <!--Quizas el tel se lo podamos quitar o tambien cambiar el formato y hacer un formulario de contacto--> 
        </p> 

        <strong>Soporte:</strong>   <a href="mailto:Support@example.com">OliveraDiaz@example.com</a><br />
        
    </address>
</asp:Content>
