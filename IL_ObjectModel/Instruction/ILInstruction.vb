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

        Public Overridable Function GetBytes() As IEnumerable(Of Byte)
            Return Me.OpCode.GetByteCode()
        End Function

        Public Overridable Function Size() As Integer
            If OpCode Is Nothing Then Return 0
            Return OpCode.Size
        End Function
    End Class

    'Public Class ldarg
    '    Inherits IL_Instruction

    '    Public Sub New()
    'End Class

    'Public MustInherit Class ILOpWithValue(Of T As IL_Target)
    '    Inherits IL_Instruction
    '    Public ReadOnly Property Value As T

    '    Friend Sub New(opCode As OpCode, Value As T)
    '        MyBase.New(opCode)
    '        Me.Value = Value
    '    End Sub

    '    Public Overrides Function ToString() As String
    '        Return $"{MyBase.ToString()}  {Value}"
    '    End Function
    'End Class
    Public MustInherit Class ILOpWithTarget(Of T As IL_Target)
        Inherits IL_Instruction
        Public ReadOnly Property Target As T

        Friend Sub New(opCode As OpCode, Target As T)
            MyBase.New(opCode)
            Me.Target = Target
        End Sub

        Public Overrides Function ToString() As String
            Return $"{MyBase.ToString()}  {Target}"
        End Function
    End Class

    Public Class ILOp_b1
        Inherits ILOpWithTarget(Of Target_1)
        Friend Sub New(opCode As OpCode, b0 As Byte)
            MyBase.New(opCode, New Target_1(b0))
        End Sub
    End Class
    Public Class ILOp_b4
        Inherits ILOpWithTarget(Of Target_4)
        Friend Sub New(opCode As OpCode, b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte)
            MyBase.New(opCode, New Target_4(b0, b1, b2, b3))
        End Sub
    End Class

    Public MustInherit Class IL_Value
        Inherits IL_Instruction
        Protected Friend Sub New(opcode As OpCode)
            MyBase.New(opcode)
        End Sub
    End Class

    Public MustInherit Class Value(Of T)
        Inherits IL_Value
        Protected Friend _Value As T

        Protected Friend Sub New(opcode As OpCode, Value As T)
            MyBase.New(opcode)
            Me._Value = Value
        End Sub

        Public ReadOnly Property Value As T
            Get
                Return _Value
            End Get
        End Property
        Public MustOverride Overrides Function GetBytes() As IEnumerable(Of Byte)
        Public Overrides Function ToString() As String
            Return MyBase.ToString() & " " & Value.ToString
        End Function
    End Class

    Public MustInherit Class Value_UInt08
        Inherits Value(Of Byte)
        Public Sub New(opcode As OpCode, Value As Byte)
            MyBase.New(opcode, Value)
        End Sub
        Public Overrides Function GetBytes() As IEnumerable(Of Byte)
            Return OpCode.GetByteCode.Concat(BitConverter.GetBytes(Value))
        End Function
    End Class
    Public MustInherit Class Value_UInt16
        Inherits Value(Of UInt16)
        Public Sub New(opcode As OpCode, Value As UInt16)
            MyBase.New(opcode, Value)
        End Sub
        Public Overrides Function GetBytes() As IEnumerable(Of Byte)
            Return OpCode.GetByteCode.Concat(BitConverter.GetBytes(Value))
        End Function
    End Class
    Public MustInherit Class Value_UInt32
        Inherits Value(Of UInt32)
        Public Sub New(opcode As OpCode, Value As UInt32)
            MyBase.New(opcode, Value)
        End Sub
        Public Overrides Function GetBytes() As IEnumerable(Of Byte)
            Return OpCode.GetByteCode.Concat(BitConverter.GetBytes(Value))
        End Function
    End Class

    Public MustInherit Class Value_UInt64
        Inherits Value(Of UInt64)
        Public Sub New(opcode As OpCode, Value As UInt64)
            MyBase.New(opcode, Value)
        End Sub
        Public Overrides Function GetBytes() As IEnumerable(Of Byte)
            Return OpCode.GetByteCode.Concat(BitConverter.GetBytes(Value))
        End Function
    End Class
    Public MustInherit Class Value_Int08
        Inherits Value(Of SByte)
        Public Sub New(opcode As OpCode, Value As SByte)
            MyBase.New(opcode, Value)
        End Sub
        Public Overrides Function GetBytes() As IEnumerable(Of Byte)
            Return OpCode.GetByteCode.Concat(BitConverter.GetBytes(Value))
        End Function
    End Class
    Public MustInherit Class Value_Int16
        Inherits Value(Of Int16)
        Public Sub New(opcode As OpCode, Value As Int16)
            MyBase.New(opcode, Value)
        End Sub
        Public Overrides Function GetBytes() As IEnumerable(Of Byte)
            Return OpCode.GetByteCode.Concat(BitConverter.GetBytes(Value))
        End Function
    End Class
    Public MustInherit Class Value_Int32
        Inherits Value(Of Int32)
        Public Sub New(opcode As OpCode, Value As Int32)
            MyBase.New(opcode, Value)
        End Sub
        Public Overrides Function GetBytes() As IEnumerable(Of Byte)
            Return OpCode.GetByteCode.Concat(BitConverter.GetBytes(Value))
        End Function
    End Class

    Public MustInherit Class Value_Int64
        Inherits Value(Of Int64)
        Public Sub New(opcode As OpCode, Value As Int64)
            MyBase.New(opcode, Value)
        End Sub
        Public Overrides Function GetBytes() As IEnumerable(Of Byte)
            Return OpCode.GetByteCode.Concat(BitConverter.GetBytes(Value))
        End Function
    End Class

    Public MustInherit Class Value_Float32
        Inherits Value(Of Single)
        Public Sub New(opcode As OpCode, Value As Single)
            MyBase.New(opcode, Value)
        End Sub
        Public Overrides Function GetBytes() As IEnumerable(Of Byte)
            Return OpCode.GetByteCode.Concat(BitConverter.GetBytes(Value))
        End Function
    End Class

    Public MustInherit Class Value_Float64
        Inherits Value(Of Double)
        Public Sub New(opcode As OpCode, Value As Int64)
            MyBase.New(opcode, Value)
        End Sub
        Public Overrides Function GetBytes() As IEnumerable(Of Byte)
            Return OpCode.GetByteCode.Concat(BitConverter.GetBytes(Value))
        End Function
    End Class



    Public Class ldc_i4
        Inherits Value_Int32
        Public Sub New(num As Int32)
            MyBase.New(OpCode.OpCodes.ldc_i4, num)
        End Sub
    End Class
    Public Class ldc_i8
        Inherits Value_Int64
        Public Sub New(num As Int64)
            MyBase.New(OpCode.OpCodes.ldc_i8, num)
        End Sub
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

    Public Class MetadataToken
        Inherits ILCode

        Public ReadOnly Property Value As UInt32

        Public Sub New(Value As UInt32)
            MyBase.New()
            Me.Value = Value
        End Sub

        Public ReadOnly Property HeapID() As Byte
            Get
                Return CByte(Value >> 24)
            End Get
        End Property

        Public ReadOnly Property HeapRow() As UInt32
            Get
                Return CUInt(Value And &H00FFFFFF)
            End Get
        End Property
    End Class
End Namespace
