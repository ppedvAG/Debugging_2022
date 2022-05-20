Imports System.Threading

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim zeug As New List(Of MeineKlasse)

        For index = 1 To 5_000
            Dim z As New MeineKlasse()
            AddHandler Me.ClientSizeChanged, Sub() z.EineZahl += 1

            For index2 = 1 To 10000

                Dim zahl = Math.Pow(z.EineZahl, z.EineZahl)
            Next
            zeug.Add(z)

            If zeug.Count Mod 100_000 = 0 Then
                Thread.Sleep(1)
            End If
        Next

    End Sub
End Class


Class MeineKlasse
    Property EineZahl As Double = 12
End Class