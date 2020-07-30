<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegForm.aspx.cs" Inherits="AtomSkillsWeb.RegForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Регистрация</title>
    <style>
        body {
            background: url(img/flying-taxi.jpg) no-repeat;
            background-color: #484848;
            margin: 0;
            padding: 0;
        }

        form {
            width: 300px;
            margin: 200px auto;
        }
    </style>
    <style>
    </style>
</head>
<body>
    <form runat="server">
        <asp:Table runat="server" BackColor="Purple">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ForeColor="White" Font-Bold="true" Font-Size="16" runat="server" Text="Регистрация"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ForeColor="White" Font-Bold="true" Font-Size="12" runat="server" Text="Фамилия*"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox BorderColor="#00bfff" ForeColor="Black" runat="server" ID="TbLastName" Height="40px" Width="350px"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ForeColor="White" Font-Bold="true" Font-Size="12" runat="server" Text="Имя*"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox BorderColor="#00bfff" ForeColor="Black" runat="server" ID="TbFirstName" Height="40px" Width="350px"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ForeColor="White" Font-Bold="true" Font-Size="12" runat="server" Text="Отчество"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox BorderColor="#00bfff" ForeColor="Black" runat="server" ID="TbMiddleName" Height="40px" Width="350px"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ForeColor="White" Font-Bold="true" Font-Size="12" runat="server" Text="Email*"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox TextMode="Email" BorderColor="#00bfff" ForeColor="Black" runat="server" ID="TbEmail" Height="40px" Width="350px"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ForeColor="White" Font-Bold="true" Font-Size="12" runat="server" Text="Пароль*"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox TextMode="Password" BorderColor="#00bfff" ForeColor="Black" runat="server" ID="TbPassword" Height="40px" Width="350px"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ForeColor="White" Font-Bold="true" Font-Size="12" runat="server" Text="Подтвердите пароль*"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox TextMode="Password" BorderColor="#00bfff" ForeColor="Black" runat="server" ID="TbPasswordSubmit" Height="40px" Width="350px"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button BackColor="#FF85E780" ForeColor="#202020" Text="Регистрация" Height="40px" Width="350px" ID="BtnReg" runat="server" OnClick="BtnReg_Click" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </form>
</body>
</html>
