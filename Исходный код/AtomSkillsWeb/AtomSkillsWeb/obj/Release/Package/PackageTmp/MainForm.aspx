<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="AtomSkillsWeb.MainForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Авторизация</title>
    <style>
         body {
            background: url(img/flying-taxi.jpg) no-repeat;
            background-color: #484848;
            margin: 0;
            padding: 0;
        }
    </style>
</head>
<body>
    <form runat="server">
        <asp:Table runat="server">
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ForeColor="White" Font-Size="18" Font-Bold="true" runat="server" Text="DRON TAXI"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label ForeColor="White" Font-Size="18" Font-Bold="true" runat="server" Text="Авторизация"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" ForeColor="White" Font-Size="14" Font-Bold="true">Логин</asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox BorderColor="#00bfff" ForeColor="Black" runat="server" ID="TbLogin" Height="40px" Width="350px"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Label runat="server" ForeColor="White" Font-Size="14" Font-Bold="true">Пароль</asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox TextMode="Password" BorderColor="#00bfff" ForeColor="Black" runat="server" ID="TbPassword" Height="40px" Width="350px"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:CheckBox BorderColor="#00BFFF" ID="ChLogin" runat="server" AutoPostBack="true" Text="Запомнить" ForeColor="White" />
                    <asp:Button BorderColor="#FFFFFF" BackColor="#00BFFF" ForeColor="#FFFFFF" Text="Войти" Height="40px" Width="125px" ID="BtnEnter" runat="server" OnClick="BtnEnter_Click" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:Button BackColor="#FF85E780" ForeColor="#202020" Text="Регистрация" Height="40px" Width="350px" ID="BtnReg" runat="server" OnClick="BtnReg_Click"/>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </form>
</body>
</html>
