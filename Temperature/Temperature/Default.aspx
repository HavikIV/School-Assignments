<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="Temperature._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Temperature Converter</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <p style="height: 34px">
            Enter the Temperature in Fahrenheit:&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Required Entry" ForeColor="Red"></asp:RequiredFieldValidator>
        </p>
        <p style="height: 34px">
            The Temperature in Celsius:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblCelsius" runat="server"></asp:Label>
        </p>
        <div style="margin-left: 200px">
            <asp:Button ID="btnCalculate" runat="server" Text="Calculate" />
        </div>
    </form>
</body>
</html>
