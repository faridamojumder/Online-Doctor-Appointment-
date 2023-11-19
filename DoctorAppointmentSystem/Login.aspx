<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="DoctorAppointmentSystem.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 41px;
        }
        .auto-style2 {
            width: 663px;
            height: 427px;
            top: 74px;
            right: 834px;
            bottom: 334px;
            left: 412px;
            position: absolute;
            z-index: auto;
        }
        .auto-style3 {
            margin-right: 0px;
        }
    </style>
</head>
<body style="height: 1094px">
    <form id="form1" runat="server" style="background-image: url('Login.aspx'); background-color: #008000;">
        <div class="auto-style2" style="border: thin solid #000000; background-color: #00FFFF; background-image: inherit; clip: rect(auto, auto, auto, auto);">
            <h3>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Login Page</h3>  
            <table class="auto-style3">  
                <tr>  
                    <td class="auto-style1">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <br />
                        UserName:</td>  
                    <td class="auto-style1">&nbsp;&nbsp; 
                        <br />
                        <asp:TextBox ID="txtUserName" runat="server" /></td>  
                    <td class="auto-style1"><asp:Label ID="txtUserNameMsg" ForeColor="red" runat="server" /></td>  
                </tr> 
                <tr>  
                    <td>
                        <br />
                        Password:</td>  
                    <td>
                        <br />
                        <asp:TextBox ID="txtUserPass" TextMode="Password" runat="server" /></td>  
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="txtUserPassMsg" ForeColor="red" runat="server" /></td>  
                </tr>
                <tr>  
                    <td></td>  
                    <td>
                        <br />
                        <asp:Button ID="btnLogin" Text="Log In" runat="server" OnClick="btnLogin_Click" BackColor="#009933" ForeColor="Black"/></td>  
                </tr>
            </table>  
            <p><asp:Label ID="errorMsg" ForeColor="red" runat="server" /></p>  
        </div>
    </form>
</body>
</html>
