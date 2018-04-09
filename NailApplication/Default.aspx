<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="NailApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Home</h1>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Transaction" />
            <asp:Button ID="Button2" runat="server" Text="History" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Appointment" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="Client" OnClick="Button4_Click" />
        </p>
        <p>&nbsp;</p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>&nbsp;</h2>
        </div>
        <div class="col-md-4">
            <h2>&nbsp;</h2>
        </div>
    </div>

</asp:Content>
