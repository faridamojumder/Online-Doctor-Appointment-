<%@ Page Title="" Language="C#" MasterPageFile="~/AppointmentDetails/Appoint.Master" AutoEventWireup="true" CodeBehind="DoctorList.aspx.cs" Inherits="DoctorAppointmentSystem.AppointmentDetails.DoctorList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>New Doctor List</h1>
    <h4><a href="/AppointmentDetails/DoctorInsert.aspx">New Doctor</a></h4>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" CellPadding="10" OnRowCommand="GridView1_RowCommand">
        <Columns>
            <asp:BoundField DataField="DoctorID" HeaderText="ID" />
            <asp:BoundField DataField="DoctorName" HeaderText="Name" />
            <asp:BoundField DataField="Email" HeaderText="Email" />
            <asp:BoundField DataField="Fee" HeaderText="Fee" />
            <asp:BoundField DataField="ServiceType" HeaderText="ServiceType" />
            <asp:BoundField DataField="ScheduleDate" HeaderText="ScheduleDate" />
            <asp:ImageField DataImageUrlField="Prescription" HeaderText="Prescription"></asp:ImageField>
            <asp:BoundField DataField="SpecialistID" HeaderText="Specialist" />
            <asp:ButtonField HeaderText="#" CommandName="Edit" Text="Edit"></asp:ButtonField>
            <asp:ButtonField HeaderText="#" CommandName="Remove" Text="Delete"></asp:ButtonField>
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="btnReport" runat="server" Text="View Report" OnClick="btnReport_Click" ForeColor="#FF3300" />
</asp:Content>
