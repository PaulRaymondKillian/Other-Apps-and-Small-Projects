<%@ Page Language="vb" AutoEventWireup="false" 
    CodeBehind="OneWayBindingEditPageExample02.aspx.vb" 
    Inherits="Web.Demos.WebUI.OneWayBindingEditPageExample02" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Binding With Eval</title>
</head>
<body>
    <form id="form1" runat="server">
    <%-- 
    NOTE:  In order to use Eval you need to use a databound control. 
    --%>
    <div>
        <asp:FormView ID="fvwResource" runat="server"
            DefaultMode="Edit"> 
    
            <EditItemTemplate>
                <asp:HiddenField ID="hdnId" runat="server" 
                    Value='<%# DirectCast(Container.DataItem, Web.Demos.WebUI.Resource).Id %>' />
                <div>
                    Title: <asp:TextBox ID="txtTitle" runat="server"
                        Text='<%# DirectCast(Container.DataItem, Web.Demos.WebUI.Resource).Title %>'></asp:TextBox>
                </div>
                <div>
                    <%-- 
                        Uses Reflection and is therefore slower than accessing Container directly.
                    --%>
                    Asset Number: <asp:TextBox ID="txtAssetNumber" runat="server"
                        Text='<%# DataBinder.Eval(Container.DataItem, "AssetNumber") %>'></asp:TextBox>
                </div>
                <div>
                    <%-- 
                        Uses shortcut form of DataBinder.Eval("AssetNumber") --%>
                    Publisher: <asp:TextBox ID="txtPublisher" runat="server"
                        Text='<%# Eval("Publisher") %>'></asp:TextBox>
                </div>
                <div>
                    Version: <asp:Label ID="lblVersion" runat="server"
                        Text='<%# Eval("Version") %>'></asp:Label>
                </div>
            </EditItemTemplate>
        </asp:FormView>-
         
        <asp:DataList runat="server" ID="dlTest" >
        
            <EditItemTemplate>
            </EditItemTemplate>
            <FooterTemplate>
                aklsdfjklasdfj aslkdfaslk;dfjaslkdf jaslk;dfj
            </FooterTemplate>
            <ItemTemplate>
                 <asp:HiddenField ID="hdnId" runat="server" 
                    Value='<%# DirectCast(Container.DataItem, Web.Demos.WebUI.Resource).Id %>' />
                <div>
                    Title: <asp:TextBox ID="txtTitle" runat="server"
                        Text='<%# DirectCast(Container.DataItem, Web.Demos.WebUI.Resource).Title %>'></asp:TextBox>
                </div>
                <div>
                    <%-- 
                        Uses Reflection and is therefore slower than accessing Container directly.
                    --%>
                    Asset Number: <asp:TextBox ID="txtAssetNumber" runat="server"
                        Text='<%# DataBinder.Eval(Container.DataItem, "AssetNumber") %>'></asp:TextBox>
                </div>
                <div>
                    <%-- 
                        Uses shortcut form of DataBinder.Eval("AssetNumber") --%>
                    Publisher: <asp:TextBox ID="txtPublisher" runat="server"
                        Text='<%# Eval("Publisher") %>'></asp:TextBox>
                </div>
                <div>
                    Version: <asp:Label ID="lblVersion" runat="server"
                        Text='<%# Eval("Version") %>'></asp:Label>
                </div>
            </ItemTemplate>
        </asp:DataList>
        
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
