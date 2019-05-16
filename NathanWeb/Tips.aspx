<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tips.aspx.cs" Inherits="NathanWeb.Tips" %>
<asp:Content ID="Content1" ContentPlaceHolderID="phContent" runat="server">
<main>

    <nav id="side-nav">
        <li class="category">Clients</li>
            <li class="item"><a href="#">Subcategory</a></li>
            <li class="item active"><a href="#">Communication</a></li>
        <li class="category">General</li>
            <li class="item"><a href="#">Subcategory</a></li>
            <li class="item"><a href="#">Communication</a></li>
        <li class="category">Rules</li>
            <li class="item"><a href="#">Subcategory</a></li>
            <li class="item"><a href="#">Communication</a></li>
    </nav>

    <article>
        <h1>The title of the tip goes here</h1>
        Content Here
    </article>

</main>
</asp:Content>
