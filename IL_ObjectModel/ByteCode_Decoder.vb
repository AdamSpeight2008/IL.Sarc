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

        Public Function Read_2Bytes() As Int16
            Dim b0 = ReadByte()
            Dim b1 = ReadByte()
            Return (b0 << 8) + b1
        End Function

        Public Function Read_4Bytes() As Int32
            Dim b0 = Read_2Bytes()
            Dim b1 = Read_2Bytes()
            Return (b0 << 16) + b1
        End Function
        Public Function Read_8Bytes() As Int32
            Dim b0 = Read_2Bytes()
            Dim b1 = Read_2Bytes()
            Return (b0 << 16) + b1
        End Function

    End Class
End Class

Public Class ByteCode_Decoder

    Public Function Decode(bytes As ByteSource.Reader) As IL.ILCode
        Dim code As New IL.ILCode

        While Not (bytes.EoB)
            Dim b As Byte = bytes.ReadByte
            Select Case b
#Region "0x0_"
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
                Case &H0E : code.Add(Asm.ldarg_s(bytes.ReadByte))
                Case &H0F : code.Add(Asm.ldarga_s(bytes.ReadByte))
#End Region
#Region "0x1_"
                'Case &H10 : code.Add(Asm.starg_s)
                'Case &H11 : code.Add(Asm.ldloc_s)
                'Case &H12 : code.Add(Asm.ldloca_s)
                'Case &H13 : code.Add(Asm.stloc_s)
                Case &H14 : code.Add(Asm.ldnull)
                Case &H15 : code.Add(Asm.ldc_i4_m1)
                Case &H16 : code.Add(Asm.ldc_i4_0)
                Case &H17 : code.Add(Asm.ldc_i4_1)
                Case &H18 : code.Add(Asm.ldc_i4_2)
                Case &H19 : code.Add(Asm.ldc_i4_3)
                Case &H1A : code.Add(Asm.ldc_i4_4)
                Case &H1B : code.Add(Asm.ldc_i4_5)
                Case &H1C : code.Add(Asm.ldc_i4_6)
                Case &H1D : code.Add(Asm.ldc_i4_7)
                Case &H1E : code.Add(Asm.ldc_i4_8)
                'Case &H1F : code.Add(Asm.ldc_i4_s)
#End Region
#Region "0x2_"
                Case &H20 : code.Add(Asm.ldc_i4(bytes.Read_4Bytes))
                Case &H21 : code.Add(Asm.ldc_i8(bytes.Read_8Bytes))
                Case &H22 : code.Add(Asm.ldc_r4(bytes.Read_4Bytes))
                Case &H23 : code.Add(Asm.ldc_r8(bytes.Read_8Bytes))
                'Case &H24
                Case &H25 : code.Add(Asm.dup)
                Case &H26 : code.Add(Asm.pop)
                Case &H27
                    Read_MetaDataToken(b, bytes, code)
                Case &H28, &H29
                    ReadCall(b, bytes, code)
                Case &H2A : code.Add(Asm.ret)
                ' - Branching IL
                Case &H28, &H2B, &H2C, &H2D, &H2E, &H2F
                    ReadBranch(b, bytes, code)
#End Region
#Region "0x3_"
                Case &H30, &H31, &H32, &H33, &H34, &H35, &H36, &H37,
                     &H38, &H39, &H3A, &H3B, &H3C, &H3D, &H3E, &H3F
                    ReadBranch(b, bytes, code)
#End Region
#Region "0x4_"
                Case &H40, &H41, &H42, &H43, &H44
                    ReadBranch(b, bytes, code)
                Case &H45 : ReadSwitch(bytes, code)
                Case &H46 : code.Add(Asm.ldind_i1)
                Case &H47 : code.Add(Asm.ldind_u1)
                Case &H48 : code.Add(Asm.ldind_i2)
                Case &H49 : code.Add(Asm.ldind_u2)
                Case &H4A : code.Add(Asm.ldind_i4)
                Case &H4B : code.Add(Asm.ldind_u4)
                Case &H4C : code.Add(Asm.ldind_i8)
                Case &H4C : code.Add(Asm.ldind_u8)
                Case &H4D : code.Add(Asm.ldind_i)
                Case &H4E : code.Add(Asm.ldind_r4)
                Case &H4F : code.Add(Asm.ldind_r8)
