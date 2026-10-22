<%@ Page Language="vb" AutoEventWireup="false" 
    CodeBehind="ManualBindingEditPage.aspx.vb" 
    Inherits="Web.Demos.WebUI.ManualBindingEditPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Manual Binding</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="pnlEditPanel" runat="server">
            <asp:HiddenField ID="hdnId" runat="server" Value='' />
            <div>
                Title: <asp:TextBox ID="txtTitle" runat="server"
                    Text=''></asp:TextBox>
            </div>
            <div>
                Asset Number: <asp:TextBox ID="txtAssetNumber" runat="server"
                    Text=''></asp:TextBox>
            </div>
            <div>
                Publisher: <asp:TextBox ID="txtPublisher" runat="server"
                    Text=''></asp:TextBox>
            </div>
            <div>
                Version: <asp:Label ID="lblVersion" runat="server"
                    Text=''></asp:Label>
            </div>
        </asp:Panel>
        <div>
            <asp:Button ID="btnSave" runat="server" Text="Save" />
        </div>
        <div>
            <a href="ListPage.aspx">Return to List Page</a>
        </div>
    </div>
    </form>
</body>
</html>
