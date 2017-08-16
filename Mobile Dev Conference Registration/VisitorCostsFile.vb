' Class:        VisitorCostsFile
' Developer:    Diana Betances
' Date:         August 15, 2017
' Purpose:      This persistence class represents the Visitor Costs File. The WriteRecord
'               procedure writes a comma-delimited student costs file that
'               contains the Corporation ID, First Name, Last Name,
'               and the total costs the visit.

Option Strict On

Public Class VisitorCostsFile

    ' Class variables
    Private _strCorporationID As String
    Private _strFirstName As String
    Private _strLastName As String
    Private _strCourse As String
    Private _decVisitorCosts As Decimal

    Sub New(ByVal CorporationID As String, ByVal FirstName As String, _
        ByVal LastName As String, ByVal Course As String, ByVal Costs As Decimal)
        ' This sub procedure is the constructor for the VisitorCostsFile
        ' class

        ' The following code assigns the arguments to class variables
        _strCorporationID = CorporationID
        _strFirstName = FirstName
        _strLastName = LastName
        _strCourse = Course
        _decVisitorCosts = Costs

    End Sub

    Sub WriteRecord()
        ' This procedure opens the VisitorCosts output text file and then
        ' writes a record in the comma-delimited file
        ' The text file will be in the "Mobile Dev Conference Registration\bin\Debug" folder
        Dim strNameandLocationOfFile As String = My.Application.Info.DirectoryPath & "\VisitorCosts.txt"

        Try
            Dim objWriter As IO.StreamWriter = IO.File.AppendText(strNameandLocationOfFile)

            objWriter.Write(_strCorporationID & ",")
            objWriter.Write(_strFirstName & ",")
            objWriter.Write(_strLastName & ",")
            objWriter.Write(_strCourse & ",")
            objWriter.WriteLine(_decVisitorCosts)
            objWriter.Close()

        Catch ex As Exception
            MsgBox("No device available - program aborted", , "Error")
            Application.Exit()
        End Try

    End Sub

End Class
