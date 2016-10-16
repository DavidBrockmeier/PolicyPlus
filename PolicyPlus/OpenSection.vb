﻿Public Class OpenSection
    Public SelectedSection As AdmxPolicySection
    Private Sub ButtonOK_Click(sender As Object, e As EventArgs) Handles ButtonOK.Click
        If OptUser.Checked Or OptComputer.Checked Then
            SelectedSection = If(OptUser.Checked, AdmxPolicySection.User, AdmxPolicySection.Machine)
            DialogResult = DialogResult.OK
        End If
    End Sub
    Private Sub OpenSection_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then DialogResult = DialogResult.Cancel
    End Sub
    Private Sub OpenSection_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        OptUser.Checked = False
        OptComputer.Checked = False
    End Sub
End Class