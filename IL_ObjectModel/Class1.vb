Imports IL.Sarc

Class UnrecognisedByteCode
    Inherits Exception
    Public ReadOnly Property ByteCode As Byte

    Public Sub New(byteCode As Byte)
        MyBase.New()
        Me.ByteCode = byteCode
    End Sub


End Class

Public Class ByteSource
    Protected Friend _bytes As Byte() = {}

    Public Sub New(b As Byte())
        _bytes = b
    End Sub

    Public ReadOnly Property Length() As Integer
        Get
            Return _bytes.Count
        End Get
    End Property


    Public Function GetReader() As ByteSource.Reader
        Return New ByteSource.Reader(Me)
    End Function


    Public Class Reader
        Private Property x As Integer = 0

        Private _bs As ByteSource
        Protected Friend Sub New(bs As ByteSource)
            _bs = bs : x = 0
        End Sub


        Public Function EoB() As Integer
            Return _x >= _bs.Length
        End Function
        Public Function ReadByte() As Byte
            Dim output = _bs._bytes(x)
            x += 1
            Return output
        End Function
    End Class
End Class

Public Class ByteCode_Decoder

    Public Function Decode(bytes As ByteSource.Reader) As IL.ILCode
        Dim code As New IL.ILCode

        While Not (bytes.EoB)
            Dim b As Byte = bytes.ReadByte
            Select Case b
                Case &H00 : code.Add(Asm.nop)
                Case &H01 : code.Add(Asm.break)
                Case &H02 : code.Add(Asm.ldarg_0)
                Case &H03 : code.Add(Asm.ldarg_1)
                Case &H04 : code.Add(Asm.ldarg_2)
                Case &H05 : code.Add(Asm.ldarg_3)
                Case &H06 : code.Add(Asm.ldloc_0)
                Case &H07 : code.Add(Asm.ldloc_1)
                Case &H08 : code.Add(Asm.ldloc_2)
                Case &H09 : code.Add(Asm.ldloc_3)
                Case &H0A : code.Add(Asm.stloc_0)
                Case &H0B : code.Add(Asm.stloc_1)
                Case &H0C : code.Add(Asm.stloc_2)
                Case &H0D : code.Add(Asm.stloc_3)
                'Case &H0E : code.Add(Asm.ldarg_s)
                'Case &H0F : code.Add(Asm.ldarga_s)
                'Case &H10 : code.Add(Asm.starg_s)
                'Case &H11 : code.Add(Asm.ldloc_s)
                'Case &H12 : code.Add(Asm.ldloca_s)
                'Case &H13 : code.Add(Asm.stloc_s)
                'Case &H14 : code.Add(Asm.ldnull)
                ''
                'Case &H15 : code.Add(Asm.ld_id_m1)
                'Case &H15 : code.Add(Asm.ld_i4_M!)
                ''
                'Case &H16 : code.Add(Asm.ldc_i4_0)
                'Case &H17 : code.Add(Asm.ldc_i4_1)
                'Case &H18 : code.Add(Asm.ldc_i4_2)
                'Case &H19 : code.Add(Asm.ldc_i4_3)
                'Case &H1A : code.Add(Asm.ldc_i4_4)
                'Case &H1B : code.Add(Asm.ldc_i4_5)
                'Case &H1C : code.Add(Asm.ldc_i4_6)
                'Case &H1D : code.Add(Asm.ldc_i4_7)
                'Case &H1E : code.Add(Asm.ldc_i4_8)
                'Case &H1F : code.Add(Asm.ldc_i4_s)
                'Case &H20 : code.Add(Asm.ldc_i4)
                'Case &H21 : code.Add(Asm.ldc_i8)
                'Case &H22 : code.Add(Asm.ldc_r4)
                'Case &H23 : code.Add(Asm.ldc_r8)

                'Case &H25 : code.Add(Asm.dup)
                'Case &H26 : code.Add(Asm.pop)
                'Case &H27 : code.Add(Asm.jmp)
                'Case &H28 : code.Add(Asm.call)
                'Case &H29 : code.Add(Asm.calli)
                'Case &H2A : code.Add(Asm.ret)
                'Case &H2B : code.Add(Asm.br_s)
                ' ''
                ''Case &H2C : code.Add(Asm.brfalse_s)
                ''Case &H2C : code.Add(Asm.brnull_s)
                ''Case &H2C : code.Add(Asm.brzero_s)
                ' ''
                ''Case &H2D : code.Add(Asm.brinst_s)
                ''Case &H2D : code.Add(Asm.brtrue)

                'Case &H2E : code.Add(Asm.beq_s)
                'Case &H2F : code.Add(Asm.bge_s)
                'Case &H30 : code.Add(Asm.blt_s)
                'Case &H31 : code.Add(Asm.ble_s)
                'Case &H32 : code.Add(Asm.blt_s)
                'Case &H33 : code.Add(Asm.bne_un_s)
                'Case &H34 : code.Add(Asm.bge_un_s)
                'Case &H35 : code.Add(Asm.bgt_un_s)
                'Case &H36 : code.Add(Asm.ble_un_s)
                'Case &H37 : code.Add(Asm.blt_nu_s)
                'Case &H38 : code.Add(Asm.br)
                ''
                ''Case &H39 : code.Add(Asm.brfalse)
                ''Case &H39 : code.Add(Asm.brnull)
                '' Case &H39 : code.Add(Asm.brzero)
                ''
                'Case &H3A : code.Add(Asm.brinst)
                'Case &H38 : code.Add(Asm.beq)
                'Case &H3C : code.Add(Asm.bge)
                'Case &H3D : code.Add(Asm.bgt)
                'Case &H3E : code.Add(Asm.ble)
                'Case &H3F : code.Add(Asm.blt)
                'Case &H40 : code.Add(Asm.bne_un)
                'Case &H41 : code.Add(Asm.bge_un)
                'Case &H42 : code.Add(Asm.bgt_un)
                'Case &H43 : code.Add(Asm.ble_un)
                'Case &H44 : code.Add(Asm.blt_un)
                'Case &H45 : ReadSwitch(b, code)

                'Case &H46 : code.Add(Asm.idind_i1)
                'Case &H47 : code.Add(Asm.idind_u1)
                'Case &H48 : code.Add(Asm.idind_i2)
                'Case &H49 : code.Add(Asm.idind_u2)
                'Case &H4A : code.Add(Asm.idind_i4)
                'Case &H4B : code.Add(Asm.idind_u4)
                ''Case &H4C : code.Add(Asm.idind_i8)
                ''Case &H4C : code.Add(Asm.idind_u8)

                'Case &H4D : code.Add(Asm.idind.1)
                'Case &H4E : code.Add(Asm.idind.r4)
                'Case &H4F : code.Add(Asm.idind.r8)

                'Case &H50 : code.Add(Asm.idind_ref)
                'Case &H51 : code.Add(Asm.stind_ref)
                'Case &H52 : code.Add(Asm.stind_i1)
                'Case &H53 : code.Add(Asm.stind_i2)
                'Case &H54 : code.Add(Asm.stind_i4)
                'Case &H55 : code.Add(Asm.stind_i8)
                'Case &H56 : code.Add(Asm.stind_r4)
                'Case &H57 : code.Add(Asm.stind_r8)
                Case &H58 : code.Add(Asm.add)
                Case &H59 : code.Add(Asm.sub)
                Case &H5A : code.Add(Asm.mul)
                Case &H5B : code.Add(Asm.div)
                Case &H5C : code.Add(Asm.div_u)
                Case &H5D : code.Add(Asm.[rem])
                Case &H5E : code.Add(Asm.rem_un)
                Case &H5F : code.Add(Asm.and)
                Case &H60 : code.Add(Asm.or)
                Case &H61 : code.Add(Asm.xor)
                'Case &H62 : code.Add(Asm.shl)
                'Case &H63 : code.Add(Asm.shr)
                'Case &H64 : code.Add(Asm.shr_u)
                'Case &H65 : code.Add(Asm.neg)
                'Case &H66 : code.Add(Asm.not)
                ''

                ''
                'Case &HFE : code = ReadExtended(bytes, code)
                Case Else
                    Throw New UnrecognisedByteCode(b)
            End Select
        End While

        Return code
    End Function

    'Private Function ReadSwitch(b As ByteSource.Reader, code As IL.ILCode) As IL.ILCode
    '    code.Add(Asm.Switch)
    'End Function

    Private Function ReadExtended(bytes As ByteSource.Reader, code As IL.ILCode) As IL.ILCode
        'Dim b As Byte = bytes.ReadByte
        'Select Case b
        '    Case &H02 : code.Add(Asm.ArgList)
        '    Case &H01 : code.Add(Asm.ceq)
        '    Case &H02 : code.Add(Asm.cgt)
        '    Case &H03 : code.Add(Asm.cgt_un)
        '    Case &H04 : code.Add(Asm.clt)
        '    Case &H05 : code.Add(Asm.clt_un)
        '    Case &H06 : code.Add(Asm.ldftn)
        '    Case &H07 : code.Add(Asm.ldvirtftn)
        '    Case &H09 : code.Add(Asm.ldarg)
        '    Case &H0A : code.Add(Asm.ldarga)
        '    Case &H0B : code.Add(Asm.starg)
        '    Case &H0C : code.Add(Asm.ldloc)
        '    Case &H0D : code.Add(Asm.ldloca)
        '    Case &H0E : code.Add(Asm.stloc)
        '    Case &H0F : code.Add(Asm.localloc)
        '    Case &H11 : code.Add(Asm.addfilter)
        '    Case &H12 : code.Add(Asm.unalligned)
        '    Case &H13 : code.Add(Asm.volatile)
        '    Case &H14 : code.Add(Asm.tail_)
        '    Case &H15 : code.Add(Asm.initobj)
        '    Case &H16 : code.Add(Asm.constrained)
        '    Case &H17 : code.Add(Asm.cpblk)
        '    Case &H18 : code.Add(Asm.initblk)
        '    Case &H19 : code.Add(Asm.no_)
        '    Case &H1A : code.Add(Asm.rethrow)
        '    Case &H1C : code.Add(Asm.sizeof)
        '    Case &H1D : code.Add(Asm.refanytype)
        '    Case &H1E : code.Add(Asm.readonly)
        '    Case Else
        '        Throw New UnrecognisedByteCode(b)
        'End Select
        Return code
    End Function


End Class
