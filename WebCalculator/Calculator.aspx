<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="WebCalculator.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 420px;
            width: 246px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="resultBox" runat="server" Height="36px" Width="243px"></asp:TextBox>
        </div>
        <asp:Button ID="ButtonPer" runat="server" OnClick="ButtonPer_Click" Text="%" />
        <asp:Button ID="ButtonRoot" runat="server" OnClick="ButtonRoot_Click" Text="√" />
        <asp:Button ID="ButtonSqr" runat="server" OnClick="ButtonSqr_Click" Text="x^2" />
        <asp:Button ID="ButtonDiv" runat="server" OnClick="ButtonDiv_Click" Text="/" />
        <asp:Button ID="ButtonMult" runat="server" OnClick="ButtonMult_Click" Text="x" />
        <asp:Button ID="ButtonSum" runat="server" OnClick="ButtonSum_Click" Text="+" />
        <asp:Button ID="ButtonSub" runat="server" OnClick="ButtonSub_Click" Text="-" />
        <asp:Button ID="ButtonDott" runat="server" OnClick="ButtonDott_Click" Text="." />
        <asp:Button ID="ButtonEqual" runat="server" OnClick="ButtonEqual_Click" Text="=" />
        <asp:Button ID="ButtonClear" runat="server" OnClick="ButtonClear_Click" Text="Clear" />
        <asp:Button ID="Button09" runat="server" OnClick="Button09_Click" Text="9" />
        <asp:Button ID="Button08" runat="server" OnClick="Button08_Click" Text="8" />
        <asp:Button ID="Button07" runat="server" OnClick="Button07_Click" Text="7" />
        <asp:Button ID="Button06" runat="server" OnClick="Button06_Click" Text="6" />
        <asp:Button ID="Button05" runat="server" OnClick="Button05_Click" Text="5" />
        <asp:Button ID="Button04" runat="server" OnClick="Button04_Click" Text="4" />
        <asp:Button ID="Button03" runat="server" OnClick="Button03_Click" Text="3" />
        <asp:Button ID="Button02" runat="server" OnClick="Button02_Click" Text="2" />
        <asp:Button ID="Button01" runat="server" OnClick="Button01_Click" Text="1" />
        <asp:Button ID="Button0" runat="server" OnClick="Button0_Click" Text="0" />
        <asp:Button ID="ButtonErase" runat="server" OnClick="ButtonErase_Click" Text="&lt;=" />
    </form>
</body>
</html>
