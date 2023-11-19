<%@ Page Title="" Language="C#" MasterPageFile="~/AppointmentDetails/Appoint.Master" AutoEventWireup="true" CodeBehind="DoctorInsert.aspx.cs" Inherits="DoctorAppointmentSystem.AppointmentDetails.DoctorInsert" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table style="width: 100%;">
        <tr>
            <td>Doctor Name:</td>
            <td><asp:TextBox ID="txtDoctorName" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Email:</td>
            <td><asp:TextBox ID="txtEmail" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Fee:</td>
            <td><asp:TextBox ID="txtFee" runat="server"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Service Type:</td>
            <td><asp:RadioButton ID="RadioOnline" runat="server" GroupName="ServiceType" Text="Online" /><asp:RadioButton ID="RadioOffline" runat="server" GroupName="ServiceType" Text="Offline" /></td>
        </tr>
        <tr>
            <td>Schedule Date:</td>
            <td><asp:Calendar ID="Calendar1" runat="server" type="date"></asp:Calendar></td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Prescription:"></asp:Label></td>
            <td><asp:FileUpload ID="FileUpload1" runat="server" /></td>
        </tr>
        <tr>
            <td>SpecialistID:</td>
            <td><asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList></td>
        </tr>
    </table>
    <asp:Button ID="btnSave" runat="server" Text="Save" Width="92px" OnClick="btnSave_Click" />
    <h4><a href="/AppointmentDetails/DoctorList.aspx">Go to List</a></h4>
</asp:Content>
