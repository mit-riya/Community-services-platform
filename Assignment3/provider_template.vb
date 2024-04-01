﻿Public Class provider_template

    Private Sub provider_template_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        With provider_appointments
            .TopLevel = False
            SplitContainer1.Panel2.Controls.Add(provider_appointments)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub ShowForm(form As Form)

        ' Clear the panel and add the new form
        SplitContainer1.Panel2.Controls.Clear()
        form.TopLevel = False
        form.FormBorderStyle = FormBorderStyle.None
        form.Dock = DockStyle.Fill
        SplitContainer1.Panel2.Controls.Add(form)
        form.Show()
    End Sub

    Private WithEvents providerprofile As Provider_Profile_page

    Private Sub Profile_Navi_btn_Click(sender As Object, e As EventArgs) Handles Profile_Navi_btn.Click
        Profile_Navi_btn.BackColor = Color.FromArgb(220, 189, 232)
        Dashboard_Navi_btn.BackColor = SystemColors.Control
        Appointments_Navi_btn.BackColor = SystemColors.Control
        Notifications_Navi_btn.BackColor = SystemColors.Control
        Chats_Navi_btn.BackColor = SystemColors.Control
        Needhelp_btn.BackColor = SystemColors.Control
        Feedback_btn.BackColor = SystemColors.Control
        ShowForm(New Provider_Profile_page())
    End Sub

    Private Sub ProviderProfile_EditProfileClicked(sender As Object, e As EventArgs)
        ' Embed the edit profile form when the EditProfileClicked event is raised
        Dim editproviderprofile As New EditProfilePage()

        ' Set properties to ensure proper embedding
        editproviderprofile.TopLevel = False
        editproviderprofile.FormBorderStyle = FormBorderStyle.None
        editproviderprofile.Dock = DockStyle.Fill

        ' Add the embedded form to the panel
        SplitContainer1.Panel2.Controls.Add(editproviderprofile)
        editproviderprofile.BringToFront()

        ' Show the embedded form
        editproviderprofile.Show()
    End Sub

    Private Sub Dashboard_Navi_btn_Click(sender As Object, e As EventArgs) Handles Dashboard_Navi_btn.Click
        Dashboard_Navi_btn.BackColor = Color.FromArgb(220, 189, 232)
        Profile_Navi_btn.BackColor = SystemColors.Control
        Appointments_Navi_btn.BackColor = SystemColors.Control
        Notifications_Navi_btn.BackColor = SystemColors.Control
        Chats_Navi_btn.BackColor = SystemColors.Control
        Needhelp_btn.BackColor = SystemColors.Control
        Feedback_btn.BackColor = SystemColors.Control
        ShowForm(New provider_dashboard())
    End Sub

    Private Sub Appointments_Navi_btn_Click(sender As Object, e As EventArgs) Handles Appointments_Navi_btn.Click
        Appointments_Navi_btn.BackColor = Color.FromArgb(220, 189, 232)
        Dashboard_Navi_btn.BackColor = SystemColors.Control
        Profile_Navi_btn.BackColor = SystemColors.Control
        Notifications_Navi_btn.BackColor = SystemColors.Control
        Chats_Navi_btn.BackColor = SystemColors.Control
        Needhelp_btn.BackColor = SystemColors.Control
        Feedback_btn.BackColor = SystemColors.Control
        ShowForm(New provider_appointments())
    End Sub

    Private Sub Notifications_Navi_btn_Click(sender As Object, e As EventArgs) Handles Notifications_Navi_btn.Click
        Notifications_Navi_btn.BackColor = Color.FromArgb(220, 189, 232)
        Dashboard_Navi_btn.BackColor = SystemColors.Control
        Profile_Navi_btn.BackColor = SystemColors.Control
        Appointments_Navi_btn.BackColor = SystemColors.Control
        Chats_Navi_btn.BackColor = SystemColors.Control
        Needhelp_btn.BackColor = SystemColors.Control
        Feedback_btn.BackColor = SystemColors.Control
        ShowForm(New provider_notifications())
    End Sub

    Private Sub Chats_Navi_btn_Click(sender As Object, e As EventArgs) Handles Chats_Navi_btn.Click
        Chats_Navi_btn.BackColor = Color.FromArgb(220, 189, 232)
        Dashboard_Navi_btn.BackColor = SystemColors.Control
        Profile_Navi_btn.BackColor = SystemColors.Control
        Appointments_Navi_btn.BackColor = SystemColors.Control
        Notifications_Navi_btn.BackColor = SystemColors.Control
        Needhelp_btn.BackColor = SystemColors.Control
        Feedback_btn.BackColor = SystemColors.Control
        SplitContainer1.Panel2.Controls.Clear()
    End Sub

    Private Sub Needhelp_btn_Click(sender As Object, e As EventArgs) Handles Needhelp_btn.Click
        Needhelp_btn.BackColor = Color.FromArgb(220, 189, 232)
        Dashboard_Navi_btn.BackColor = SystemColors.Control
        Profile_Navi_btn.BackColor = SystemColors.Control
        Appointments_Navi_btn.BackColor = SystemColors.Control
        Notifications_Navi_btn.BackColor = SystemColors.Control
        Chats_Navi_btn.BackColor = SystemColors.Control
        Feedback_btn.BackColor = SystemColors.Control
        SplitContainer1.Panel2.Controls.Clear()
    End Sub

    Private Sub Feedback_btn_Click(sender As Object, e As EventArgs) Handles Feedback_btn.Click
        Feedback_btn.BackColor = Color.FromArgb(220, 189, 232)
        Dashboard_Navi_btn.BackColor = SystemColors.Control
        Profile_Navi_btn.BackColor = SystemColors.Control
        Appointments_Navi_btn.BackColor = SystemColors.Control
        Notifications_Navi_btn.BackColor = SystemColors.Control
        Chats_Navi_btn.BackColor = SystemColors.Control
        Needhelp_btn.BackColor = SystemColors.Control
        ShowForm(New provider_feedback_view())
    End Sub

    Private Sub Logout_btn_Click(sender As Object, e As EventArgs) Handles logout_btn.Click
        Me.Close()
        Login.Show()
    End Sub

End Class