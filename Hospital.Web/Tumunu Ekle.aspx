<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Tumunu Ekle.aspx.cs" Inherits="Hospital.Web.Tumunu_Ekle" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
        <tr>
            <td>Hasta Adı, Soyadı ve Doğum Tarihi</td>
            <td>
                <asp:DropDownList ID="ddHAdi" runat="server"></asp:DropDownList>

            </td>
            <td>
                <asp:DropDownList ID="ddHSoy" runat="server"></asp:DropDownList>
            </td>
            <td>
                <asp:DropDownList ID="ddDogum" runat="server"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Gideceği Branş</td>
            <td>
                <asp:DropDownList ID="ddBrans" runat="server"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>Randevu Saati</td>
            <td>
                <asp:DropDownList ID="ddRandevuBaslangic" runat="server"></asp:DropDownList>
            </td>
               <td>
                <asp:DropDownList ID="ddRandevuBitis" runat="server"></asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td><asp:Button runat="server" ID="btnKaydet" Text="Kaydet" OnClick="btnKaydet_Click" /></td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
