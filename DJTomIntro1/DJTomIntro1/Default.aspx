<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>DJ TOM</title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
        }
    </style>
</head>
<body style="font-family:'Segoe UI', Arial, sans-serif">
    <form id="form1" runat="server">
    <div>
    
        <h1 class="auto-style1">Your Wedding DJ</h1>
        <br />
        <div id="MessageColumn"
            style="width:30%; background-color:purple;
            float:left">
            <asp:Label ID="lblMsg" runat="server" ForeColor="White"></asp:Label>
        </div>
        <div id="ContentColumn" style="width:39%; float:left">
            <asp:Table ID="Table1" runat="server" CellSpacing="40" HorizontalAlign="Center">
                <asp:TableRow ID="tblRow1" runat="server">
                    <asp:TableCell ID="tblRow1Col1" runat="server">Bride:</asp:TableCell>
                    <asp:TableCell ID="tblRow1Col2" runat="server">
                        <asp:TextBox ID="txtBride" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow ID="tblRow2" runat="server">
                    <asp:TableCell ID="tblRow2Col1" runat="server">Groom:</asp:TableCell>
                    <asp:TableCell ID="tblRow2Col2" runat="server">
                        <asp:TextBox ID="txtGroom" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow ID="tblRow3" runat="server">
                    <asp:TableCell ID="tblRow3Col1" runat="server">Wedding:</asp:TableCell>
                    <asp:TableCell ID="tblRow3Col2" runat="server">
                        <asp:Calendar ID="calWedding" runat="server"></asp:Calendar>  
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow ID="tblRow4" runat="server">
                    <asp:TableCell ID="tblRow4Col1" runat="server">E-mail:<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtEmail" ErrorMessage="  Invaild" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></asp:TableCell>
                    <asp:TableCell ID="tblRow4Col2" runat="server">
                        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow ID="tblRow5" runat="server">
                    <asp:TableCell ID="tblRow5Col1" runat="server">First song:</asp:TableCell>
                    <asp:TableCell ID="tblRow5Col2" runat="server">
                        <asp:DropDownList ID="ddlSongs" runat="server">
                            <asp:ListItem Text="From This Moment On"></asp:ListItem>
                            <asp:ListItem Text="At Last"></asp:ListItem>
                            <asp:ListItem Text="Because You Loved Me"></asp:ListItem>
                            <asp:ListItem Text="The Way You Look Tonight"></asp:ListItem>
                        </asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow ID="tblRow6" runat="server">
                    <asp:TableCell ID="tblRow6Col1" runat="server">
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" />
                    </asp:TableCell>
                </asp:TableRow>
            </asp:Table>
        </div>
        <div id="LogoColumn" style="width:30%; float:right">
            <asp:Image ID="Image1" runat="server" ImageUrl="~/DJ.png" />
        </div>
    </div>
    </form>
</body>
</html>
