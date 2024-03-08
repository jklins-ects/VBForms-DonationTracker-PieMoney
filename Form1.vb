
Imports Microsoft.VisualBasic.ApplicationServices
Imports Newtonsoft.Json

Public Class frmMain
    Private Const strSTUDENTFILE As String = "StudentList.json"
    Private StudentTable As New List(Of Student) 'TODO: Change to List
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateStudentTable()
        PopulateStudentComboBox()
        UpdateValues()
    End Sub

    Private Sub PopulateStudentComboBox()
        cboStudents.Items.AddRange(StudentTable.ToArray)

    End Sub

    Private Sub PopulateStudentTable()
        If IO.File.Exists(strSTUDENTFILE) Then
            'Stubbed
            'TODO: Load the list
            Dim reader As New IO.StreamReader(strSTUDENTFILE)
            Dim str As String = reader.ReadToEnd
            StudentTable = JsonConvert.DeserializeObject(Of List(Of Student))(str)
            reader.Close()
        Else
            StartFresh()
        End If
    End Sub
    Private Sub StartFresh()
        Dim names() As String = {"Aiden", "Alexander", "Anna", "Anthony", "Arlo", "Benjamin", "Bradley", "Brooks", "Chevy", "Collin", "Francis", "Holly", "Logan", "Matthew", "Michael", "Nathan", "Preston", "Srikar", "Tanmay", "Vincent", "Walker", "Zeph"}
        For Each s As String In names
            'add a new student object to our dictionary. 
            'For now we will use the name as the key because this list happens to be unique
            StudentTable.Add(New Student(s, New List(Of Donation))) 'TODO: Change to List
        Next
    End Sub

    Private Sub cboStudents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStudents.SelectedIndexChanged
        Dim s As Student = cboStudents.SelectedItem 'TODO: THIS LINE!
        UpdateValues()

    End Sub

    Private Sub btnDonate_Click(sender As Object, e As EventArgs) Handles btnDonate.Click
        Dim amt As Double
        If cboStudents.SelectedIndex >= 0 AndAlso Double.TryParse(txtDonationAmt.Text, amt) Then
            Dim s As Student = cboStudents.SelectedItem
            s.Donations.Add(New Donation(amt, Date.Now))
        End If
        UpdateValues()
    End Sub

    Sub UpdateValues()
        Dim s As Student = cboStudents.SelectedItem()
        If Not IsNothing(s) Then
            LoadDonationListBox()
            lblStudentTotal.Text = s.GetTotalDonations.ToString("C2")
            lblClassTotal.Text = GetClassTotalDonations.ToString("C2")
        End If

        PopulateTopDonors()
    End Sub

    Sub PopulateTopDonors()
        lblHighest.Text = ""
        Dim i As Integer = 0
        StudentTable.Sort(Function(x, y) y.GetTotalDonations().CompareTo(x.GetTotalDonations()))
        While i < 5 AndAlso StudentTable(i).GetTotalDonations > 0
            lblHighest.Text = lblHighest.Text & StudentTable(i).Name.PadRight(10) &
            StudentTable(i).GetTotalDonations().ToString("C2").PadLeft(7) & vbNewLine
            i += 1
        End While
    End Sub
    Function GetClassTotalDonations() As Double
        Dim total As Double = 0
        For Each s As Student In StudentTable
            total += s.GetTotalDonations
        Next
        Return total
    End Function

    Sub LoadDonationListBox()
        lstDonations.Items.Clear()
        lstDonations.Items.AddRange(cboStudents.SelectedItem.Donations.ToArray)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Dim s As Student = cboStudents.SelectedItem()
        Dim d As Donation = lstDonations.SelectedItem()
        s.Donations.Remove(d)
        UpdateValues()
    End Sub

    Private Sub SaveFile()
        Dim json = JsonConvert.SerializeObject(cboStudents.Items)
        Dim writer = New IO.StreamWriter(strSTUDENTFILE)
        writer.Write(json)
        writer.Close()
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveFile()
    End Sub

    Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        SaveFile()
    End Sub
End Class

Public Class Student
    Private _name As String
    Private _donations As List(Of Donation)

    Public Sub New()

    End Sub

    Public Sub New(name As String, donations As List(Of Donation))
        Me.Name = name
        Me.Donations = donations
    End Sub

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property

    Public Property Donations As List(Of Donation)
        Get
            Return _donations
        End Get
        Set(value As List(Of Donation))
            _donations = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return Name
    End Function

    Public Function GetTotalDonations() As Double
        Dim total As Double = 0
        For Each d As Donation In Donations
            total += d.Amount
        Next
        Return total
    End Function
End Class

Public Class Donation
    Private _amount As Double
    Private _theDate As Date

    Public Property Amount As Double
        Get
            Return _amount
        End Get
        Set(value As Double)
            _amount = value
        End Set
    End Property

    Public Property TheDate As Date
        Get
            Return _theDate
        End Get
        Set(value As Date)
            _theDate = value
        End Set
    End Property

    Public Sub New(amount As Double, theDate As Date)
        Me.Amount = amount
        Me.TheDate = theDate
    End Sub

    Public Overrides Function ToString() As String
        Return Me.Amount.ToString("C2").PadRight(10) & Me.TheDate.ToLocalTime

    End Function
End Class