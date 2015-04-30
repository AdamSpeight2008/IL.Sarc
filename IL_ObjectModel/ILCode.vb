Namespace Global.IL
    Public Class ILCode
        Private _Code As New List(Of IL_Instruction)(4)

        Public Function Asm() As IReadOnlyList(Of IL_Instruction)
            Return _Code.AsReadOnly
        End Function

        Public Function GetSize() As Integer
            Return _Code.Sum(Function(i) i.Size)
        End Function

        Public Sub Add(i As IL.IL_Instruction)
            If i IsNot Nothing Then _Code.Add(i)
        End Sub

        Public Function GetBytes() As Byte()
            Return _Code.AsParallel.AsOrdered.SelectMany(Function(i) i.GetBytes).ToArray
        End Function
    End Class

End Namespace