#End Region
#Region "0x5_"
                Case &H50 : code.Add(Asm.ldind_ref)
                Case &H51 : code.Add(Asm.stind_ref)
                Case &H52 : code.Add(Asm.stind_i1)
                Case &H53 : code.Add(Asm.stind_i2)
                Case &H54 : code.Add(Asm.stind_i4)
                Case &H55 : code.Add(Asm.stind_i8)
                Case &H56 : code.Add(Asm.stind_r4)
                Case &H57 : code.Add(Asm.stind_r8)
                Case &H58 : code.Add(Asm.add)
                Case &H59 : code.Add(Asm.sub)
                Case &H5A : code.Add(Asm.mul)
                Case &H5B : code.Add(Asm.div)
                Case &H5C : code.Add(Asm.div_u)
                Case &H5D : code.Add(Asm.[rem])
                Case &H5E : code.Add(Asm.rem_un)
                Case &H5F : code.Add(Asm.and)
#End Region
#Region "0x6_"
                Case &H60 : code.Add(Asm.or)
                Case &H61 : code.Add(Asm.xor)
                Case &H62 : code.Add(Asm.shl)
                Case &H63 : code.Add(Asm.shr)
                Case &H64 : code.Add(Asm.shr_un)
                Case &H65 : code.Add(Asm.neg)
                Case &H66 : code.Add(Asm.not)
                Case &H67 : code.Add(Asm.conv_i1)
                Case &H68 : code.Add(Asm.conv_i2)
                Case &H69 : code.Add(Asm.conv_i4)
                Case &H6A : code.Add(Asm.conv_i8)
                Case &H6B : code.Add(Asm.conv_r4)
                Case &H6C : code.Add(Asm.conv_r8)
                Case &H6D : code.Add(Asm.conv_u4)
                Case &H6E : code.Add(Asm.conv_u8)
                Case &H6F : ReadCall(b, bytes, code)
#End Region
#Region "0x7_"
                'Case &H70
                'Case &H71
                'Case &H72
                'Case &H73
                'Case &H74
                'Case &H75
                Case &H76 : code.Add(Asm.conv_r_un)
                'Case &H77
                'Case &H78
                'Case &H79
                Case &H7A : code.Add(Asm.throw)
                'Case &H7B
                'Case &H7C
                'Case &H7D
                'Case &H7E
                'Case &H7F
#End Region
#Region "0x8_"
                'Case &H80 'stsfld
                'Case &H81 'stobj
                Case &H82 : code.Add(Asm.conv_ovf_i1_un)
                Case &H83 : code.Add(Asm.conv_ovf_i2_un)
                Case &H84 : code.Add(Asm.conv_ovf_i4_un)
                Case &H85 : code.Add(Asm.conv_ovf_i8_un)
                Case &H86 : code.Add(Asm.conv_ovf_u1_un)
                Case &H87 : code.Add(Asm.conv_ovf_u2_un)
                Case &H88 : code.Add(Asm.conv_ovf_u4_un)
                Case &H89 : code.Add(Asm.conv_ovf_u8_un)
                Case &H8A : code.Add(Asm.conv_ovf_i_un)
                Case &H8B : code.Add(Asm.conv_ovf_u_un)
                'Case &H8C 'box
                'Case &H8D 'newarr
                Case &H8E : code.Add(Asm.ldlen)
                'Case &H8F 'ldelema

