﻿Namespace Global.IL
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

    Public MustInherit Class ILOpWithTarget
        Inherits IL_Instruction
        Protected Friend _target As IL_Target

        Public ReadOnly Property Target As IL_Target
            Get
                Return _target
            End Get
        End Property

        Friend Sub New(opCode As OpCode)
            MyBase.New(opCode)
        End Sub

        Public Overrides Function ToString() As String
            Return $"{MyBase.ToString()}  {Target}"
        End Function
    End Class

    Public MustInherit Class IL_Target
        Protected Friend _Bytes As Byte()
        Public ReadOnly Property Bytes As Byte()
            Get
                Return _Bytes
            End Get
        End Property
        Public ReadOnly Property Size As Integer
        Protected Friend Sub New(Size As Integer)
            Me.Size = Size

        End Sub
    End Class

    Public Class Target_1
        Inherits IL_Target
        Public Sub New(b0 As Byte)
            MyBase.New(1)
            Me._Bytes = {b0}
        End Sub
    End Class
    Public Class Target_4
        Inherits IL_Target
        Public Sub New(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte)
            MyBase.New(4)
            Me._Bytes = {b0, b1, b2, b3}
        End Sub
    End Class
End Namespace
