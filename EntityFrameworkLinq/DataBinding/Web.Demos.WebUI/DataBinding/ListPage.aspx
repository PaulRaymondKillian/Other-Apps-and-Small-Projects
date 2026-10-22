<%@ Page Language="vb" AutoEventWireup="false" 
    CodeBehind="ListPage.aspx.vb" 
    Inherits="Web.Demos.WebUI.ListPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Launch Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            <asp:ListBox ID="lboxResources" runat="server" 
                DataTextField="Title"
                DataValueField="Id"/>
        </div>
        <div>
            <asp:LinkButton ID="lbtnManualBindingEdit" runat="server"
                Text="Edit with Manual Binding Edit Page" />
        </div>
        <div>
            <asp:LinkButton ID="lbtnOneWayBindingEditExample01" runat="server" 
                Text="Edit with One Way Binding with Binding Expressions Edit Page" />
        </div>
        <div>
            <asp:LinkButton ID="lbtnOneWayBindingEditExample02" runat="server" 
                Text="Edit with One Way Binding and a Rich Data Control" />
        </div>
        <div>
            <asp:LinkButton ID="lbtnTwoWayBindingEdit" runat="server" 
                Text="Edit with Two Way Binding and a Rich Data Control" />
        </div>
    </div>
    </form>
</body>
</html>