#End Region
#Region "0x9_"
                Case &H90 : code.Add(Asm.ldlelem_i1)
                Case &H91 : code.Add(Asm.ldlelem_u1)
                Case &H92 : code.Add(Asm.ldlelem_i2)
                Case &H93 : code.Add(Asm.ldlelem_u2)
                Case &H94 : code.Add(Asm.ldlelem_i4)
                Case &H95 : code.Add(Asm.ldlelem_u4)
                Case &H96 : code.Add(Asm.ldlelem_i8)
                Case &H96 : code.Add(Asm.ldlelem_u8)
                Case &H97 : code.Add(Asm.ldlelem_i)
                Case &H98 : code.Add(Asm.ldlelem_r4)
                Case &H99 : code.Add(Asm.ldlelem_r8)
                Case &H9A : code.Add(Asm.ldlelem_ref)
                'Case &H9B 'stelem.i
                'Case &H9C 'stelem.i1
                'Case &H9D 'stelem.i2
                'Case &H9E 'stelem.i4
                'Case &H9F 'stelem.i8

#End Region
#Region "0xA_"
                'Case &HA0 'stelem.r4
                'Case &HA1 'stelem.r8
                'Case &HA2 'stelem.ref
                'Case &HA3 'ldelem
                'Case &HA4 'stelem
                'Case &HA5 'unbox.any
                'Case &HA6
                'Case &HA7
                'Case &HA8
                'Case &HA9
                'Case &HAA
                'Case &HAB
                'Case &HAC
                'Case &HAD
                'Case &HAE
                'Case &HAF
#End Region
#Region "0xB_"
                'Case &HB0
                'Case &HB1
                'Case &HB2 
                Case &HB3 : code.Add(Asm.conv_ovf_i1)
                Case &HB4 : code.Add(Asm.conv_ovf_u1)
                Case &HB5 : code.Add(Asm.conv_ovf_i2)
                Case &HB6 : code.Add(Asm.conv_ovf_u2)
                Case &HB7 : code.Add(Asm.conv_ovf_i4)
                Case &HB8 : code.Add(Asm.conv_ovf_u4)
                Case &HB9 : code.Add(Asm.conv_ovf_i8)
                Case &HBA : code.Add(Asm.conv_ovf_u8)
                'Case &HBB
                'Case &HBC
                'Case &HBD
                'Case &HBE
                'Case &HBF
#End Region
#Region "0xC_"
                'Case &HC0
                'Case &HC1
                'Case &HC2
                Case &HC3 : code.Add(Asm.ckfinite)
                'Case &HC4
                'Case &HC5
                'Case &HC6
                'Case &HC7
                'Case &HC8
                'Case &HC9
                'Case &HCA
                'Case &HCB
                'Case &HCC
                'Case &HC5
                'Case &HC6
                'Case &HC7
                'Case &HCD
                'Case &HCE
                'Case &HCF
#End Region
#Region "0xD_"
                'Case &HD0_
                Case &HD1 : code.Add(Asm.conv_u2)
                Case &HD2 : code.Add(Asm.conv_u1)
                Case &HD3 : code.Add(Asm.conv_i)
                Case &HD4 : code.Add(Asm.conv_ovf_i)
                Case &HD5 : code.Add(Asm.conv_ovf_u)
                Case &HD6 : code.Add(Asm.add_ovf)
                Case &HD7 : code.Add(Asm.add_ovf_un)
                Case &HD8 : code.Add(Asm.sub_ovf)
                Case &HD9 : code.Add(Asm.sub_ovf_un)
                Case &HDA : code.Add(Asm.mul_ovf)
                Case &HDB : code.Add(Asm.mul_ovf_un)
                Case &HDC : code.Add(Asm.endfinally)
                'Case &HDD
                'Case &HDE
                Case &HDF : code.Add(Asm.stind_i)
#End Region
#Region "0xE_"
                Case &HE0 : code.Add(Asm.conv_u)
                'Case &HE1
                'Case &HE2
                'Case &HE3
                'Case &HE4
                'Case &HE5
                'Case &HE6
                'Case &HE7
                'Case &HE8
                'Case &HE9
                'Case &HEA
                'Case &HEB
                'Case &HEC
                'Case &HED
                'Case &HEE
                'Case &HEF

