<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BransEkle.aspx.cs" Inherits="Hospital.Web.BransEkle" %>

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
            <td>Branş Ekle</td>
            <td>:</td>
            <td><asp:TextBox runat="server" ID="txtBrans"></asp:TextBox></td>
        </tr>
        <tr>
            <td><asp:Button runat="server" ID="btnKaydet" Text="Kaydet" Onclick="btnKaydet_Click"/></td>
        </tr>
    </table>
    </div>
    </form>
</body>
</html>
