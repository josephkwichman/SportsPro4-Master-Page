Imports System.Data
Partial Class CustomerDisplay
    Inherits System.Web.UI.Page

    Private selectedCustomer As Customer
    Private CustomerAdded As Boolean


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            DropDownList1.DataBind()
        End If
        selectedCustomer = Me.GetSelectedCustomer()
        Label3.Text = selectedCustomer.Address
        Label4.Text = selectedCustomer.City & ", " & selectedCustomer.State & " " & selectedCustomer.ZipCode
        Label6.Text = selectedCustomer.Phone
        Label8.Text = selectedCustomer.Email
        Label9.Visible = False

    End Sub
    Private Function GetSelectedCustomer() As Customer
        Dim customerTable As DataView = CType(AccessDataSource1.Select(DataSourceSelectArguments.Empty), DataView)
        customerTable.RowFilter = "CustomerID = '" & DropDownList1.SelectedValue & "'"
        Dim customerRow As DataRowView = customerTable(0)
        Dim customer As New Customer
        customer.CustomerID = customerRow("CustomerID").ToString
        customer.Name = customerRow("Name").ToString
        customer.Address = customerRow("Address").ToString
        customer.City = customerRow("City").ToString
        customer.State = customerRow("State").ToString
        customer.ZipCode = customerRow("ZipCode").ToString
        customer.Phone = customerRow("Phone").ToString
        customer.Email = customerRow("Email").ToString
        Return customer
    End Function

    Private Sub AddtoCustomerList(ByVal customer As Customer)
        Dim customerList As SortedList = Me.GetCustomer
        Dim CustomerID As String = selectedCustomer.CustomerID
        If customerList.ContainsKey(CustomerID) Then
            customerList = CType(Session("customerList"), SortedList)
            CustomerAdded = True
        Else
            customerList.Add(CustomerID, selectedCustomer)
            CustomerAdded = False
        End If
    End Sub
    Private Function GetCustomer() As SortedList
        If Session("Customer") Is Nothing Then
            Session.Add("Customer", New SortedList)
        End If
        Return CType(Session("Customer"), SortedList)

    End Function
    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Page.IsValid Then
            Dim customer As New Customer
            Me.AddtoCustomerList(customer)
            If CustomerAdded = False Then
                Response.Redirect("ContactDisplay.aspx")
            Else
                Label9.Visible = True
            End If

        End If
    End Sub

End Class
