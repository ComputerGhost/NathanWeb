<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin.Master" AutoEventWireup="false" CodeBehind="Tip.aspx.cs" Inherits="NathanWeb.Admin.Tip" %>
<asp:Content ID="Content1" ContentPlaceHolderID="phContent" runat="server">
<form runat="server">
<main>
    <h1>Edit Tip Content</h1>
    
    <div>
        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
    </div>

    <div>id: <asp:Literal ID="litId" runat="server" /></div>
    <div>category: <asp:Literal ID="litCategory" runat="server" /></div>
    <div>title: <span id="title"><asp:Literal ID="litTitle" runat="server" /></span></div>

    <div class="columns">
        <section class="column-50">
            <asp:TextBox ID="txtContent" runat="server" TextMode="MultiLine" />
        </section>
        <section class="column-50">
            <iframe id="preview" src="PreviewTemplate.html">
            </iframe>
        </section>
    </div>

    <script>
        $(document).ready(function () {
            var txtContent = $('#<%= txtContent.ClientID %>');
            var preview = $('#preview').contents().find('#content');

            $('#preview').on('load', function () {
                $('#preview').contents().find('#title').html($('#title').html());
                preview = $('#preview').contents().find('#content');
                preview.html(txtContent.val());
            });
            txtContent.on('input', function () {
                preview.html(txtContent.val());
            });
            
            var height = $(window).height() - txtContent.position().top - 32;
            txtContent.height(height);
            $(window).resize(function () {
                var height = $(window).height() - txtContent.position().top - 32;
                txtContent.height(height);
            });
        });
    </script>

</main>
</form>
</asp:Content>
