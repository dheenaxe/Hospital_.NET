<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HastaEkle.aspx.cs" Inherits="Hospital.Web.HastaEkle" %>

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
            <td>Hasta Adı</td>
            <td>:</td>
            <td><asp:TextBox runat="server" ID="txtAdi"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Hasta Soyadı</td>
            <td>:</td>
            <td><asp:TextBox runat="server" ID="txtSoyadi"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Hasta Doğum Yılı</td>
            <td>:</td>
            <td><asp:TextBox runat="server" ID="txtDogum"></asp:TextBox></td>
        </tr>
        <tr>
            <td></td>
            <td><asp:Button runat="server" ID="btnKaydet" Text="Kaydet" OnClick="btnKaydet_Click" /></td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
