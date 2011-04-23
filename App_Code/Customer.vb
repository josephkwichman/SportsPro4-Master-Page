Imports Microsoft.VisualBasic

Public Class Customer
    Public CustomerID As String
    Public Name As String
    Public Address As String
    Public City As String
    Public State As String
    Public ZipCode As String
    Public Phone As String
    Public Email As String



    Public Function ContactDisplay() As String
        Dim Selectedcustomer As New Customer
        Selectedcustomer = (System.Web.HttpContext.Current.Session("SessionCustomer"))
        Return Selectedcustomer.Name + ": " + Selectedcustomer.Phone + ", " + Selectedcustomer.Email

    End Function

End Class
