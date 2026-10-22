<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Integrys.Training.Web.WebForm1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>

    <asp:Panel ID="pnlEditPanel" runat="server">
            <asp:HiddenField ID="hdnId" runat="server" Value='' />
            <div>
               CustId: <asp:TextBox ID="txtCustId" runat="server"
                    Text=''></asp:TextBox>
            </div>
            <div>
               Name: <asp:TextBox ID="txtName" runat="server"
                    Text=''></asp:TextBox>
            </div>
        </asp:Panel>
        <div>
            <asp:Button ID="btnSave" runat="server" Text="Save" />
        </div>
    
    </div>
    </form>
</body>
</html>
