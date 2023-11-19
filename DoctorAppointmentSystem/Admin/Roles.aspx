<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Add.Master" AutoEventWireup="true" CodeBehind="Roles.aspx.cs" Inherits="DoctorAppointmentSystem.Admin.Roles" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:gridview ID="GridView1" runat="server" AutoGenerateColumns="false" CellPadding="10">
        <Columns>
            <asp:BoundField DataField="RoleId" HeaderText="ID" />
            <asp:BoundField DataField="RoleName" HeaderText="Role" />
        </Columns>
    </asp:gridview>
</asp:Content>