#End Region
#Region "0xF_"
                'Case &HF1
                'Case &HF2
                'Case &HF3
                'Case &HF4
                'Case &HF5
                'Case &HF6
                'Case &HF7
                'Case &HF8
                'Case &HF9
                'Case &HFA
                'Case &HFB
                'Case &HFC
                'Case &HFD
                'Case &HFE
                'Case &HFF
                'Case &HF1
                'Case &HF2
                'Case &HF3
                'Case &HF4
                'Case &HF5
                'Case &HF6
                'Case &HF7
                'Case &HF8
                'Case &HF9
                'Case &HFA
                'Case &HFB
                'Case &HFC
                'Case &HFD
                'Case &HFE : code = Read_Prefixed(bytes, code)
                'Case &HFF
#End Region
                Case Else
                    Throw New UnrecognisedByteCode(b)
            End Select
        End While

        Return code
    End Function

    Private Function ReadCall(b As Byte, bytes As ByteSource.Reader, code As IL.ILCode) As IL.ILCode
        Select Case b
            Case &H28
                Dim addr = bytes.Read_4Bytes
                code.Add(Asm.call(addr))
            Case &H29
                Dim addr = bytes.Read_4Bytes
                code.Add(Asm.calli(addr))
            Case &H6F
                Dim addr = bytes.Read_4Bytes
                code.Add(Asm.callvirt(addr))
            Case Else
                Throw New UnrecognisedByteCode(b)
        End Select
        Return code
    End Function

    Private Function ReadBranch(b As Byte, bytes As ByteSource.Reader, code As IL.ILCode) As IL.ILCode
        Select Case b
            ' Short Branch
            Case &H2B : code.Add(Asm.br_s(bytes.ReadByte))

            Case &H2C : code.Add(Asm.brfalse_s(bytes.ReadByte))
            Case &H2C : code.Add(Asm.brnull_s(bytes.ReadByte))
            Case &H2C : code.Add(Asm.brzero_s(bytes.ReadByte))

            Case &H2D : code.Add(Asm.brtrue_s(bytes.ReadByte))
            Case &H2D : code.Add(Asm.brinst_s(bytes.ReadByte))

            Case &H2E : code.Add(Asm.beq_s(bytes.ReadByte))
            Case &H2F : code.Add(Asm.bge_s(bytes.ReadByte))
            Case &H30 : code.Add(Asm.bgt_s(bytes.ReadByte))
            Case &H31 : code.Add(Asm.ble_s(bytes.ReadByte))
            Case &H32 : code.Add(Asm.blt_s(bytes.ReadByte))
            Case &H33 : code.Add(Asm.bne_un_s(bytes.ReadByte))
            Case &H34 : code.Add(Asm.bge_un_s(bytes.ReadByte))
            Case &H35 : code.Add(Asm.bgt_un_s(bytes.ReadByte))
            Case &H36 : code.Add(Asm.ble_un_s(bytes.ReadByte))
            Case &H37 : code.Add(Asm.blt_un_s(bytes.ReadByte))


            Case &H38 : code.Add(Asm.br(bytes.ReadByte, bytes.ReadByte, bytes.ReadByte, bytes.ReadByte))
            Case &H39 : code.Add(Asm.brfalse(bytes.ReadByte, bytes.ReadByte, bytes.ReadByte, bytes.ReadByte))
            Case &H39 : code.Add(Asm.brnull(bytes.ReadByte, bytes.ReadByte, bytes.ReadByte, bytes.ReadByte))
            Case &H39 : code.Add(Asm.brzero(bytes.ReadByte, bytes.ReadByte, bytes.ReadByte, bytes.ReadByte))

            Case &H3A : code.Add(Asm.brtrue(bytes.ReadByte, bytes.ReadByte, bytes.ReadByte, bytes.ReadByte))
            Case &H3A : code.Add(Asm.brinst(bytes.ReadByte, bytes.ReadByte, bytes.ReadByte, bytes.ReadByte))
            Case &H3B : code.Add(Asm.beq(bytes.ReadByte, bytes.ReadByte, bytes.ReadByte, bytes.ReadByte))
            Case &H3C : code.Add(Asm.bge(bytes.ReadByte, bytes.ReadByte, bytes.ReadByte, bytes.ReadByte))
            Case &H3D : code.Add(Asm.bgt(bytes.ReadByte, bytes.ReadByte, bytes.ReadByte, bytes.ReadByte))
            Case &H3E : code.Add(Asm.ble(bytes.ReadByte, bytes.ReadByte, bytes.ReadByte, bytes.ReadByte))
            Case &H3F : code.Add(Asm.blt(bytes.ReadByte, bytes.ReadByte, bytes.ReadByte, bytes.ReadByte))
            Case &H40 : code.Add(Asm.bne_un(bytes.ReadByte, bytes.ReadByte, bytes.ReadByte, bytes.ReadByte))
            Case &H41 : code.Add(Asm.bge_un(bytes.ReadByte, bytes.ReadByte, bytes.ReadByte, bytes.ReadByte))
            Case &H42 : code.Add(Asm.bgt_un(bytes.ReadByte, bytes.ReadByte, bytes.ReadByte, bytes.ReadByte))
            Case &H43 : code.Add(Asm.ble_un(bytes.ReadByte, bytes.ReadByte, bytes.ReadByte, bytes.ReadByte))
            Case &H44 : code.Add(Asm.blt_un(bytes.ReadByte, bytes.ReadByte, bytes.ReadByte, bytes.ReadByte))

            Case Else
                Throw New UnrecognisedByteCode(b)
        End Select
        Return code
    End Function

    Private Function Read_MetaDataToken(b As Byte, bytes As ByteSource.Reader, code As IL.ILCode) As IL.ILCode
        Select Case b
            Case &H27
                Dim b4 = bytes.Read_4Bytes
                code.Add(Asm.jmp(b4))
            Case Else
        End Select
        Return code
    End Function

    Private Function ReadSwitch(b As ByteSource.Reader, code As IL.ILCode) As IL.ILCode
        Dim N = CUInt(b.Read_4Bytes)
        Dim cases As New List(Of Int32)(N)
        For i As UInt32 = 1 To N
            Dim c = b.Read_4Bytes
            cases.Add(i)
        Next
        code.Add(Asm.switch(N, cases))
        Return code
    End Function

    Private Function Read_Prefixed(bytes As ByteSource.Reader, code As IL.ILCode) As IL.ILCode
        Dim b As Byte = bytes.ReadByte
        Select Case b
            Case &H00 : code.Add(Asm.ArgList)
            Case &H01 : code.Add(Asm.ceq)
            Case &H02 : code.Add(Asm.cgt)
            Case &H03 : code.Add(Asm.cgt_un)
            Case &H04 : code.Add(Asm.clt)
            Case &H05 : code.Add(Asm.clt_un)
            '    Case &H06 : code.Add(Asm.ldftn)
            '    Case &H07 : code.Add(Asm.ldvirtftn)
            ' Case &H08 : code.Add(Asm.ldarg)
            Case &H09 : code.Add(Asm.ldarg(bytes.Read_2Bytes()))
            Case &H0A : code.Add(Asm.ldarga(bytes.Read_2Bytes()))
            '    Case &H0B : code.Add(Asm.starg)
            '    Case &H0C : code.Add(Asm.ldloc)
            '    Case &H0D : code.Add(Asm.ldloca)
            '    Case &H0E : code.Add(Asm.stloc)
            Case &H0F : code.Add(Asm.localloc)
            'Case &H10
            Case &H11 : code.Add(Asm.EndFilter)
            '    Case &H12 : code.Add(Asm.unalligned)
            Case &H13 : code.Add(Asm.volatile_)
            Case &H14 : code.Add(Asm.tail_)
            '    Case &H15 : code.Add(Asm.initobj)
            '    Case &H16 : code.Add(Asm.constrained)
            Case &H17 : code.Add(Asm.cpblk)
            Case &H18 : code.Add(Asm.initblk)
            '    Case &H19 : code.Add(Asm.no_)
            Case &H1A : code.Add(Asm.rethrow)
            '    Case &H1C : code.Add(Asm.sizeof)
            '    Case &H1D : code.Add(Asm.refanytype)
            '    Case &H1E : code.Add(Asm.readonly)
            Case Else
                Throw New UnrecognisedByteCode(b)
        End Select
        Return code
    End Function


End Class
