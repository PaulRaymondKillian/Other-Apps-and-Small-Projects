<%@ Page Language="vb" AutoEventWireup="false" 
    CodeBehind="ListEditBindingExample04.aspx.vb" 
    Inherits="Web.Demos.WebUI.ListEditBindingExample04" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>List/Edit Binding Example 04</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Panel ID="pnlSearch" runat="server">
            <div>Search by Title: 
                <asp:TextBox ID="txtTitleFilter" runat="server"></asp:TextBox>
                <asp:Button ID="btnSearch"
                    runat="server" Text="Search" />
            </div>
            <div>
                <asp:LinkButton ID="lnkOpenInsertWindow" runat="server" Text="Open Insert Window"  />
            </div>
            <br />
        </asp:Panel>
        <asp:GridView ID="gvwResources" runat="server"
            DataSourceID="odsResources"
            AutoGenerateColumns="false"
            DataKeyNames="Id"
            AllowPaging="true"
            PageSize="2"
            BorderStyle="None" 
            SelectedRowStyle-BackColor="LightBlue"
            CellPadding="5"
            CellSpacing="5">
            <PagerSettings Mode="NumericFirstLast" 
                PreviousPageText="Previous"
                NextPageText="Next"
                PageButtonCount="5"
                Position="Bottom"
            />

            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:HiddenField ID="hdnId" runat="server" 
                            Value='<%# Eval("Id") %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Label ID="txtTitle" runat="server" Font-Bold="true"
                            Text='<%# Eval("Title") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        Asset Number: <asp:Label ID="txtAssetNumber" runat="server"
                        Text='<%# Eval("AssetNumber") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        Publisher: <asp:Label ID="txtPublisher" runat="server"
                        Text='<%# Eval("Publisher") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                 <asp:TemplateField>
                    <ItemTemplate>
                        Date Published: <asp:Label ID="txtDatePublished" runat="server"
                        Text='<%# Eval("DatePublished") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkBtnClone" runat="server" Text="Clone" 
                            CommandName="Select"
                            CommandArgument='<%# GetOdsCloneArgs(Container.DataItem) %>' />
                    </ItemTemplate>
                  </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkBtnEdit" runat="server" Text="Edit" 
                            CommandName="Select"
                            CommandArgument='<%# GetOdsEditArgs(Container.DataItem) %>' />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton ID="lnkBtnDelete" runat="server" Text="Delete" 
                            CommandName="Delete"/>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:FormView ID="fvwEditResource" runat="server"
            DataSourceID="odsResourceEdit"
            Visible="false"
            DefaultMode="Edit"
            BorderStyle="None">
            <EditItemTemplate>
                <asp:HiddenField ID="hdnId" runat="server" 
                    Value='<%# Bind("Id") %>' />
                <asp:HiddenField ID="hdnEditMode" runat="server" 
                    Value='<%# Bind("EditMode") %>' />
                <div>
                    <asp:Label ID="Label1" runat="server" Text="Title"></asp:Label>
                    <asp:TextBox ID="txtTitle" runat="server"
                        Text='<%# Bind("Title") %>'></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="Label2" runat="server" Text="Asset Number"></asp:Label>
                    <asp:TextBox ID="txtAssetNumber" runat="server"
                        Text='<%# Bind("AssetNumber") %>'></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="Label3" runat="server" Text="Publisher"></asp:Label>
                    <asp:TextBox ID="txtPublisher" runat="server"
                        Text='<%# Bind("Publisher") %>'></asp:TextBox>
                </div>
                <div>
                    <asp:Label ID="Label4" runat="server" Text="Date Published"></asp:Label>
                    <asp:TextBox ID="TextDatePublished" runat="server"
                        Text='<%# Bind("DatePublished") %>'></asp:TextBox>
                </div>
                <div>
                    <asp:LinkButton ID="lnkBtnSave" runat="server" 
                        Text='<%# GetEditPageSaveButtonText() %>' CommandName="Update" />
                    <asp:LinkButton ID="lnkBtnCancel" runat="server" 
                        Text="Cancel" CommandName="Cancel" />
                </div>
            </EditItemTemplate>
        </asp:FormView>
        <asp:ObjectDataSource ID="odsResources" runat="server" 
            TypeName="Web.Demos.WebUI.ResourceDS"
            SortParameterName="filterParamters"
            EnablePaging="true" 
            MaximumRowsParameterName="itemsPerPage"
            StartRowIndexParameterName="itemsToSkip"
            SelectCountMethod="SelectCount" 
            SelectMethod="SelectAllWithPaging" 
            DeleteMethod="DeleteById">
        </asp:ObjectDataSource>
        <asp:ObjectDataSource ID="odsResourceEdit" runat="server" 
            TypeName="Web.Demos.WebUI.ResourceDS"
            DataObjectTypeName="Web.Demos.WebUI.Resource"
            SelectMethod="SelectOne" 
            UpdateMethod="MultiPurposeUpdate">
        </asp:ObjectDataSource>
    </div>
    </form>
</body>
</html>
