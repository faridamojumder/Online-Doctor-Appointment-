<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Add.Master" AutoEventWireup="true" CodeBehind="Users.aspx.cs" Inherits="DoctorAppointmentSystem.Admin.Users" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:gridview ID="GridView1" runat="server" AutoGenerateColumns="false" CellPadding="10" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:BoundField DataField="UserId" HeaderText="ID" />
            <asp:BoundField DataField="Username" HeaderText="User" />
            <asp:BoundField DataField="RoleName" HeaderText="Role" />
            <asp:ButtonField HeaderText="#" CommandName="SetPermission" Text="Set Permission"></asp:ButtonField>
        </Columns>
    </asp:gridview>
</asp:Content>
