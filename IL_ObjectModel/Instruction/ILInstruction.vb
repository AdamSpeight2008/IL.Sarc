Namespace Global.IL
    Public MustInherit Class IL_Instruction
        Public ReadOnly Property [Next] As IL.IL_Instruction
        Public ReadOnly Property [Prev] As IL.IL_Instruction

        Public ReadOnly Property OpCode As OpCode
        Friend Sub New(opCode As OpCode)
            Me.OpCode = opCode
        End Sub

        Public Overrides Function ToString() As String
            Return $"{OpCode.OpName}"
        End Function

        Public Overridable Function GetBytes() As Byte()
            Return Me.OpCode.GetByteCode()
        End Function

        Public Overridable Function Size() As Integer
            If OpCode Is Nothing Then Return 0
            Return OpCode.Size
        End Function
    End Class


End Namespace
