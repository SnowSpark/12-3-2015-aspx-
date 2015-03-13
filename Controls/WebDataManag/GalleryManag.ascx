<%@ Control Language="C#" AutoEventWireup="true" CodeFile="GalleryManag.ascx.cs" Inherits="Controls_WebDataManag_GalleryManag" %>
<asp:ScriptManager ID="ScriptManager1" runat="server">
</asp:ScriptManager>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <asp:DropDownList ID="DDLName" runat="server" AutoPostBack="True" 
            onselectedindexchanged="DDLName_SelectedIndexChanged">
        </asp:DropDownList>
        <asp:Label ID="dataName" runat="server"></asp:Label>
        <br />
        <asp:TextBox ID="txtData" runat="server" Height="77px" TextMode="MultiLine" 
            Width="321px"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Button" />
    </ContentTemplate>
</asp:UpdatePanel>

