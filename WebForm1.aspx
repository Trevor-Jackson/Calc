<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Calculator.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
        #form1 {
            text-align: center;
        }
        .auto-style2 {
            font-size: large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="auto-style1">
    
        <strong><span class="auto-style2">Simple Calculator<br />
        </span></strong>
        <br />
&nbsp; First Value&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Second Value<br />
        <asp:TextBox ID="FirstBox" runat="server" Width="99px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="secondBox" runat="server" Width="99px"></asp:TextBox>
    
    </div>
        <div class="auto-style1">
&nbsp;<br />
&nbsp;<asp:Button ID="plusButton" runat="server" OnClick="plusButton_Click" Text="+" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="minusButton" runat="server" OnClick="minusButton_Click" Text="-" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="divideButton" runat="server" OnClick="divideButton_Click" Text="/" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="multiplyButton" runat="server" OnClick="multiplyButton_Click" Text="*" />
            <br />
            <br />
            <asp:Button ID="ResetButton" runat="server" OnClick="ResetButton_Click" Text="Reset" />
            <br />
            <br />
&nbsp;&nbsp;
            <asp:Label ID="resultLabel" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Error" runat="server" style="color: #FF0000"></asp:Label>
            <br />
            <br />
            <asp:Label ID="exceptionType" runat="server" style="color: #FF0000"></asp:Label>
        </div>
    </form>
</body>
</html>
