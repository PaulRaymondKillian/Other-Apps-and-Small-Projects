Imports System.Configuration
Imports System.Diagnostics.Contracts

Public Class CustomerRepository

    Private Context As dbDEVCisTEntities

    Public Sub New()
        Me.Context = New dbDEVCisTEntities(ConfigurationManager.ConnectionStrings("dbDEVCisTEntities").ConnectionString)
    End Sub

    Public Function FindActiveContractsInRegionCd(pRegionCd As String) As IList(Of tContract)
        Dim query = From contract In Me.Context.tContracts
                    Where contract.tContractServicePremiseServices.FirstOrDefault.tPremise.RegionCd = pRegionCd
                    Select contract

        Return query.ToList()
    End Function

    Public Function FindActiveContractsInZipcode(pZipcode As Integer) As IEnumerable
        Dim query = From contract In Me.Context.tContracts
                    From contractpremise In Me.Context.tContractServicePremiseServices
                    From premise In Me.Context.tPremises
                    From address In Me.Context.tAddresses
                    Where contract.CustId = contractpremise.CustId AndAlso _
                    contract.ContractSeqNum = contractpremise.ContractSeqNum AndAlso _
                    contract.tid = contractpremise.tid AndAlso _
                    contractpremise.PremiseId = premise.PremiseId AndAlso _
                    contractpremise.tid = premise.tid AndAlso _
                    premise.AddressId = address.AddressId AndAlso _
                    premise.tid = address.tid AndAlso _
                    address.PostalCd = pZipcode AndAlso _
                    contract.ContractStatusCd = "A"
                    Order By contract.CustId
                    Select New With
                    {
                        contract.CustId,
                        contract.ContractSeqNum,
                        address.PostalCd
                    }

        'query = query.Skip(100).Take(50)    'Adds Paging - Timeout if used on this query...!!!

        Return query.ToList()
    End Function

    Public Function FindActiveContractsInZipcode2(pZipcode As Integer) As IEnumerable
        Dim query = From contract In Me.Context.tContracts
                    Join contractpremise In Me.Context.tContractServicePremiseServices
                    On contract.CustId Equals contractpremise.CustId And _
                    contract.ContractSeqNum Equals contractpremise.ContractSeqNum And _
                    contract.tid Equals contractpremise.tid
                    Join premise In Me.Context.tPremises
                    On contractpremise.PremiseId Equals premise.PremiseId And _
                    contractpremise.tid Equals premise.tid
                    Join address In Me.Context.tAddresses
                    On premise.AddressId Equals address.AddressId And _
                    premise.tid Equals address.tid
                    Where address.PostalCd = pZipcode _
                    AndAlso contract.ContractStatusCd = "A"
                    Order By contract.CustId
                    Select New With
                    {
                        contract.CustId,
                        contract.ContractSeqNum,
                        address.PostalCd
                    }

        'query = query.Skip(100).Take(50)    'Adds Paging - Timeout if used on this query...!!!

        Return query.ToList()
    End Function

    '    Public Function FindCustomersWithActiveContractsInZipcode(pZipcode As Integer) As IList(Of <anonymous>)
    '    Dim query = From customer In Me.Context.Customers
    '                Where customer.tContracts.FirstOrDefault.tContractServicePremiseServices.FirstOrDefault.tPremise.tAddress.PostalCd = pZipcode _
    '                AndAlso customer.tContracts.FirstOrDefault.ContractStatusCd = "A"
    '                Select New With
    '                {
    '                    customer.CustId
    '                }

    '    Return query.ToList()
    'End Function

    Public Function FindCustomer(CustId As Integer) As Customer
        Dim query = (From customer In Me.Context.Customers
                    Join contracts In Me.Context.tContracts
                    On customer.CustId Equals contracts.CustId And customer.tid Equals contracts.tid
                    Where customer.CustId = CustId And customer.tid = "divrTestData20080514"
                    Order By customer.FirstNm
                    Select customer).Single

        Return query
    End Function

    Public Function FindCustomersPaul() As IList(Of Customer)
        'Dim query = From customer In Me.Context.Customers
        '            Join contracts In Me.Context.tContracts
        '            On customer.CustId Equals contracts.CustId And customer.tid Equals contracts.tid
        '            Where customer.FirstNm = "Paul" And contracts.ContractStatusCd = "A"
        '            Select New With
        '            {
        '                customer.CustId,
        '                customer.CustFullNm,
        '                contracts.ContractSeqNum,
        '                contracts.ContractStatusCd
        '            }

        'Dim query = From customer In Me.Context.Customers
        '            Where customer.FirstNm = "Paul" And customer.tContracts.FirstOrDefault.ContractStatusCd = "A"
        '            Select New With
        '            {
        '                customer.CustId,
        '                customer.CustFullNm,
        '                customer.tContracts.FirstOrDefault.ContractSeqNum,
        '                customer.tContracts.FirstOrDefault.ContractStatusCd
        '            }

        'The above are examples of joining tables and such, but return type of this function is a list of customers,
        ''so the return must be of customer, so use the above two as learning aids, but the below is used for this function.
        Dim query = From customer In Me.Context.Customers
                    Join contracts In Me.Context.tContracts
                    On customer.CustId Equals contracts.CustId And customer.tid Equals contracts.tid
                    Where customer.FirstNm = "Paul" And contracts.ContractStatusCd = "A"
                    Order By customer.FirstNm
                    Select customer

        query = query.Skip(100).Take(50)    'Adds Paging (Skip = Page# * #PerPage)(Take = #PerPage)

        Return query.ToList()


    End Function

    Public Sub AddCustomer()
        Dim newCustomer As New Customer
        newCustomer.CustId = 412213727
        newCustomer.CustStatusCd = "A"
        newCustomer.CustTypeCd = "PE"
        newCustomer.CustFullNm = "Paul IS AWESOME"
        newCustomer.BeginDt = Now
        newCustomer.SysTxnId = "manualPRK"
        newCustomer.tid = "dPRKTesting"

        Me.Context.AddToCustomers(newCustomer)
        Me.Context.SaveChanges()


    End Sub
    Public Sub AddCustomer(CustId As Integer, CustStatusCd As Char, CustTypeCd As String, CustFullName As String, BeginDt As Date, SysTxnId As String, TID As String)
        Dim newCustomer As New Customer
        newCustomer.CustId = CustId
        newCustomer.CustStatusCd = CustStatusCd
        newCustomer.CustTypeCd = CustTypeCd
        newCustomer.CustFullNm = CustFullName
        newCustomer.BeginDt = BeginDt
        newCustomer.SysTxnId = SysTxnId
        newCustomer.tid = TID

        Me.Context.AddToCustomers(newCustomer)
        Me.Context.SaveChanges()
    End Sub


    Public Sub ModifyCustomer()
        Dim query = From customer In Me.Context.Customers
                    Where customer.CustId = 412213727 And customer.tid = "dPRKTesting"
                    Select customer

        Dim newCustomer = query.ToList()

        For Each cust In newCustomer
            cust.CustFullNm = "Paul is SUPER AWESOME!"
        Next

        Me.Context.SaveChanges()

    End Sub
    Public Sub DeleteCustomer()
        Dim query = From customer In Me.Context.Customers
                    Where customer.CustId = 412213727 And customer.tid = "dPRKTesting"
                    Select customer

        Dim newCustomer = query.ToList()

        For Each cust In newCustomer
            Me.Context.DeleteObject(cust)
        Next

        Me.Context.SaveChanges()
    End Sub

    Public Function CallStoredProcExample()
        Dim result = Me.Context.xspWPSContractsJM110(402516510, 1, "divrTestData20080514")
        Return result
    End Function

    'DONT DO THIS IN ENTITY FRAMEWORK - Not Good Practice!
    ''Why not good? Because your query is a string, or hardcoded string, there is no type checking, etc. that entity framework gives you
    Public Function CallEntitySQLExample()
        'Your query shold go after the object set entity, not the object or the table name it is mapped to!
        ''That is why the below query is from 'Customers' and not 'tCustomer' or 'Customer'
        Dim query = "SELECT c.CustId, c.CustFullNm FROM Customers as c WHERE c.tid = 'divrTestData20080514'" 'E-SQL (Not T-SQL)

        Dim customers = Me.Context.CreateQuery(Of Common.DbDataRecord)(query)

        Dim results = customers.Execute(Objects.MergeOption.NoTracking)

        'Return customers
        Return results
    End Function

    Public Sub CompiledQueryExample()
        'Dim query = From x In Me.Context.Customers
        Dim cq = Objects.CompiledQuery.Compile(Of dbDEVCisTEntities, String, IQueryable(Of Customer)) _
                (
                    Function(context As dbDEVCisTEntities, dest As String) From x In context.Customers
                )

    End Sub

    Public Sub Save()
        Me.Context.SaveChanges()
    End Sub




End Class
