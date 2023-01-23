Imports System.Data.Entity.Migrations.Infrastructure
Imports System.Data.SQLite
Imports System.IO
Imports Microsoft.EntityFrameworkCore.Metadata.Internal

Public Class Question
    Private id_ As Integer
    Private question_ As String
    Private theme_ As String
    Private answers_ As String
    Private rightAnswer_ As Integer
    Private theory_ As String
    Private hasImg_ As Integer

    Public Shared questionList() As Question = New Question() {}
    Public Shared theoryList() As Theory = New Theory() {}
    Public Shared themes As String()()
    Public Shared tickets As Integer()()

    Public Property id As Integer
        Get
            Return id_
        End Get
        Set
            If Value >= 0 Then
                id_ = Value
            Else
                Console.WriteLine("Tried to set negative id.\n")
                id_ = 0
            End If
        End Set
    End Property

    Public Property quest As String
        Get
            Return question_
        End Get
        Set
            question_ = Value
        End Set
    End Property

    Public Property theme As String
        Get
            Return theme_
        End Get
        Set
            theme_ = Value
        End Set
    End Property

    Public Property answers As String
        Get
            Return answers_
        End Get
        Set
            answers_ = Value
        End Set
    End Property

    Public Property rightAnswer As Integer
        Get
            Return rightAnswer_
        End Get
        Set
            If Value >= 0 Then
                rightAnswer_ = Value
            Else
                Console.WriteLine("Tried to set negative rightAnswer.\n")
                rightAnswer_ = 0
            End If
        End Set
    End Property

    Public Property theory As String
        Get
            Return theory_
        End Get
        Set
            theory_ = Value
        End Set
    End Property

    Public Property hasImg As Boolean
        Get
            If hasImg_ > 0 Then
                Return True
            Else Return False
            End If
        End Get
        Set
            If Value = True Then
                hasImg_ = 1
            Else hasImg_ = 0
            End If
        End Set
    End Property

    Sub New()
        Me.id = 0
        Me.quest = ""
        Me.theme = "theme1"
        Me.answers = "1;2;3;4"
        Me.rightAnswer = 1
        Me.theory = "Par 1.1"
    End Sub

    Shared Sub New()
        themes = New String(3)() {}
        themes(0) = New String(2) {"theme1", "theme1", "theme1"}
        themes(1) = New String(2) {"theme2", "theme2", "theme2"}
        themes(2) = New String(2) {"theme3", "theme3", "theme3"}
        themes(3) = New String(2) {"theme4", "theme4", "theme4"}

        tickets = New Integer(0)() {}
        tickets(0) = New Integer(19) {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20}
    End Sub

    Public Shared Sub createList()
        Using SQlConn As New SQLiteConnection("Data Source=data.db")
            Dim tempQuestion As New Question
            Dim command As New SQLiteCommand("SELECT * FROM Questions", SQlConn)
            SQlConn.Open()
            Dim reader As SQLiteDataReader = command.ExecuteReader()
            While reader.Read()
                tempQuestion.id = reader.GetValue(0)
                tempQuestion.quest = reader.GetValue(1)
                tempQuestion.theme = reader.GetValue(2)
                tempQuestion.answers = reader.GetValue(3)
                tempQuestion.rightAnswer = reader.GetValue(4)
                tempQuestion.theory = reader.GetValue(5)
                tempQuestion.hasImg = reader.GetValue(6)
                questionList = questionList.Append(New Question(tempQuestion)).ToArray
            End While
        End Using


        Using SQlConn As New SQLiteConnection("Data Source=theory.db")
            Dim tempTheory As New Theory
            Dim command As New SQLiteCommand("SELECT * FROM Questions", SQlConn)
            SQlConn.Open()
            Dim reader As SQLiteDataReader = command.ExecuteReader()
            While reader.Read()
                tempTheory.par = reader.GetValue(0)
                tempTheory.theory = reader.GetValue(1)
                theoryList = theoryList.Append(tempTheory).ToArray
            End While
        End Using
    End Sub

    Public Shared Function createListByTheme(themes As String()) As Question()
        Dim filtered As Question() = New Question() {}
        For Each q As Question In questionList
            If themes.Contains(q.theme) Then
                filtered = filtered.Append(q).ToArray()
            End If
        Next

        Return filtered
    End Function

    Public Shared Function createListByTheme(theme As String) As Question()
        Dim filtered As Question() = New Question() {}
        For Each q As Question In questionList
            If theme = q.theme Then
                filtered = filtered.Append(q).ToArray()
            End If
        Next

        Return filtered
    End Function

    Public Shared Function getTicket(number As Integer) As Question()
        Dim filtered As Question() = New Question() {}

        For Each var As Integer In tickets(number)
            filtered = filtered.Append(questionList(var - 1)).ToArray()
        Next

        Return filtered
    End Function

    Public Shared Function getFive(themes As String()) As Question()
        Dim all As Question() = createListByTheme(themes)
        Dim five As Question() = New Question() {}
        Dim random As Random = New Random()
        Dim index As Integer = 0
        While Not five.Length = 5
            index = random.Next(0, all.Length)
            If Not five.Contains(all(index)) Then
                five = five.Append(all(index)).ToArray()
            End If
        End While

        Return five
    End Function

    Public Shared Function getFive(alreadyHave As Question(), themes As String()) As Question()
        Dim all As Question() = createListByTheme(themes)
        Dim five As Question() = New Question(4) {}
        Dim random As Random = New Random()
        Dim index As Integer = 0
        While Not five.Length = 5
            Index = Random.Next(0, all.Length)
            If Not five.Contains(all(index)) And Not alreadyHave.Contains(all(index)) Then
                five = five.Append(all(index)).ToArray()
            End If
        End While

        Return five
    End Function

    Public Shared Function getAll() As Question()
        Dim all As Question() = New Question(questionList.Length - 1) {}
        questionList.CopyTo(all, 0)
        Return all
    End Function

    Public Shared Operator =(obj1 As Question, obj2 As Question) As Boolean
        If obj1.id = obj2.id Then
            Return True
        Else
            Return False
        End If
    End Operator

    Public Shared Operator <>(obj1 As Question, obj2 As Question) As Boolean
        Return Not (obj1 = obj2)
    End Operator

    Public Sub New(obj As Question)
        Me.id = obj.id
        Me.quest = obj.quest
        Me.theme = obj.theme
        Me.answers = obj.answers
        Me.rightAnswer = obj.rightAnswer
        Me.theory = obj.theory
        Me.hasImg = obj.hasImg
    End Sub

End Class
