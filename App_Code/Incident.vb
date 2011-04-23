Imports Microsoft.VisualBasic

Public Class Incident
    Public IncidentID As Integer
    Public CustomerID As Integer
    Public ProductCode As String
    Public TechID As Integer
    Public DateOpened As Date
    Public DateClosed As Date
    Public Title As String
    Public Description As String

    Public Function CustomerIncidentDisplay() As String
        Dim CustomerIncident As New Incident
        CustomerIncident = System.Web.HttpContext.Current.Session("SessionIncident")
        Return "Incident for product " + CustomerIncident.ProductCode + " closed " + CustomerIncident.DateClosed + " (" + CustomerIncident.Title + ")"
    End Function

End Class
