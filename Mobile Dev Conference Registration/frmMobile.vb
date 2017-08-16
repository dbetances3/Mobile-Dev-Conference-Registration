' Program:      Mobile Developer's Conference Registration
' Developer:    Diana Betances
' Date:         August 15, 2017
' Purpose:      In a Windows application, the user enters the visitor's corporation ID, first and last
'               name, and the number of days the visitor will be attending.  The user selects whether
'               a pre-conference course is being attended and selects the course if necessary.  The user
'               then clicks a button.  The application calculates the costs for attending the conference
'               and records the information in a log file.
'               Go to https://msdn.microsoft.com/en-us/library/ff650303.aspx for Common Regular Expressions

Option Strict On
Imports System.Text.RegularExpressions 

Public Class frmMobile

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim objVisitor As Visitor
        Dim objVisitorTakingACourse As VisitorTakingACourse

        ' InputError checks to see if the user enter unwanted variables in each of the four text boxes
        Dim InputError = False

        ' Checks to see if visitor Corporation ID was entered properly, it needs to be five numeric digits
        If Not Regex.Match(txtCorporationID.Text, "^[0-9]{5}$").Success Then
            MsgBox("Enter the five digits Corporation ID in the Corporation ID box", , "Error")
            txtCorporationID.Clear()
            txtCorporationID.Focus()
            InputError = True

            ' Checks to see if first name was entered properly 
            ' It cannot be blank and must begin with an alphabetic character, up to 20 characters
        ElseIf Not Regex.Match(txtFirstName.Text, "^[a-zA-Z''-'\s]{1,20}$").Success Then
            MsgBox("Enter a valid first name (Up to 20 letters) in the First Name box", , "Error")
            txtFirstName.Clear()
            txtFirstName.Focus()
            InputError = True

            ' Checks to see if last name was entered properly
            ' It cannot be blank and must begin with an alphabetic character, up to 30 characters
        ElseIf Not Regex.Match(txtLastName.Text, "^[a-zA-Z''-'\s]{1,30}$").Success Then
            MsgBox("Enter a valid last name (Up to 30 letters) in the Last Name box", , "Error")
            txtLastName.Clear()
            txtLastName.Focus()
            InputError = True

            ' Checks to see if a number is entered in the Number of Days box 
        ElseIf Not IsNumeric(txtDays.Text) Then
            MsgBox("Enter a a valid number in the Number of Days box", , "Error")
            txtDays.Clear()
            txtDays.Focus()
            InputError = True

            ' Checks to see if the Number of Days box is within 1 to 4.
        ElseIf Convert.ToInt32(txtDays.Text) < 1 Or Convert.ToInt32(txtDays.Text) > 4 Then
            MsgBox("Number of days must be 1 to 4", , "Error")
            txtDays.Clear()
            txtDays.Focus()
            InputError = True
        End If

        ' If no input error, process the costs of attending the conference
        If Not InputError Then
            If radWindows.Checked Then

                objVisitor = New Visitor(txtCorporationID.Text, txtFirstName.Text, txtLastName.Text, _
                                         Convert.ToInt32(txtDays.Text))
                lblCosts.Visible = True
                lblCosts.Text = "Total conference costs are: " _
                    & (objVisitor.ComputeCosts()).ToString("C2")
            Else
                objVisitorTakingACourse = New VisitorTakingACourse(txtCorporationID.Text, txtFirstName.Text, _
                    txtLastName.Text, Convert.ToInt32(txtDays.Text), _
                    radMobileSecurity.Checked, radMobileDesign.Checked, radMobileDatabases.Checked)
                lblCosts.Visible = True
                lblCosts.Text = "Total conference costs are: " & (objVisitorTakingACourse.ComputeCosts()).ToString("C2")
            End If

            ' btnCalculate should be disable once the user Hits Calculate to avoid writing data to text file more than once
            btnCalculate.Enabled = False
        End If

    End Sub

    Private Sub radAndroid_CheckedChanged(sender As Object, e As EventArgs) Handles radAndroid.CheckedChanged
        ' This event handler is executed when the Pre-Conference Android Task radio
        ' button is selected. It makes the Courses radio buttons visible

        grpCourses.Visible = True

    End Sub

    Private Sub radWindows_CheckedChanged(sender As Object, e As EventArgs) Handles radWindows.CheckedChanged
        ' This event handler is executed when the Windows Store Track radio
        ' button is selected. It hides the Courses radio buttons

        grpCourses.Visible = False

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler is executed when the user clicks the 
        ' Clear Form button. It resets all objects on the user interface.

        txtCorporationID.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtDays.Clear()
        txtCorporationID.Focus()
        grpCourses.Visible = False
        lblCosts.Visible = False
        radWindows.Checked = True
        btnCalculate.Enabled = True

    End Sub

    Private Sub frmMobile_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
