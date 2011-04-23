
Partial Class ContactDisplay
    Inherits System.Web.UI.Page
    Private cust As SortedList

    Private Function GetCustomer() As SortedList
        If Session("customer") Is Nothing Then
            Session.Add("customer", New SortedList)
        End If
        Return CType(Session("customer"), SortedList)

    End Function
    
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        cust = Me.GetCustomer
        If Not IsPostBack Then
            Me.DisplayCustomer()
        End If


    End Sub

    Private Sub DisplayCustomer()
        CustomerListBox.Items.Clear()
        Dim listedCustomer As Customer
        For Each selectedCustomer As DictionaryEntry In cust
            listedCustomer = CType(selectedCustomer.Value, Customer)
            Session("SessionCustomer") = listedCustomer
            CustomerListBox.Items.Add(listedCustomer.ContactDisplay)
        Next


    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        If CustomerListBox.Items.Count > 0 Then
            Dim SelectedItemIndex As Integer = CustomerListBox.SelectedIndex
            If SelectedItemIndex >= 0 Then
                cust.RemoveAt(SelectedItemIndex)
                CustomerListBox.Items.RemoveAt(SelectedItemIndex)
            End If
        End If
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        CustomerListBox.Items.Clear()
        cust.Clear()
        End Sub
End Class
