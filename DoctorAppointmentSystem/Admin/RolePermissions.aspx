<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Add.Master" AutoEventWireup="true" CodeBehind="RolePermissions.aspx.cs" Inherits="DoctorAppointmentSystem.Admin.RolePermissions" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <a href="Users.aspx">Back to List</a>
    <table border="1">  
        <tr>  
            <td>User Name:</td>  
            <td><asp:Label ID="lblUsername" runat="server" Text="Label"></asp:Label></td>  
            <td></td>
            <td></td>
            <td><asp:HiddenField ID="userId" runat="server" Value="" /></td>
        </tr>
        <tr>  
            <td>Role:</td>  
            <td><asp:Label ID="lblRole" runat="server" Text="Label"></asp:Label></td>  
            <td></td>
            <td></td>
            <td><asp:HiddenField ID="roleId" runat="server" Value="" /></td>
        </tr>
        <tr>  
            <td>Specialist:<asp:HiddenField ID="sMenuName" runat="server" Value="Specialist" /></td>  
            <td>Select <asp:CheckBox ID="sSelect" runat="server" /></td>  
            <td>Insert <asp:CheckBox ID="sInsert" runat="server" /></td>
            <td>Update <asp:CheckBox ID="sUpdate" runat="server" /></td>
            <td>Delete <asp:CheckBox ID="sDelete" runat="server" /></td>
        </tr>
        <tr>  
            <td>Doctor:<asp:HiddenField ID="dMenuName" runat="server" Value="Doctor" /></td>  
            <td>Select <asp:CheckBox ID="dSelect" runat="server" /></td>  
            <td>Insert <asp:CheckBox ID="dInsert" runat="server" /></td>
            <td>Update <asp:CheckBox ID="dUpdate" runat="server" /></td>
            <td>Delete <asp:CheckBox ID="dDelete" runat="server" /></td>
        </tr>
        <tr>  
            <td></td>  
            <td></td>
            <td></td>
            <td></td>
            <td><asp:Button ID="btnSubmit" Text="Submit" runat="server" style="height: 26px" OnClick="btnSubmit_Click"/></td>  
        </tr>
    </table> 
</asp:Content>
