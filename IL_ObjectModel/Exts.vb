Imports System.Runtime.CompilerServices

Namespace Global.IL
    Public Module Exts
        <System.Runtime.CompilerServices.Extension>
        Public Sub Add(l As List(Of OpCode), op_A As Byte, op_B As Byte?, text As String)
            ' Console.WriteLine($"Public Shared ReadOnly Property {text.Replace("."c, "_"c)} As OpCode = New OpCode(&H{op_A:X2},&H{op_B:X2},""{text}"")")
            l.Add(New OpCode(op_A, op_B, text))
        End Sub

        <System.Runtime.CompilerServices.Extension>
        Public Sub Add(l As List(Of OpCode), op_A As Byte, text As String)
            'Console.WriteLine($"Public Shared ReadOnly Property {text.Replace("."c, "_"c)} As OpCode = New OpCode(&H{op_A:X2},""{text}"")")
            l.Add(New OpCode(op_A, text))
        End Sub
    End Module

End Namespace

