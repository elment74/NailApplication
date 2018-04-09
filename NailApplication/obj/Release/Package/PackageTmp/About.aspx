<%@ Page Title="Transaction" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="NailApplication.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2>Transaction</h2>
    <p>Input information below</p>
    <p>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>Phuong</asp:ListItem>
            <asp:ListItem>Loc</asp:ListItem>
            <asp:ListItem>Em</asp:ListItem>
            <asp:ListItem>Huong</asp:ListItem>
            <asp:ListItem>Trang</asp:ListItem>
            <asp:ListItem>Dung</asp:ListItem>
            <asp:ListItem>Loan</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        Select service</p>
    <p>
        Pedicure<asp:DropDownList ID="DropDownList2" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            <asp:ListItem Value="0">-----------</asp:ListItem>
            <asp:ListItem Value="25">Signature</asp:ListItem>
            <asp:ListItem Value="35">Signature w/Callus</asp:ListItem>
            <asp:ListItem Value="40">Deluxe</asp:ListItem>
            <asp:ListItem Value="40">Deluxe w/Callus</asp:ListItem>
            <asp:ListItem Value="45">Royal</asp:ListItem>
            <asp:ListItem Value="10">Gel</asp:ListItem>
            <asp:ListItem Value="10">French gel</asp:ListItem>
            <asp:ListItem Value="10">French Regular</asp:ListItem>
            <asp:ListItem Value="5">Designs</asp:ListItem>
            <asp:ListItem Value="8">Paraffin wax</asp:ListItem>
            <asp:ListItem Value="3">Remove gel</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Add" />
    </p>
    <p>
        Manicures<asp:DropDownList ID="DropDownList3" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            <asp:ListItem Value="0">-----------</asp:ListItem>
            <asp:ListItem Value="15">Manicure</asp:ListItem>
            <asp:ListItem Value="20">French manicure</asp:ListItem>
            <asp:ListItem Value="25">Gel Manicure</asp:ListItem>
            <asp:ListItem Value="30">Gel French Manicure</asp:ListItem>
            <asp:ListItem Value="5">Design 2 nail</asp:ListItem>
            <asp:ListItem Value="10">Design 10 nail</asp:ListItem>
            <asp:ListItem Value="6">Paraffin wax</asp:ListItem>
            <asp:ListItem Value="3">Gel remove</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Add" />
    </p>
    <p>
        Waxing<asp:DropDownList ID="DropDownList4" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            <asp:ListItem Value="">-----------</asp:ListItem>
            <asp:ListItem Value="6">Lower Lip</asp:ListItem>
            <asp:ListItem Value="8">Chin</asp:ListItem>
            <asp:ListItem Value="12">Sideburn</asp:ListItem>
            <asp:ListItem Value="15">Eyebrow/Upper Lip</asp:ListItem>
            <asp:ListItem Value="12">Upper/Lower/Chin</asp:ListItem>
            <asp:ListItem Value="20">Eyebrow/Upper/Lower/Chin</asp:ListItem>
            <asp:ListItem Value="15">Eyebrow/Chin</asp:ListItem>
            <asp:ListItem Value="35">Whole face</asp:ListItem>
            <asp:ListItem Value="8">Upper lip</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Add" />
    </p>
    <p>
        Nail Removal<asp:DropDownList ID="DropDownList5" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            <asp:ListItem Value="0">-----------</asp:ListItem>
            <asp:ListItem Value="10">Remove nail</asp:ListItem>
            <asp:ListItem Value="5">Remove with another service</asp:ListItem>
            
        </asp:DropDownList>
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="Add" />
    </p>
    <p>
        Nail trim<asp:DropDownList ID="DropDownList6" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            <asp:ListItem Value="0">-----------</asp:ListItem>
            <asp:ListItem Value="6">Hand</asp:ListItem>
            <asp:ListItem Value="12">Foot</asp:ListItem>
            
        </asp:DropDownList>
        <asp:Button ID="Button7" runat="server" OnClick="Button7_Click" Text="Add" />
    </p>
    <p>
        Artificial nail<asp:DropDownList ID="DropDownList7" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            <asp:ListItem Value="0">-----------</asp:ListItem>
            <asp:ListItem Value="30">Full Acrylic French tip</asp:ListItem>
            <asp:ListItem Value="27">Full Acrylic Regular Polish</asp:ListItem>
            <asp:ListItem Value="35">Full Acrylic Gel color</asp:ListItem>
            <asp:ListItem Value="17">Fill Acrylic Regular Polish</asp:ListItem>
            <asp:ListItem Value="25">Fill Acrylic Gel Color</asp:ListItem>
            <asp:ListItem Value="35">Solar/Full set/Solid Color/Regular Polish</asp:ListItem>
            <asp:ListItem Value="40">Solar/Full set/Solid Color/Gel Color</asp:ListItem>
            <asp:ListItem Value="45">Solar/Full set/Pink and white</asp:ListItem>
            <asp:ListItem Value="35">Solar/Fill/Pink and White</asp:ListItem>
            <asp:ListItem Value="23">Solar/Fill pink</asp:ListItem>
            <asp:ListItem Value="30">Solar/Fill/Gel color</asp:ListItem>
            <asp:ListItem Value="40">Gel/Full set</asp:ListItem>
            <asp:ListItem Value="45">Gel/Full set french</asp:ListItem>
            <asp:ListItem Value="28">Gel/Fill</asp:ListItem>
            <asp:ListItem Value="35">Gel/Fill with color</asp:ListItem>
            <asp:ListItem Value="5">2 nail designs</asp:ListItem>
            <asp:ListItem Value="5">French tips</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button8" runat="server" OnClick="Button8_Click" Text="Add" />
    </p>
    <p>
        Color change<asp:DropDownList ID="DropDownList8" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            <asp:ListItem Value="0">-----------</asp:ListItem>
            <asp:ListItem Value="8">Hand/Regular Nail Polish</asp:ListItem>
            <asp:ListItem Value="10">Hand/French Regular Nail Polis</asp:ListItem>
            <asp:ListItem Value="15">Hand/Gel color</asp:ListItem>
            <asp:ListItem Value="18">Hand/French gel color</asp:ListItem>
            <asp:ListItem Value="12">Foot/Regular Nail Polish</asp:ListItem>
            <asp:ListItem Value="15">Foot/French Regular Nail polish</asp:ListItem>
            <asp:ListItem Value="17">Foot/Gel Color</asp:ListItem>
            <asp:ListItem Value="22">Foot/French Gel Color</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button9" runat="server" OnClick="Button9_Click" Text="Add" />
    </p>
    <p>
        Facials<asp:DropDownList ID="DropDownList9" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            <asp:ListItem Value="0">-----------</asp:ListItem>
            <asp:ListItem Value="50">Facial</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button10" runat="server" OnClick="Button10_Click" Text="Add" />
    </p>
    <p>
        Eyelash Extensions<asp:DropDownList ID="DropDownList10" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            <asp:ListItem Value="0">-----------</asp:ListItem>
            <asp:ListItem Value="95">Full set</asp:ListItem>
            <asp:ListItem Value="45">Fill in</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button11" runat="server" OnClick="Button11_Click" Text="Add" />
    </p>
    <p>
        Eyebrow and Eyelash tinting<asp:DropDownList ID="DropDownList11" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            <asp:ListItem Value="0">-----------</asp:ListItem>
            <asp:ListItem Value="14">Eyebrow tinting</asp:ListItem>
            <asp:ListItem Value="14">Eyelash tinting</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button12" runat="server" OnClick="Button12_Click" Text="Add" />
    </p>
    <p>
        Kids menu<asp:DropDownList ID="DropDownList12" runat="server" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged">
            <asp:ListItem Value="0">-----------</asp:ListItem>
            <asp:ListItem Value="25">Pedicure and Manicure</asp:ListItem>
            <asp:ListItem Value="8">Polish on feet</asp:ListItem>
            <asp:ListItem Value="5">Polish on hand</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button13" runat="server" OnClick="Button13_Click" Text="Add" />
    </p>
    <p>
        Total:<asp:TextBox ID="TextBox1" runat="server">0</asp:TextBox>
    </p>
<asp:CheckBoxList ID="CheckBoxList1" runat="server" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
</asp:CheckBoxList>
    Tips:<asp:TextBox ID="TextBox2" runat="server">0</asp:TextBox>
<p>
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" OnCommand="Button1_Command" />
    </p>
    <p>
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Clear" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
