
Partial Class SurveyComplete
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Session("SessionHollaBack") Then
            lblWillContact.Visible = True
        Else
            lblWillContact.Visible = False
        End If
    End Sub

    Protected Sub btnReturntoSurvey_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnReturntoSurvey.Click
        Response.Redirect("CustomerSurvey.aspx")
    End Sub
End Class
