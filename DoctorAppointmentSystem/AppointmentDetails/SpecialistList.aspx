<%@ Page Title="" Language="C#" MasterPageFile="~/AppointmentDetails/Appoint.Master" AutoEventWireup="true" CodeBehind="SpecialistList.aspx.cs" Inherits="DoctorAppointmentSystem.AppointmentDetails.SpecialistList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Specialist</h2>
     <asp:FormView ID="FormView1" runat="server" DefaultMode="Insert" AllowPaging="True" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="ObjectDataSource1" GridLines="Both">
        <EditRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <InsertItemTemplate>
            <asp:Label ID="Label1" runat="server" Text="SpecialistName"></asp:Label>
            <asp:TextBox ID="txtSpecialistName" runat="server" Text='<%# Bind("SpecialistName") %>'/>
            <br>
            <asp:Button ID="btnSave" runat="server" Text="Save" CommandName="insert" />
        </InsertItemTemplate>
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#330099" />
    </asp:FormView>
    <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="ObjectDataSource1">
        <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
        <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
        <RowStyle BackColor="White" ForeColor="#330099" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
        <SortedAscendingCellStyle BackColor="#FEFCEB" />
        <SortedAscendingHeaderStyle BackColor="#AF0101" />
        <SortedDescendingCellStyle BackColor="#F6F0C0" />
        <SortedDescendingHeaderStyle BackColor="#7E0000" />
     </asp:GridView>
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="DoctorAppointmentSystem.SpecialistClass" InsertMethod="AddSpecialist" SelectMethod="GetSpecialist" TypeName="DoctorAppointmentSystem.SpecialistDAL"></asp:ObjectDataSource>
</asp:Content>
