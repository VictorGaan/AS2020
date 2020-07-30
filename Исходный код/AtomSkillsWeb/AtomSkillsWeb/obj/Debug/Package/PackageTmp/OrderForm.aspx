<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="OrderForm.aspx.cs" EnableEventValidation="false" Inherits="AtomSkillsWeb.OrderForm" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Заказы</title>
    <style>
        body {
            background-color: purple;
            margin: 0;
            padding: 0;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Table runat="server">
            <asp:TableRow>
                <asp:TableCell>
                   <asp:Label ForeColor="White" Font-Size="18" Font-Bold="true" runat="server" Text="Мои поездки"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox BorderColor="#00bfff" ForeColor="Black" runat="server" ID="TbArea1" Height="40px" Width="350px"></asp:TextBox>
                    <asp:TextBox BorderColor="#00bfff" ForeColor="Black" runat="server" ID="TbArea2" Height="40px" Width="350px"></asp:TextBox>
                    <asp:Button ID="BtnFilter" OnClick="BtnFilter_Click" runat="server" BackColor="#FF85E780" ForeColor="#202020" Text="Фильтр" Height="40px" Width="350px" />
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:DataGrid runat="server" ID="OrdersGrid" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundColumn ItemStyle-ForeColor="White" HeaderStyle-ForeColor="White" HeaderText="Место отправления" DataField="AddressFrom"></asp:BoundColumn>
                            <asp:BoundColumn ItemStyle-ForeColor="White" HeaderStyle-ForeColor="White" HeaderText="Место прибытия" DataField="AddressTo"></asp:BoundColumn>
                            <asp:BoundColumn ItemStyle-ForeColor="White" HeaderStyle-ForeColor="White" HeaderText="Время заказа" DataField="Date"></asp:BoundColumn>
                            <asp:BoundColumn ItemStyle-ForeColor="White" HeaderStyle-ForeColor="White" HeaderText="Цена" DataField="Price"></asp:BoundColumn>
                            <asp:TemplateColumn ItemStyle-ForeColor="White" HeaderStyle-ForeColor="White" HeaderText="Отмена">
                                <ItemTemplate>
                                    <asp:Button  ID="BtnCancel" CommandName="BtnCancel" OnClick="BtnCancel_Click" runat="server" BackColor="#FF85E780" ForeColor="#202020" Text="Отмена" Height="40px" Width="100px"/>
                                </ItemTemplate>
                            </asp:TemplateColumn>
                        </Columns>
                    </asp:DataGrid>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                   <asp:Label ForeColor="White" Font-Size="18" Font-Bold="true" runat="server" Text="Новая поездка"></asp:Label>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox BorderColor="#00bfff" ForeColor="Black" runat="server" ID="TbAreaFrom" Height="40px" Width="350px"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:TextBox BorderColor="#00bfff" ForeColor="Black" runat="server" ID="TbAreaTo" Height="40px" Width="350px"></asp:TextBox>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                    <asp:DropDownList runat="server" ID="PriceList">
                        <asp:ListItem Enabled="true" Text="Выберите тип" Value="-1"></asp:ListItem>
                        <asp:ListItem Text="Эконом" Value="120"></asp:ListItem>
                        <asp:ListItem Text="Бизнес" Value="240"></asp:ListItem>
                        <asp:ListItem Text="Премиум" Value="360"></asp:ListItem>
                    </asp:DropDownList>
                </asp:TableCell>
            </asp:TableRow>
            <asp:TableRow>
                <asp:TableCell>
                   <asp:Button ID="BtnGo" OnClick="BtnGo_Click" runat="server" BackColor="#FF85E780" ForeColor="#202020" Text="Поехали" Height="40px" Width="350px" />
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
    </form>
</body>
</html>
