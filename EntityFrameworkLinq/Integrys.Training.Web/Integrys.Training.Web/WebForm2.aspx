<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm2.aspx.vb" Inherits="Integrys.Training.Web.WebForm2" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
 
        <asp:FormView ID="fvwResource" runat="server"
            DataSourceId="ObjectDataSource1"
            DefaultMode="Edit"> 
    
            <EditItemTemplate>
                <asp:HiddenField ID="hdnId" runat="server" 
                    Value='<%# Bind("CustId") %>' />
                <div>
                    Title: <asp:TextBox ID="txtTitle" runat="server"
                        Text='<%# Bind("CustFullNm") %>'></asp:TextBox>
                </div>
                <div>
                    <%-- 
                        Uses Reflection and is therefore slower than accessing Container directly.
                    --%>
                    Asset Number: <asp:TextBox ID="txtAssetNumber" runat="server"
                        Text='<%# Bind("CustTypeCd") %>'></asp:TextBox>
                </div>
                <div>
                    <%-- 
                        Uses shortcut form of DataBinder.Eval("AssetNumber") --%>
                    Publisher: <asp:TextBox ID="txtPublisher" runat="server"
                        Text='<%# Bind("CustStatusCd") %>'></asp:TextBox>
                </div>
                <div>
                    Version: <asp:Label ID="lblVersion" runat="server"
                        Text='<%# Eval("tid") %>'></asp:Label>
                </div>
                <div>
                    <asp:Button ID="btnSave" runat="server" Text="Save" CommandName="Update" />
                </div>
            </EditItemTemplate>
        </asp:FormView>
    
    </div>

    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" 
        SelectMethod="FindCustomersPaul" 
        TypeName="Integrys.Training.Domain.CustomerRepository">
    </asp:ObjectDataSource>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="ObjectDataSource1" AllowPaging="True">
        <Columns>
            <asp:BoundField DataField="CustId" HeaderText="CustId" 
                SortExpression="CustId" />
            <asp:BoundField DataField="CustStatusCd" HeaderText="CustStatusCd" 
                SortExpression="CustStatusCd" />
            <asp:BoundField DataField="CustTypeCd" HeaderText="CustTypeCd" 
                SortExpression="CustTypeCd" />
            <asp:BoundField DataField="CustFullNm" HeaderText="CustFullNm" 
                SortExpression="CustFullNm" />
            <asp:BoundField DataField="BeginDt" HeaderText="BeginDt" 
                SortExpression="BeginDt" />
            <asp:BoundField DataField="CnvDt" HeaderText="CnvDt" SortExpression="CnvDt" />
            <asp:BoundField DataField="FirstNm" HeaderText="FirstNm" 
                SortExpression="FirstNm" />
            <asp:BoundField DataField="MiddleNm" HeaderText="MiddleNm" 
                SortExpression="MiddleNm" />
            <asp:BoundField DataField="LastNm" HeaderText="LastNm" 
                SortExpression="LastNm" />
            <asp:BoundField DataField="NamePrefixTxt" HeaderText="NamePrefixTxt" 
                SortExpression="NamePrefixTxt" />
            <asp:BoundField DataField="NameSuffixTxt" HeaderText="NameSuffixTxt" 
                SortExpression="NameSuffixTxt" />
            <asp:BoundField DataField="DoingBusinessAsNm" HeaderText="DoingBusinessAsNm" 
                SortExpression="DoingBusinessAsNm" />
            <asp:BoundField DataField="TaxId" HeaderText="TaxId" SortExpression="TaxId" />
            <asp:BoundField DataField="SocSecNum" HeaderText="SocSecNum" 
                SortExpression="SocSecNum" />
            <asp:BoundField DataField="ChngRsnRmkLogId" HeaderText="ChngRsnRmkLogId" 
                SortExpression="ChngRsnRmkLogId" />
            <asp:BoundField DataField="SysTxnId" HeaderText="SysTxnId" 
                SortExpression="SysTxnId" />
            <asp:BoundField DataField="tid" HeaderText="tid" SortExpression="tid" />
        </Columns>
    </asp:GridView>
    </form>
</body>
</html>
