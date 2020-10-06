
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="teste.aspx.cs" Inherits="Apicativo_AspNet_FW.teste" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
	<link href="~/Content/bootstrap.theme.css" rel="stylesheet" media="screen" />

</head>
<body>
	<form class="form-horizontal" id="form1" runat="server">

        <div class="jumbotron">
        	<table style="width:100%;">
				<tr>
					<td>ID</td>
					<td>&nbsp;</td>
					<td>
						<asp:TextBox ID="txtID" runat="server" Width="123px"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td>Professor</td>
					<td>&nbsp;</td>
					<td>
						<asp:TextBox ID="txtProfessor" runat="server" Width="365px"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td>Sala</td>
					<td>&nbsp;</td>
					<td>
						<asp:TextBox ID="txtSala" runat="server" Width="363px"></asp:TextBox>
					</td>
				</tr>
				<tr>
					<td>&nbsp;</td>
					<td>&nbsp;</td>
					<td>
						<asp:Button ID="btnConecta" runat="server" OnClick="btnConecta_Click" Text="Conecta" />
					</td>
				</tr>
			</table>
        </div>
    </form>
</body>
</html>
