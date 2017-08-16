' Class:        Visitor
' Developer:    Diana Betances
' Date:         August 15, 2017 
' Purpose:      This business class is for a visitor to the Mobile Developer's conference.
'               It calculates the cost of the attending the conference based on length of stay (1 to 4 days).
'               It also causes the visitor costs file to be written.  This is the Parent Class.

Option Strict On

Public Class Visitor

    ' Class Variables
    Protected _strCorporationID As String
    Protected _strFirstName As String
    Protected _strLastName As String
    Protected _strCourse As String = ""     ' _strCourse is going to be blank if the user is attends only the conference
    Protected _intDays As Integer           ' _intDays is between 1 to 4 days
    Protected _decCost As Decimal
    Protected _decCostPerDay As Decimal = 350D

    Dim objVisitorCostsFile As VisitorCostsFile

    Sub New(ByVal strCorporationID As String, ByVal strFirstName As String, _
             ByVal strLastName As String, ByVal intDays As Integer)
        ' This subprocedure is a constructor for the Visitor class. It is
        ' called when the object is instantiated with arguments

        ' The following code assigns the arguments to class variables
        _strCorporationID = strCorporationID
        _strFirstName = strFirstName
        _strLastName = strLastName
        _intDays = Convert.ToInt32(intDays)

    End Sub

    Overridable Function ComputeCosts() As Decimal
        ' This function computes the registration costs, writes a record
        ' in the student costs file, and returns the registration costs

        ' Calculate cost for attending the conference
        _decCost = _intDays * _decCostPerDay

        ' Write the Visitor record
        objVisitorCostsFile = New VisitorCostsFile(_strCorporationID, _strFirstName, _strLastName, _strCourse, _decCost)
        objVisitorCostsFile.WriteRecord()

        ' Return the calculated cost
        Return _decCost

    End Function

End Class