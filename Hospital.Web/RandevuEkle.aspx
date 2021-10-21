<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandevuEkle.aspx.cs" Inherits="Hospital.Web.RandevuEkle" %>

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
            <td>Başlangıç Saati</td>
            <td>:</td>
            <td><asp:TextBox runat="server" ID="txtbaslangic"></asp:TextBox></td>
        </tr>
        <tr>
            <td>Bitis Saati</td>
            <td>:</td>
            <td><asp:TextBox runat="server" ID="txtbitis"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Button runat="server" ID="btnKaydet" Text="Kaydet"  OnClick="btnKaydet_Click"/></td>
        </tr>        
    </table>
        12.00 ve 13.00 Saatleri Arası Dahil Değildir.
    </div>
    </form>
</body>
</html>
