Imports System.Console

Public Class Application
	Public Shared Sub Main()
		WriteLine("Hello, what is your name?")
		Dim input as String = ReadLine()
		WriteLine("Hello " +  input + "!")	
	End Sub
End Class
