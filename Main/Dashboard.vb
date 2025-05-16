Imports MySql.Data.MySqlClient
Imports Guna.UI.WinForms ' Ensure you have this imported

Public Class Dashboard
    Public Property EmployeeID As String
    Public Property EmployeeType As String
    Public Property FullName As String

    Public Sub New(empId As Integer, empName As String)
        InitializeComponent()
        EmployeeID = empId
        FullName = empName
    End Sub

    Private Sub ShowForm(formInstance As Form)
        ' Clear existing controls
        pnlforms.Controls.Clear()

        ' Set the form properties to fit inside pnlForms
        formInstance.TopLevel = False
        formInstance.FormBorderStyle = FormBorderStyle.None
        formInstance.Dock = DockStyle.Fill

        ' Add form to pnlForms
        pnlforms.Controls.Add(formInstance)
        formInstance.Show()
    End Sub

    ' Method to reset button colors
    Private Sub ResetButtonColors()
        btnDashboard.FillColor = Color.WhiteSmoke
        btnManage.FillColor = Color.WhiteSmoke
        btnTransactions.FillColor = Color.WhiteSmoke
        btnTeamList.FillColor = Color.WhiteSmoke
        btnReports.FillColor = Color.WhiteSmoke
        btnAccounts.FillColor = Color.WhiteSmoke
        btnSettings.FillColor = Color.WhiteSmoke
        btnLogout.FillColor = Color.WhiteSmoke
        btnActivity.FillColor = Color.WhiteSmoke

        btnDashboard.ForeColor = Color.Black
        btnManage.ForeColor = Color.Black
        btnTransactions.ForeColor = Color.Black
        btnTeamList.ForeColor = Color.Black
        btnReports.ForeColor = Color.Black
        btnAccounts.ForeColor = Color.Black
        btnSettings.ForeColor = Color.Black
        btnLogout.ForeColor = Color.Black
        btnActivity.ForeColor = Color.Black
    End Sub

    Private Sub btnDashboard_Click(sender As Object, e As EventArgs) Handles btnDashboard.Click
        ResetButtonColors()
        btnDashboard.FillColor = Color.SteelBlue
        btnDashboard.ForeColor = Color.White

        Dim dashboardForm As New DashboardForms()
        dashboardForm.EmployeeID = Me.EmployeeID
        dashboardForm.EmployeeType = Me.EmployeeType
        dashboardForm.FullName = Me.FullName

        dashboardForm.UpdateButtonCounts()

        ShowForm(dashboardForm)

        lblTitle.Text = "DASHBOARD"
        lblSubTitle.Text = "PATH: DASHBOARD/"
    End Sub

    Private Sub btnManage_Click(sender As Object, e As EventArgs) Handles btnManage.Click
        ResetButtonColors()
        btnManage.FillColor = Color.SteelBlue
        btnManage.ForeColor = Color.White

        ShowForm(New DashboardManage(Me, EmployeeID, FullName))
        lblTitle.Text = "MANAGE"
        lblSubTitle.Text = "PATH: MANAGE/"
    End Sub

    Private Sub btnTransactions_Click(sender As Object, e As EventArgs) Handles btnTransactions.Click
        ResetButtonColors()
        btnTransactions.FillColor = Color.SteelBlue
        btnTransactions.ForeColor = Color.White

        ShowForm(New DashboardTransactions(Me, EmployeeID, FullName))
        lblTitle.Text = "TRANSACTIONS"
        lblSubTitle.Text = "PATH: TRANSACTIONS/ INBOUND"
    End Sub

    Private Sub btnTeamList_Click(sender As Object, e As EventArgs) Handles btnTeamList.Click
        ResetButtonColors()
        btnTeamList.FillColor = Color.SteelBlue
        btnTeamList.ForeColor = Color.White

        ShowForm(New DashboardTeamList(Me, EmployeeID, FullName))
        lblTitle.Text = "TEAMLIST"
        lblSubTitle.Text = "PATH: TEAMLIST/"
    End Sub

    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        ResetButtonColors()
        btnReports.FillColor = Color.SteelBlue
        btnReports.ForeColor = Color.White

        Dim reportForm As New DashboardReports(Me, EmployeeID, FullName)
        reportForm.EmployeeType = Me.EmployeeType
        ShowForm(reportForm)
        lblTitle.Text = "REPORTS"
        lblSubTitle.Text = "PATH: REPORTS/"
    End Sub

    Private Sub btnAccounts_Click(sender As Object, e As EventArgs) Handles btnAccounts.Click
        ResetButtonColors()
        btnAccounts.FillColor = Color.SteelBlue
        btnAccounts.ForeColor = Color.White

        Dim accountForm As New DashboardAccounts()
        accountForm.EmployeeID = Me.EmployeeID
        accountForm.EmployeeType = Me.EmployeeType
        accountForm.FullName = Me.FullName
        ShowForm(accountForm)

        lblTitle.Text = "ACCOUNTS"
        lblSubTitle.Text = "PATH: ACCOUNTS/"
    End Sub

    Private Sub btnSettings_Click(sender As Object, e As EventArgs) Handles btnSettings.Click
        ResetButtonColors()
        btnSettings.FillColor = Color.SteelBlue
        btnSettings.ForeColor = Color.White

        ShowForm(New DashboardSettings)
        lblTitle.Text = "SETTINGS"
        lblSubTitle.Text = "PATH: SETTINGS/"
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        ResetButtonColors()
        btnLogout.FillColor = Color.SteelBlue
        btnLogout.ForeColor = Color.White

        InsertActivityLog(EmployeeID, FullName, "USER LOGGED OUT.")

        Application.Restart()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowForm(New DashboardForms)
        lblTitle.Text = "DASHBOARD"
        lblSubTitle.Text = "PATH: DASHBOARD/"
        Label2.Text = "Employee ID: " & EmployeeID
        Label3.Text = FullName & " (" & EmployeeType & ")"

        ' Show btnAccounts only if user is an Admin
        btnAccounts.Visible = (EmployeeType = "ADMIN")

        Me.IsMdiContainer = True

        ' Default selected button
        btnDashboard.FillColor = Color.SteelBlue
        btnDashboard.ForeColor = Color.White
    End Sub


    Private Sub btnActivity_Click(sender As Object, e As EventArgs) Handles btnActivity.Click
        ResetButtonColors()
        btnActivity.FillColor = Color.SteelBlue
        btnActivity.ForeColor = Color.White

        Dim actForm As New DashboardActivity()
        actForm.CurrentUserFullName = Me.FullName
        actForm.CurrentUserType = Me.EmployeeType
        ShowForm(actForm)

        lblTitle.Text = "DATA LOG"
        lblSubTitle.Text = "PATH: ACTIVITY/"
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Login.Show()

    End Sub

End Class
