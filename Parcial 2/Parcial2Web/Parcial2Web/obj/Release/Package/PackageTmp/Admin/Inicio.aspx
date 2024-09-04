<%@ Page Title="" Language="C#" MasterPageFile="~/MasterWebs/SiteAdmin.Master" AutoEventWireup="true" CodeBehind="Inicio.aspx.cs" Inherits="Parcial2Web.Admin.Inicio" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        .btn-color {
            background-color: #0e1c36;
            color: #fff;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="px-4 py-5 my-5 text-center">
        <h1 class="display-5 fw-bold text-body-emphasis">Bienvenido al Sistema Administrador</h1>
        <div class="col-lg-6 mx-auto">
            <p class="lead mb-4">
                Nos alegra contar con su presencia. Desde este panel, tiene acceso completo para gestionar y optimizar todos los aspectos de la plataforma. 
                Si necesita asistencia o tiene alguna consulta, estamos aquí para ayudarle. ¡Esperamos que tenga una experiencia productiva y eficiente!
            </p>
        </div>
    </div>
</asp:Content>
