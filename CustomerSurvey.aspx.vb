Imports System.Data
Partial Class CustomerSurvey
    Inherits System.Web.UI.Page
    ' Private selectedIncident As Incident
    Private Incidents As SortedList


    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ListBox1.Enabled = False
        Label2.Enabled = False
        
        Label6.Enabled = False
        txtComments.Enabled = False
        CheckBox1.Enabled = False
        RadioButton13.Enabled = False
        RadioButton14.Enabled = False
        Button2.Enabled = False
        lblNoIncidentsFound.Enabled = False
        lblTechnicianEfficiency.Enabled = False
        lblProblemResolution.Enabled = False
        rblResponseTime.Enabled = False
        rbrTechnicianEfficiency.Enabled = False
        rbrProblemResolution.Enabled = False
        lblNoIncidentsFound.Visible = False

        If IsPostBack = False Then
            txtBx_Cust_ID.Focus()

        End If

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Page.IsValid Then

            Dim UserCustomerID = CType(txtBx_Cust_ID.Text, Integer)
            ListBox1.Items.Clear()
            Me.GetSelectedIncidents()
            If ListBox1.Items.Count > 1 Then
                ListBox1.Enabled = True
                Label2.Enabled = True
                Label6.Enabled = True
                txtComments.Enabled = True
                CheckBox1.Enabled = True
                RadioButton13.Enabled = True
                RadioButton14.Enabled = True
                Button2.Enabled = True
                lblNoIncidentsFound.Visible = False
                lblTechnicianEfficiency.Enabled = True
                lblProblemResolution.Enabled = True
                rblResponseTime.Enabled = True
                rbrTechnicianEfficiency.Enabled = True
                rbrProblemResolution.Enabled = True
                ListBox1.SelectedIndex = 1

            Else

                ListBox1.Items.Clear()
                lblNoIncidentsFound.Visible = True

            End If




        End If
    End Sub

    Private Sub GetSelectedIncidents()

        Dim IncidentTable As DataView = CType(AccessDataSource1.Select(DataSourceSelectArguments.Empty), DataView)
        IncidentTable.RowFilter = "DateClosed is not Null AND CustomerID= '" & CType(txtBx_Cust_ID.Text, Integer) & "'"

        Dim incident As New Incident
        Dim rowIndex As Integer = 0
        ListBox1.Items.Add(New ListItem("--Select An Incident--", vbNull))
        For Each incidentRows As DataRowView In IncidentTable

            Dim incidentRow As DataRowView = IncidentTable(rowIndex)
            incident.CustomerID = incidentRow("CustomerID").ToString
            incident.IncidentID = incidentRow("IncidentID").ToString
            incident.ProductCode = incidentRow("ProductCode").ToString
            incident.TechID = incidentRow("TechID")
            incident.Title = incidentRow("Title")
            incident.DateOpened = incidentRow("DateOpened")
            incident.DateClosed = incidentRow("DateClosed")
            Session.Add("SessionIncident", incident)

            rowIndex = rowIndex + 1
            ListBox1.Items.Add(New ListItem(incident.CustomerIncidentDisplay(), (incident.IncidentID)))

        Next


    End Sub


   
   
    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim survey As New Survey
        survey.CustomerID = CType(txtBx_Cust_ID.Text.ToString, Integer)
        survey.IncidentID = ListBox1.SelectedValue
        survey.ResponseTime = rblResponseTime.SelectedValue
        survey.TechEfficiency = rbrTechnicianEfficiency.SelectedValue
        survey.Resolution = rbrProblemResolution.SelectedValue
        survey.Comments = txtComments.Text
        Dim HollaBack As New Boolean
        If CheckBox1.Checked Then
            HollaBack = True
        Else
            HollaBack = False
        End If
        Session.Add("SessionHollaBack", HollaBack)
        Response.Redirect("SurveyComplete.aspx")

    End Sub
End Class
