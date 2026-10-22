<%@ Page Language="vb" AutoEventWireup="false" 
    CodeBehind="TwoWayBindingEditPage.aspx.vb" 
    Inherits="Web.Demos.WebUI.TwoWayBindingEditPage" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Two-Way Binding with Object Data Source</title>
</head>
<body>
    <form id="form1" runat="server">
    <%-- 
    NOTE:  In order to use Eval you need to use a databound control. 
    --%>
    <div>
        <asp:FormView ID="fvwResource" runat="server"
            DataSourceId="odsResourceForEdit"
            DefaultMode="Edit"> 
    
            <EditItemTemplate>
                <asp:HiddenField ID="hdnId" runat="server" 
                    Value='<%# Bind("Id") %>' />
                <div>
                    Title: <asp:TextBox ID="txtTitle" runat="server"
                        Text='<%# Bind("Title") %>'></asp:TextBox>
                </div>
                <div>
                    <%-- 
                        Uses Reflection and is therefore slower than accessing Container directly.
                    --%>
                    Asset Number: <asp:TextBox ID="txtAssetNumber" runat="server"
                        Text='<%# Bind("AssetNumber") %>'></asp:TextBox>
                </div>
                <div>
                    <%-- 
                        Uses shortcut form of DataBinder.Eval("AssetNumber") --%>
                    Publisher: <asp:TextBox ID="txtPublisher" runat="server"
                        Text='<%# Bind("Publisher") %>'></asp:TextBox>
                </div>
                <div>
                    Version: <asp:Label ID="lblVersion" runat="server"
                        Text='<%# Eval("Version") %>'></asp:Label>
                </div>
                <div>
                    <asp:Button ID="btnSave" runat="server" Text="Save" CommandName="Update" />
                </div>
            </EditItemTemplate>
        </asp:FormView>
        <div>
            <a href="ListPage.aspx">Return to List Page</a>
        </div>
    </div>
    <asp:ObjectDataSource ID="odsResourceForEdit" runat="server" 
        TypeName="Web.Demos.WebUI.ResourceDS"
        DataObjectTypeName="Web.Demos.WebUI.Resource"
        SelectMethod="SelectOne"
        UpdateMethod="Update"

        
        >
        <SelectParameters>
    
            <asp:SessionParameter SessionField="Id" Name="id" />
        </SelectParameters>
    </asp:ObjectDataSource>
    </form>
</body>
</html>
