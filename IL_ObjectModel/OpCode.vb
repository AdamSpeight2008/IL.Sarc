Namespace Global.IL
    Public Class OpCode
        Private _A As Byte
        Private _B As Byte? = Nothing
        Public ReadOnly Property OpName As String
        Protected Friend Sub New(opcode As Byte, name As String)
            Me._A = opcode
            Me._B = New Byte?()
            Me.OpName = name
        End Sub
        Protected Friend Sub New(opcodeA As Byte, opcodeB As Byte, name As String)
            Me._A = opcodeA
            Me._B = opcodeB
            Me.OpName = name
        End Sub
        Public Overrides Function ToString() As String
            If _B.HasValue Then Return $"{_A:x2} {_B:x2}  {OpName,-16}"
            Return $"{_A:x2}     {OpName,-16}"
        End Function

        Public Function GetByteCode() As Byte()
            If _B.HasValue Then Return {_A, _B.Value}
            Return {_A}
        End Function

        Public Function Size() As Integer
            Return If(_B.HasValue, 2, 1)
        End Function


    End Class

End Namespace

