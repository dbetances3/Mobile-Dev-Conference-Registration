' Class:        VisitorTakingACourse
' Developer:    Diana Betances
' Date:         August 15, 2017
' Purpose:      This business class is for a visitor to the Mobile Developer's conference whose
'               also taking a pre-conference course.  It calculates the cost of the attending the 
'               conference based on length of stay (1 to 4 days) and the cost of taking one pre-conference course.
'               It also causes the visitor costs file to be written.  This is the Child Class.

Option Strict On

Public Class VisitorTakingACourse

    Inherits Visitor

    ' Class variables

    Private _MobileSecurity As Boolean
    Private _MobileDesign As Boolean
    Private _MobileDatabases As Boolean

    Dim objVisitorCostsFile As VisitorCostsFile

    Sub New(ByVal CorporationID As String, ByVal FirstName As String, _
            ByVal LastName As String, ByVal Days As Integer, _
            ByVal MobileSecurity As Boolean, ByVal MobileDesign As Boolean, _
            ByVal MobileDatabases As Boolean)
        ' This subprocedure is a constructor for the Visitor class. It
        ' is called when instantiated with arguments

        ' MyBase = Visitor Class
        MyBase.New(CorporationID, FirstName, LastName, Days)

        _MobileSecurity = MobileSecurity
        _MobileDesign = MobileDesign
        _MobileDatabases = MobileDatabases

    End Sub

    Overrides Function ComputeCosts() As Decimal
        ' This function computes the conference costs, writes a record
        ' in the visitor costs file, and returns cost of attending the conference and pre-conference course.

        ' Define variables
        Dim CourseCost As Decimal = 675D
        
        ' Determines the _strCourse variable
        If _MobileSecurity Then
            _strCourse = "Mobile Security"
        ElseIf _MobileDesign Then
            _strCourse = "Mobile Design"
        ElseIf _MobileDatabases Then
            _strCourse = "Mobile Datbases"
        End If

        ' Calculate cost for attending the conference and taking a pre-conference course
        _decCost = (_intDays * _decCostPerDay) + CourseCost

        ' Write the Visitor record
        objVisitorCostsFile = New VisitorCostsFile(_strCorporationID, _strFirstName, _strLastName, _strCourse, _decCost)
        objVisitorCostsFile.WriteRecord()

        ' Return the calculated cost
        Return _decCost

    End Function


End Class
