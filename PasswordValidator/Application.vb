Imports System.Console

Public Class Application
	Public Shared Sub Main()
		WriteLine("Hello, what is your password?")
		Dim input as String = ReadLine()
		Dim strength as String = "Moderate"
		If input.length() > 15 Then
			strength = "Strong"
        ElseIf input.length() < 7 Then
			strength = "Weak"
        End If
		WriteLine("That is a " +  strength + " password!")	
	End Sub
End Class
