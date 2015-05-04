Namespace Global.IL
    Namespace Sarc.Asm
        <HideModuleName>
        Public Module Factory
            Public ReadOnly Property nop As New Instructions.nop()
            Public ReadOnly Property break As New Instructions.break()

            Public ReadOnly Property ldarg_0 As New Instructions.ldarg_0()
            Public ReadOnly Property ldarg_1 As New Instructions.ldarg_1()
            Public ReadOnly Property ldarg_2 As New Instructions.ldarg_2()
            Public ReadOnly Property ldarg_3 As New Instructions.ldarg_3()

            Public ReadOnly Property ldloc_0 As New Instructions.ldloc_0()
            Public ReadOnly Property ldloc_1 As New Instructions.ldloc_1()
            Public ReadOnly Property ldloc_2 As New Instructions.ldloc_2()
            Public ReadOnly Property ldloc_3 As New Instructions.ldloc_3()

            Public ReadOnly Property stloc_0 As New Instructions.stloc_0()
            Public ReadOnly Property stloc_1 As New Instructions.stloc_1()
            Public ReadOnly Property stloc_2 As New Instructions.stloc_2()
            Public ReadOnly Property stloc_3 As New Instructions.stloc_3()
            Public Function ldarg_s(num As Byte) As Instructions.ldarg_s
                Return New Instructions.ldarg_s(num)
            End Function
            Public Function ldarg(num As UInt16) As Instructions.ldarg
                Return New Instructions.ldarg(num)
            End Function
            Public Function ldarga(num As UInt16) As Instructions.ldarga
                Return New Instructions.ldarga(num)
            End Function
            Public Function ldarga_s(num As Byte) As Instructions.ldarga_s
                Return New Instructions.ldarga_s(num)
            End Function
            Public ReadOnly Property ret As New Instructions.ret()
            Public ReadOnly Property [throw] As New Instructions.throw()
            Public ReadOnly Property rethrow As New Instructions.rethrow()
            Public ReadOnly Property ldlen As New Instructions.ldlen()

            Public ReadOnly Property ldlelem_i1 As New Instructions.ldelem_i1()
            Public ReadOnly Property ldlelem_i2 As New Instructions.ldelem_i2()
            Public ReadOnly Property ldlelem_i4 As New Instructions.ldelem_i4()
            Public ReadOnly Property ldlelem_i8 As New Instructions.ldelem_i8()
            Public ReadOnly Property ldlelem_u1 As New Instructions.ldelem_u1()
            Public ReadOnly Property ldlelem_u2 As New Instructions.ldelem_u2()
            Public ReadOnly Property ldlelem_u4 As New Instructions.ldelem_u4()
            Public ReadOnly Property ldlelem_u8 As New Instructions.ldelem_u8()
            Public ReadOnly Property ldlelem_r4 As New Instructions.ldelem_r4()
            Public ReadOnly Property ldlelem_r8 As New Instructions.ldelem_r8()
            Public ReadOnly Property ldlelem_i As New Instructions.ldelem_i()
            Public ReadOnly Property ldlelem_ref As New Instructions.ldelem_ref()

            Public ReadOnly Property stind_i1 As New Instructions.stind_i1
            Public ReadOnly Property stind_i2 As New Instructions.stind_i2
            Public ReadOnly Property stind_i4 As New Instructions.stind_i4
            Public ReadOnly Property stind_i8 As New Instructions.stind_i8
            Public ReadOnly Property stind_r4 As New Instructions.stind_r4
            Public ReadOnly Property stind_r8 As New Instructions.stind_r8
            Public ReadOnly Property stind_i As New Instructions.stind_i
            Public ReadOnly Property stind_ref As New Instructions.stind_ref
            Public ReadOnly Property ldind_i1 As New Instructions.ldind_i1
            Public ReadOnly Property ldind_i2 As New Instructions.ldind_i2
            Public ReadOnly Property ldind_i4 As New Instructions.ldind_i4
            Public ReadOnly Property ldind_i8 As New Instructions.ldind_i8
            Public ReadOnly Property ldind_u1 As New Instructions.ldind_u1
            Public ReadOnly Property ldind_u2 As New Instructions.ldind_u2
            Public ReadOnly Property ldind_u4 As New Instructions.ldind_u4
            Public ReadOnly Property ldind_u8 As New Instructions.ldind_u8
            Public ReadOnly Property ldind_r4 As New Instructions.ldind_r4
            Public ReadOnly Property ldind_r8 As New Instructions.ldind_r8
            Public ReadOnly Property ldind_i As New Instructions.ldind_i
            Public ReadOnly Property ldind_ref As New Instructions.ldind_ref
            Public Function leave(num As Int32) As Instructions.leave
                Return New Instructions.leave(num)
            End Function
            Public Function leave_s(num As SByte) As Instructions.leave_s
                Return New Instructions.leave_s(num)
            End Function
            Public Function starg_s(num As SByte) As Instructions.starg_s
                Return New Instructions.starg_s(num)
            End Function
            Public Function starg(num As UInt16) As Instructions.starg
                Return New Instructions.starg(num)
            End Function
            Public Function ldc_i4(num As Int32) As Instructions.ldc_i4
                Return New Instructions.ldc_i4(num)
            End Function
            Public Function ldc_i8(num As Int64) As Instructions.ldc_i8
                Return New Instructions.ldc_i8(num)
            End Function
            Public Function ldc_r4(num As Int32) As Instructions.ldc_r4
                Return New Instructions.ldc_r4(num)
            End Function
            Public Function ldc_r8(num As Int64) As Instructions.ldc_r8
                Return New Instructions.ldc_r8(num)
            End Function
            Public Function ldc_i4_s(num As Byte) As Instructions.ldc_i4_s
                Return New Instructions.ldc_i4_s(num)
            End Function
            Public Function ldloc_s(num As Byte) As Instructions.ldloc_s
                Return New Instructions.ldloc_s(num)
            End Function
            Public Function ldloc(num As UInt16) As Instructions.ldloc
                Return New Instructions.ldloc(num)
            End Function

            Public Function stloc_s(num As Byte) As Instructions.stloc_s
                Return New Instructions.stloc_s(num)
            End Function
            Public Function stloc(num As UInt16) As Instructions.stloc
                Return New Instructions.stloc(num)
            End Function

            Public Function ldloca_s(num As Byte) As Instructions.ldloca_s
                Return New Instructions.ldloca_s(num)
            End Function
            Public Function ldloca(num As UInt16) As Instructions.ldloca
                Return New Instructions.ldloca(num)
            End Function
            Public ReadOnly Property ldc_i4_0 As New Instructions.ldc_i4_0
            Public ReadOnly Property ldc_i4_1 As New Instructions.ldc_i4_1
            Public ReadOnly Property ldc_i4_2 As New Instructions.ldc_i4_2
            Public ReadOnly Property ldc_i4_3 As New Instructions.ldc_i4_3
            Public ReadOnly Property ldc_i4_4 As New Instructions.ldc_i4_4
            Public ReadOnly Property ldc_i4_5 As New Instructions.ldc_i4_5
            Public ReadOnly Property ldc_i4_6 As New Instructions.ldc_i4_6
            Public ReadOnly Property ldc_i4_7 As New Instructions.ldc_i4_7
            Public ReadOnly Property ldc_i4_8 As New Instructions.ldc_i4_8
            Public ReadOnly Property ldc_i4_m1 As New Instructions.ldc_i4_m1
            Public ReadOnly Property cpblk As New Instructions.cpblk

            Public ReadOnly Property initblk As New Instructions.initblk
            Public ReadOnly Property endfault As New Instructions.endfault
            Public ReadOnly Property endfinally As New Instructions.endfinally
            Public ReadOnly Property endfilter As New Instructions.endfilter

            Public ReadOnly Property conv_ovf_i1_un As New Instructions.conv_ovf_i1_un
            Public ReadOnly Property conv_ovf_i2_un As New Instructions.conv_ovf_i2_un
            Public ReadOnly Property conv_ovf_i4_un As New Instructions.conv_ovf_i4_un
            Public ReadOnly Property conv_ovf_i8_un As New Instructions.conv_ovf_i8_un
            Public ReadOnly Property conv_ovf_u1_un As New Instructions.conv_ovf_u1_un
            Public ReadOnly Property conv_ovf_u2_un As New Instructions.conv_ovf_u2_un
            Public ReadOnly Property conv_ovf_u4_un As New Instructions.conv_ovf_u4_un
            Public ReadOnly Property conv_ovf_u8_un As New Instructions.conv_ovf_u8_un
            Public ReadOnly Property conv_ovf_i_un As New Instructions.conv_ovf_i_un
            Public ReadOnly Property conv_ovf_u_un As New Instructions.conv_ovf_u_un


            Public ReadOnly Property conv_ovf_i1 As New Instructions.conv_ovf_i1
            Public ReadOnly Property conv_ovf_i2 As New Instructions.conv_ovf_i2
            Public ReadOnly Property conv_ovf_i4 As New Instructions.conv_ovf_i4
            Public ReadOnly Property conv_ovf_i8 As New Instructions.conv_ovf_i8
            Public ReadOnly Property conv_ovf_u1 As New Instructions.conv_ovf_u1
            Public ReadOnly Property conv_ovf_u2 As New Instructions.conv_ovf_u2
            Public ReadOnly Property conv_ovf_u4 As New Instructions.conv_ovf_u4
            Public ReadOnly Property conv_ovf_u8 As New Instructions.conv_ovf_u8
            Public ReadOnly Property conv_ovf_i As New Instructions.conv_ovf_i
            Public ReadOnly Property conv_ovf_u As New Instructions.conv_ovf_u

            Public ReadOnly Property conv_i1 As New Instructions.conv_i1
            Public ReadOnly Property conv_i2 As New Instructions.conv_i2
            Public ReadOnly Property conv_i4 As New Instructions.conv_i4
            Public ReadOnly Property conv_i8 As New Instructions.conv_i8
            Public ReadOnly Property conv_u1 As New Instructions.conv_u1
            Public ReadOnly Property conv_u2 As New Instructions.conv_u2
            Public ReadOnly Property conv_u4 As New Instructions.conv_u4
            Public ReadOnly Property conv_u8 As New Instructions.conv_u8
            Public ReadOnly Property conv_r4 As New Instructions.conv_r4
            Public ReadOnly Property conv_r8 As New Instructions.conv_r8
            Public ReadOnly Property conv_i As New Instructions.conv_i
            Public ReadOnly Property conv_u As New Instructions.conv_u
            Public ReadOnly Property conv_r_un As New Instructions.conv_r_un

            Public ReadOnly Property clt As New Instructions.clt

            Public ReadOnly Property clt_un As New Instructions.clt_un

            Public ReadOnly Property cgt As New Instructions.cgt

            Public ReadOnly Property cgt_un As New Instructions.cgt_un

            Public ReadOnly Property ceq As New Instructions.ceq

            Public Function [call](addr As Int32) As Instructions.call
                Return New Instructions.call(addr)
            End Function
            Public Function calli(addr As Int32) As Instructions.calli
                Return New Instructions.calli(addr)
            End Function
            Public Function callvirt(addr As Int32) As Instructions.callvirt
                Return New Instructions.callvirt(addr)
            End Function

            Public ReadOnly Property volatile_() As New Instructions.volatile_
            Public ReadOnly Property tail_() As New Instructions.tail_
            Public ReadOnly Property ArgList() As New Instructions.arglist

            Public ReadOnly Property ckfinite As New Instructions.ckfinite

            Public Function switch(n As UInt32, cases As List(Of Int32)) As Instructions.switch
                Return New IL.Instructions.switch(n, cases)
            End Function
            Public Function unbox(valuetype As UInt32) As Instructions.unbox
                Return New Instructions.unbox(New MetadataToken(valuetype))
            End Function
            Public Function unbox_any(typeTok As UInt32) As Instructions.unbox_any
                Return New Instructions.unbox_any(New MetadataToken(typeTok))
            End Function
            Public Function refanyval([type] As UInt32) As Instructions.refanyval
                Return New Instructions.refanyval(New MetadataToken([type]))
            End Function
            Public Function ldvirtftn(method As UInt32) As Instructions.ldvirtftn
                Return New Instructions.ldvirtftn(New MetadataToken(method))
            End Function
            Public Function stelem(typeTok As UInt32) As Instructions.stelem
                Return New Instructions.stelem(New MetadataToken(typeTok))
            End Function
            Public Function stfld(field As UInt32) As Instructions.stfld
                Return New Instructions.stfld(New MetadataToken(field))
            End Function
            Public Function mkrefany([class] As UInt32) As Instructions.mkrefany
                Return New Instructions.mkrefany(New MetadataToken([class]))
            End Function
            Public Function ldelem(typeTok As UInt32) As Instructions.ldelem
                Return New Instructions.ldelem(New MetadataToken(typeTok))
            End Function
            Public Function ldelema([class] As UInt32) As Instructions.ldelema
                Return New Instructions.ldelema(New MetadataToken([class]))
            End Function
            Public Function ldfld(field As UInt32) As Instructions.ldfld
                Return New Instructions.ldfld(New MetadataToken(field))
            End Function
            Public Function ldflda(field As UInt32) As Instructions.ldflda
                Return New Instructions.ldflda(New MetadataToken(field))
            End Function
            Public Function ldsfld(field As UInt32) As Instructions.ldsfld
                Return New Instructions.ldsfld(New MetadataToken(field))
            End Function
            Public Function ldsflda(field As UInt32) As Instructions.ldsflda
                Return New Instructions.ldsflda(New MetadataToken(field))
            End Function
            Public Function ldobj(typeTok As UInt32) As Instructions.ldobj
                Return New Instructions.ldobj(New MetadataToken(typeTok))
            End Function
            Public Function sizeof(typeTok As UInt32) As Instructions.sizeof
                Return New Instructions.sizeof(New MetadataToken(typeTok))
            End Function
            Public Function ldstr([string] As UInt32) As Instructions.ldstr
                Return New Instructions.ldstr(New MetadataToken([string]))
            End Function
            Public Function ldtoken(token As UInt32) As Instructions.ldtoken
                Return New Instructions.ldtoken(New MetadataToken(token))
            End Function
            Public Function jmp(b4 As UInt32) As Instructions.jmp
                Return New Instructions.jmp(New MetadataToken(b4))
            End Function
            Public Function castclass([class] As UInt32) As Instructions.castclass
                Return New Instructions.castclass(New MetadataToken([class]))
            End Function
            Public Function cpobj(typeTok As UInt32) As Instructions.cpobj
                Return New Instructions.cpobj(New MetadataToken(typeTok))
            End Function
            Public Function initobj(typeTok As UInt32) As Instructions.initobj
                Return New Instructions.initobj(New MetadataToken(typeTok))
            End Function
            Public Function stsfld(field As UInt32) As Instructions.stsfld
                Return New Instructions.stsfld(New MetadataToken(field))
            End Function
            Public Function stobj(typeTok As UInt32) As Instructions.stobj
                Return New Instructions.stobj(New MetadataToken(typeTok))
            End Function
            Public Function initclass([class] As UInt32) As Instructions.initclass
                Return New Instructions.initclass(New MetadataToken([class]))
            End Function
            Public Function newarr(eType As UInt32) As Instructions.newarr
                Return New Instructions.newarr(New MetadataToken(eType))
            End Function
            Public Function newobj(ctor As UInt32) As Instructions.newobj
                Return New Instructions.newobj(New MetadataToken(ctor))
            End Function
            Public Function Refanytype() As Instructions.Refanytype
                Return New Instructions.Refanytype()
            End Function


#Region "Branches"
#Region "Short"
            Public Function brtrue_s(b0 As Byte) As Instructions.brtrue_s
                Return New Instructions.brtrue_s(b0)
            End Function
            Public Function br_s(b0 As Byte) As Instructions.br_s
                Return New Instructions.br_s(b0)
            End Function
            Public Function brinst_s(b0 As Byte) As Instructions.brinst_s
                Return New Instructions.brinst_s(b0)
            End Function

            Public Function brfalse_s(b0 As Byte) As Instructions.brfalse_s
                Return New Instructions.brfalse_s(b0)
            End Function
            Public Function brnull_s(b0 As Byte) As Instructions.brnull_s
                Return New Instructions.brnull_s(b0)
            End Function
            Public Function brzero_s(b0 As Byte) As Instructions.brzero_s
                Return New Instructions.brzero_s(b0)
            End Function
            Public Function beq_s(b0 As Byte) As Instructions.beq_s
                Return New Instructions.beq_s(b0)
            End Function
            Public Function blt_s(b0 As Byte) As Instructions.blt_s
                Return New Instructions.blt_s(b0)
            End Function
            Public Function ble_s(b0 As Byte) As Instructions.ble_s
                Return New Instructions.ble_s(b0)
            End Function
            Public Function bgt_s(b0 As Byte) As Instructions.bgt_s
                Return New Instructions.bgt_s(b0)
            End Function
            Public Function bge_s(b0 As Byte) As Instructions.bge_s
                Return New Instructions.bge_s(b0)
            End Function
            Public Function bne_un_s(b0 As Byte) As Instructions.bne_un_s
                Return New Instructions.bne_un_s(b0)
            End Function
            Public Function bge_un_s(b0 As Byte) As Instructions.bge_un_s
                Return New Instructions.bge_un_s(b0)
            End Function
            Public Function bgt_un_s(b0 As Byte) As Instructions.bgt_un_s
                Return New Instructions.bgt_un_s(b0)
            End Function
            Public Function ble_un_s(b0 As Byte) As Instructions.ble_un_s
                Return New Instructions.ble_un_s(b0)
            End Function
            Public Function blt_un_s(b0 As Byte) As Instructions.blt_un_s
                Return New Instructions.blt_un_s(b0)
            End Function
#End Region
#Region "long"
            Public Function brtrue(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte) As Instructions.brtrue
                Return New Instructions.brtrue(b0, b1, b2, b3)
            End Function
            Public Function brinst(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte) As Instructions.brinst
                Return New Instructions.brinst(b0, b1, b2, b3)
            End Function
            Public Function br(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte) As Instructions.br
                Return New Instructions.br(b0, b1, b2, b3)
            End Function
            Public Function brfalse(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte) As Instructions.brfalse
                Return New Instructions.brfalse(b0, b1, b2, b3)
            End Function
            Public Function brnull(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte) As Instructions.brnull
                Return New Instructions.brnull(b0, b1, b2, b3)
            End Function
            Public Function brzero(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte) As Instructions.brzero
                Return New Instructions.brzero(b0, b1, b2, b3)
            End Function
            Public Function beq(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte) As Instructions.beq
                Return New Instructions.beq(b0, b1, b2, b3)
            End Function
            Public Function bge(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte) As Instructions.bge
                Return New Instructions.bge(b0, b1, b2, b3)
            End Function

            Public Function bgt(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte) As Instructions.bgt
                Return New Instructions.bgt(b0, b1, b2, b3)
            End Function
            Public Function ble(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte) As Instructions.ble
                Return New Instructions.ble(b0, b1, b2, b3)
            End Function
            Public Function blt(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte) As Instructions.blt
                Return New Instructions.blt(b0, b1, b2, b3)
            End Function


            Public Function bne_un(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte) As Instructions.bne_un
                Return New Instructions.bne_un(b0, b1, b2, b3)
            End Function
            Public Function bge_un(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte) As Instructions.bge_un
                Return New Instructions.bge_un(b0, b1, b2, b3)
            End Function
            Public Function bgt_un(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte) As Instructions.bgt_un
                Return New Instructions.bgt_un(b0, b1, b2, b3)
            End Function
            Public Function ble_un(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte) As Instructions.ble_un
                Return New Instructions.ble_un(b0, b1, b2, b3)
            End Function
            Public Function blt_un(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte) As Instructions.blt_un
                Return New Instructions.blt_un(b0, b1, b2, b3)
            End Function
#End Region
#End Region
#Region "Arithematical"
            Public ReadOnly Property add As New Instructions.add()
            Public ReadOnly Property add_ovf As New Instructions.add_ovf()
            Public ReadOnly Property add_ovf_un As New Instructions.add_ovf_un()
            Public ReadOnly Property [sub] As New Instructions.sub()
            Public ReadOnly Property sub_ovf As New Instructions.sub_ovf()
            Public ReadOnly Property sub_ovf_un As New Instructions.sub_ovf_un()
            Public ReadOnly Property mul As New Instructions.mul()
            Public ReadOnly Property mul_ovf As New Instructions.mul_ovf()
            Public ReadOnly Property mul_ovf_un As New Instructions.mul_ovf_un()
            Public ReadOnly Property div As New Instructions.div()
            Public ReadOnly Property div_u As New Instructions.div_un()

            Public ReadOnly Property [rem] As New Instructions.[rem]()
            Public ReadOnly Property rem_un As New Instructions.rem_un()
            Public ReadOnly Property [or] As New Instructions.[or]()
            Public ReadOnly Property [xor] As New Instructions.[xor]()
            Public ReadOnly Property [and] As New Instructions.[and]()
            Public ReadOnly Property [not] As New Instructions.[not]()

            Public ReadOnly Property neg As New Instructions.neg()
            Public ReadOnly Property shl As New Instructions.shl()
            Public ReadOnly Property shr As New Instructions.shr()
            Public ReadOnly Property shr_un As New Instructions.shr_un()

#End Region
            Public ReadOnly Property pop As New Instructions.pop()
            Public ReadOnly Property dup As New Instructions.dup()

            Public ReadOnly Property localloc As New Instructions.localloc()
            Public ReadOnly Property ldnull As New Instructions.ldnull()

        End Module
    End Namespace





    Namespace Instructions
        Public Class nop
            Inherits IL_Instruction

            Protected Friend Sub New()
                MyBase.New(OpCode.OpCodes.nop)
            End Sub
        End Class
        Public Class arglist
            Inherits IL_Instruction

            Protected Friend Sub New()
                MyBase.New(OpCode.OpCodes.arglist)
            End Sub
        End Class
        Public Class break
            Inherits IL_Instruction

            Protected Friend Sub New()
                MyBase.New(OpCode.OpCodes.break)
            End Sub
        End Class

        Public Class ldarg_0
            Inherits IL_Instruction

            Protected Friend Sub New()
                MyBase.New(OpCode.OpCodes.ldarg_0)
            End Sub

        End Class

        Public Class ldarg_1
            Inherits IL_Instruction

            Protected Friend Sub New()
                MyBase.New(OpCode.OpCodes.ldarg_1)
            End Sub

        End Class

        Public Class ldarg_2
            Inherits IL_Instruction

            Protected Friend Sub New()
                MyBase.New(OpCode.OpCodes.ldarg_2)
            End Sub

        End Class
        Public Class ldarg_3
            Inherits IL_Instruction

            Protected Friend Sub New()
                MyBase.New(OpCode.OpCodes.ldarg_3)
            End Sub

        End Class

        Public Class ldloc_0
            Inherits IL_Instruction

            Protected Friend Sub New()
                MyBase.New(OpCode.OpCodes.ldloc_0)

            End Sub
        End Class

        Public Class ldloc_1
            Inherits IL_Instruction

            Protected Friend Sub New()
                MyBase.New(OpCode.OpCodes.ldloc_1)

            End Sub
        End Class
        Public Class ldloc_2
            Inherits IL_Instruction

            Protected Friend Sub New()
                MyBase.New(OpCode.OpCodes.ldloc_2)
            End Sub

        End Class

        Public Class ldloc_3
            Inherits IL_Instruction

            Protected Friend Sub New()
                MyBase.New(OpCode.OpCodes.ldloc_3)
            End Sub

        End Class

        Public Class stloc_0
            Inherits IL_Instruction

            Protected Friend Sub New()
                MyBase.New(OpCode.OpCodes.stloc_0)
            End Sub

        End Class
        Public Class stloc_1
            Inherits IL_Instruction

            Protected Friend Sub New()
                MyBase.New(OpCode.OpCodes.stloc_1)
            End Sub

        End Class
        Public Class stloc_2
            Inherits IL_Instruction

            Protected Friend Sub New()
                MyBase.New(OpCode.OpCodes.stloc_2)
            End Sub

        End Class
        Public Class stloc_3
            Inherits IL_Instruction

            Protected Friend Sub New()
                MyBase.New(OpCode.OpCodes.stloc_3)
            End Sub

        End Class
        Public Class ldarg_s
            Inherits Value_UInt08

            Protected Friend Sub New(num As Byte)
                MyBase.New(OpCode.OpCodes.ldarg_s, num)
            End Sub

        End Class
        Public Class ldarga_s
            Inherits Value_UInt08

            Protected Friend Sub New(num As Byte)
                MyBase.New(OpCode.OpCodes.ldarga_s, num)
            End Sub

        End Class

        Public Class starg_s
            Inherits Value_UInt08

            Public Sub New(num As Byte)
                MyBase.New(OpCode.OpCodes.starg_s, num)
            End Sub

        End Class


        Public Class ldloca_s
            Inherits Value_UInt08

            Protected Friend Sub New(indx As Byte)
                MyBase.New(OpCode.OpCodes.ldloca_s, indx)
            End Sub

        End Class
        Public Class stloc_s
            Inherits Value_UInt08

            Public Sub New(indx As Byte)
                MyBase.New(OpCode.OpCodes.stloc_s, indx)
            End Sub

        End Class

        Public Class ldnull
            Inherits IL_Instruction

            Protected Friend Sub New()
                MyBase.New(OpCode.OpCodes.ldnull)
            End Sub

        End Class

        Public Class ldc_id_m1
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldc_id_m1)
            End Sub

        End Class
        Public Class ldc_i4_m1
            Inherits IL_Instruction

            Protected Friend Sub New()
                MyBase.New(OpCode.OpCodes.ldc_i4_M1)
            End Sub

        End Class
        Public Class ldc_i4_0
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldc_i4_0)
            End Sub

        End Class
        Public Class ldc_i4_1
            Inherits IL_Instruction

            Protected Friend Sub New()
                MyBase.New(OpCode.OpCodes.ldc_i4_1)
            End Sub

        End Class
        Public Class ldc_i4_2
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldc_i4_2)
            End Sub

        End Class
        Public Class ldc_i4_3
            Inherits IL_Instruction

            Protected Friend Sub New()
                MyBase.New(OpCode.OpCodes.ldc_i4_3)
            End Sub

        End Class

        Public Class ldc_i4_4
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldc_i4_4)
            End Sub

        End Class

        Public Class ldc_i4_5
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldc_i4_5)
            End Sub

        End Class


        Public Class ldc_i4_6
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldc_i4_6)
            End Sub

        End Class
        Public Class ldc_i4_7
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldc_i4_7)
            End Sub
        End Class
        Public Class ldc_i4_8
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldc_i4_8)
            End Sub
        End Class
        Public Class ldc_i4
            Inherits IL.Value_Int32
            Public Sub New(num)
                MyBase.New(OpCode.OpCodes.ldc_i4, num)
            End Sub
        End Class
        Public Class ldc_i8
            Inherits Value_Int64
            Public Sub New(num As Int64)
                MyBase.New(OpCode.OpCodes.ldc_i8, num)
            End Sub
        End Class

        Public Class ldc_r4
            Inherits Value_Float32
            Public Sub New(num As Single)
                MyBase.New(OpCode.OpCodes.ldc_r4, num)
            End Sub
        End Class
        Public Class ldc_r8
            Inherits Value_Float64
            Public Sub New(num As Double)
                MyBase.New(OpCode.OpCodes.ldc_r8, num)
            End Sub
        End Class
        Public Class dup
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.dup)
            End Sub
        End Class
        Public Class pop
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.pop)
            End Sub
        End Class


        Public MustInherit Class IL_Int32
            Inherits IL_Instruction
            Public ReadOnly Property Addr As Int32
            Public Sub New(opcode As OpCode, addr As Int32)
                MyBase.New(opcode)
                Me.Addr = addr
            End Sub
            Public Overrides Function GetBytes() As IEnumerable(Of Byte)
                Return MyBase.GetBytes().Concat(BitConverter.GetBytes(Addr))
            End Function

        End Class

        Public MustInherit Class IL_MetadataToken
            Inherits IL_Instruction
            Public ReadOnly Property Token As MetadataToken
            Public Sub New(opcode As OpCode, Token As MetadataToken)
                MyBase.New(opcode)
                Me.Token = Token
            End Sub
            Public Overrides Function GetBytes() As IEnumerable(Of Byte)
                Return MyBase.GetBytes().Concat(Me.Token.GetBytes())
            End Function

        End Class

        Public Class jmp
            Inherits IL_MetadataToken

            Public Sub New(Token As MetadataToken)
                MyBase.New(OpCode.OpCodes.jmp, Token)
            End Sub

        End Class


        Public Class [call]
            Inherits IL_Int32
            Public Sub New(addr As Int32)
                MyBase.New(OpCode.OpCodes.call, addr)
            End Sub

        End Class
        Public Class calli
            Inherits IL_Int32
            Public Sub New(addr As Int32)
                MyBase.New(OpCode.OpCodes.calli, addr)
            End Sub
        End Class
        Public Class ret
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.ret)
            End Sub

        End Class

        Public Class brfalse_s
            Inherits IL.ILOp_b1

            Public Sub New(b0 As Byte)
                MyBase.New(OpCode.OpCodes.brfalse_s, b0)
            End Sub

        End Class
        Public Class brnull_s
            Inherits IL.ILOp_b1

            Public Sub New(b0 As Byte)
                MyBase.New(OpCode.OpCodes.brnull_s, b0)
            End Sub

        End Class
        Public Class brzero_s
            Inherits IL.ILOp_b1

            Public Sub New(b0 As Byte)
                MyBase.New(OpCode.OpCodes.brzero_s, b0)
            End Sub

        End Class
        Public Class brinst_s
            Inherits IL.ILOp_b1

            Public Sub New(b0 As Byte)
                MyBase.New(OpCode.OpCodes.brinst_s, b0)
            End Sub

        End Class
        Public Class brtrue_s
            Inherits IL.ILOp_b1

            Public Sub New(b0 As Byte)
                MyBase.New(OpCode.OpCodes.brtrue_s, b0)
            End Sub

        End Class
        Public Class beq
            Inherits ILOp_b4

            Public Sub New(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte)
                MyBase.New(OpCode.OpCodes.beq, b0, b1, b2, b3)
            End Sub

        End Class
        Public Class bge
            Inherits ILOp_b4

            Public Sub New(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte)
                MyBase.New(OpCode.OpCodes.bge, b0, b1, b2, b3)
            End Sub

        End Class
        Public Class bgt
            Inherits ILOp_b4

            Public Sub New(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte)
                MyBase.New(OpCode.OpCodes.bgt, b0, b1, b2, b3)
            End Sub

        End Class
        Public Class ble
            Inherits ILOp_b4

            Public Sub New(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte)
                MyBase.New(OpCode.OpCodes.ble, b0, b1, b2, b3)
            End Sub

        End Class
        Public Class blt
            Inherits ILOp_b4

            Public Sub New(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte)
                MyBase.New(OpCode.OpCodes.blt, b0, b1, b2, b3)
            End Sub

        End Class
        Public Class bne_un_s
            Inherits ILOp_b1

            Public Sub New(b0 As Byte)
                MyBase.New(OpCode.OpCodes.bne_un_s, b0)
            End Sub

        End Class
        Public Class bge_un_s
            Inherits ILOp_b1

            Public Sub New(b0 As Byte)
                MyBase.New(OpCode.OpCodes.bge_un_s, b0)
            End Sub

        End Class
        Public Class bgt_un_s
            Inherits ILOp_b1

            Public Sub New(b0 As Byte)
                MyBase.New(OpCode.OpCodes.bgt_un_s, b0)
            End Sub

        End Class
        Public Class ble_un_s
            Inherits ILOp_b1

            Public Sub New(b0 As Byte)
                MyBase.New(OpCode.OpCodes.ble_un_s, b0)
            End Sub

        End Class
        Public Class blt_un_s
            Inherits ILOp_b1

            Public Sub New(b0 As Byte)
                MyBase.New(OpCode.OpCodes.blt_un_s, b0)
            End Sub

        End Class
        Public Class br_s
            Inherits ILOp_b1
            Public Sub New(b0 As Byte)
                MyBase.New(OpCode.OpCodes.br_s, b0)
            End Sub
        End Class
        Public Class br
            Inherits ILOp_b4

            Public Sub New(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte)
                MyBase.New(OpCode.OpCodes.br_s, b0, b1, b2, b3)

            End Sub

        End Class
        Public Class brfalse
            Inherits ILOp_b4
            Public Sub New(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte)
                MyBase.New(OpCode.OpCodes.brfalse, b0, b1, b2, b3)
            End Sub

        End Class
        Public Class brnull
            Inherits ILOp_b4
            Public Sub New(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte)
                MyBase.New(OpCode.OpCodes.brnull, b0, b1, b2, b3)
            End Sub

        End Class
        Public Class brzero
            Inherits ILOp_b4
            Public Sub New(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte)
                MyBase.New(OpCode.OpCodes.brzero, b0, b1, b2, b3)
            End Sub
        End Class
        Public Class brtrue
            Inherits ILOp_b4
            Public Sub New(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte)
                MyBase.New(OpCode.OpCodes.brtrue, b0, b1, b2, b3)
            End Sub
        End Class
        Public Class brinst
            Inherits ILOp_b4
            Public Sub New(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte)
                MyBase.New(OpCode.OpCodes.brinist, b0, b1, b2, b3)
            End Sub
        End Class
        Public Class beq_s
            Inherits IL.ILOp_b1

            Public Sub New(b0 As Byte)
                MyBase.New(OpCode.OpCodes.beq_s, b0)
            End Sub

        End Class
        Public Class bge_s
            Inherits ILOp_b1

            Public Sub New(b0 As Integer)
                MyBase.New(OpCode.OpCodes.bge_s, b0)

            End Sub

        End Class
        Public Class bgt_s
            Inherits ILOp_b1

            Public Sub New(b0 As Integer)
                MyBase.New(OpCode.OpCodes.bgt_s, b0)
            End Sub

        End Class
        Public Class ble_s
            Inherits ILOp_b1

            Public Sub New(b0 As Integer)
                MyBase.New(OpCode.OpCodes.ble_s, b0)

            End Sub

        End Class
        Public Class blt_s
            Inherits ILOp_b1

            Public Sub New(b0 As Byte)
                MyBase.New(OpCode.OpCodes.blt_s, b0)

            End Sub

        End Class
        Public Class bne_un
            Inherits ILOp_b4
            Public Sub New(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte)
                MyBase.New(OpCode.OpCodes.bne_un, b0, b1, b2, b3)
            End Sub
        End Class
        Public Class bge_un
            Inherits ILOp_b4
            Public Sub New(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte)
                MyBase.New(OpCode.OpCodes.bge_un, b0, b1, b2, b3)
            End Sub
        End Class
        Public Class bgt_un
            Inherits ILOp_b4
            Public Sub New(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte)
                MyBase.New(OpCode.OpCodes.bgt_un, b0, b1, b2, b3)
            End Sub
        End Class
        Public Class ble_un
            Inherits ILOp_b4
            Public Sub New(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte)
                MyBase.New(OpCode.OpCodes.ble_un, b0, b1, b2, b3)
            End Sub
        End Class
        Public Class blt_un
            Inherits ILOp_b4
            Public Sub New(b0 As Byte, b1 As Byte, b2 As Byte, b3 As Byte)
                MyBase.New(OpCode.OpCodes.blt_un, b0, b1, b2, b3)
            End Sub
        End Class
        Public Class ldind_i1
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldind_i1)
            End Sub

        End Class
        Public Class ldind_u1
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldind_u1)
            End Sub

        End Class
        Public Class ldind_i2
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldind_i2)
            End Sub

        End Class
        Public Class ldind_u2
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldind_u2)
            End Sub

        End Class
        Public Class ldind_i4
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldind_i4)
            End Sub

        End Class
        Public Class ldind_u4
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldind_u4)
            End Sub

        End Class
        Public Class ldind_i8
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldind_i8)
            End Sub

        End Class
        Public Class ldind_u8
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldind_u8)
            End Sub

        End Class
        Public Class ldind_i
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldind_i)
            End Sub
        End Class
        Public Class ldind_r4
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldind_r4)
            End Sub

        End Class
        Public Class ldind_r8
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldind_r8)
            End Sub

        End Class
        Public Class ldind_ref
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldind_ref)
            End Sub
        End Class
        Public Class stind_ref
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.stind_ref)
            End Sub
        End Class
        Public Class stind_i1
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.stind_i1)
            End Sub
        End Class
        Public Class stind_i2
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.stind_i2)
            End Sub
        End Class
        Public Class stind_i4
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.stind_i4)
            End Sub
        End Class
        Public Class stind_i8
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.stind_i8)
            End Sub
        End Class
        Public Class stind_r4
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.stind_r4)
            End Sub
        End Class
        Public Class stind_r8
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.stind_r8)
            End Sub
        End Class
        Public Class stind_i
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.stind_i)
            End Sub
        End Class
        Public Class add
            Inherits IL_Instruction

            Protected Friend Sub New()
                MyBase.New(OpCode.OpCodes.add)
            End Sub

        End Class
        Public Class [sub]
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.sub)
            End Sub

        End Class
        Public Class mul
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.mul)
            End Sub

        End Class
        Public Class div
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.div)
            End Sub

        End Class
        Public Class div_un
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.div_un)
            End Sub

        End Class
        Public Class [rem]
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.[rem])
            End Sub

        End Class
        Public Class rem_un
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.rem_un)
            End Sub

        End Class
        Public Class [or]
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.[or])
            End Sub

        End Class
        Public Class [and]
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.[and])
            End Sub

        End Class
        Public Class [xor]
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.xor)
            End Sub

        End Class
        Public Class shl
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.shl)
            End Sub

        End Class
        Public Class shr
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.shr)
            End Sub

        End Class
        Public Class shr_un
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.shr_un)
            End Sub

        End Class
        Public Class neg
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.neg)
            End Sub

        End Class
        Public Class [not]
            Inherits IL_Instruction

            Public Sub New()
                MyBase.New(OpCode.OpCodes.[not])
            End Sub

        End Class
        Public Class conv_i1
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_i1)
            End Sub
        End Class
        Public Class conv_i2
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_i2)
            End Sub
        End Class
        Public Class conv_i4
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_i4)
            End Sub
        End Class
        Public Class conv_i8
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_i8)
            End Sub
        End Class
        Public Class conv_r4
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_r4)
            End Sub
        End Class
        Public Class conv_r8
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_r8)
            End Sub
        End Class
        Public Class conv_u4
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_r4)
            End Sub
        End Class
        Public Class conv_u8
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_r8)
            End Sub
        End Class
        Public Class callvirt
            Inherits IL_Int32
            Public Sub New(addr As Int32)
                MyBase.New(OpCode.OpCodes.callvirt, addr)
            End Sub
        End Class

        Public Class ldobj
            Inherits IL_MetadataToken
            Public Sub New(typeTok As MetadataToken)
                MyBase.New(OpCode.OpCodes.ldobj, typeTok)
            End Sub
        End Class
        Public Class ldsfield
            Inherits IL_MetadataToken
            Public Sub New(field As MetadataToken)
                MyBase.New(OpCode.OpCodes.ldobj, field)
            End Sub
        End Class

        Public Class newpobj
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.newobj)
            End Sub
        End Class
        Public Class castclass
            Inherits IL_MetadataToken
            Public Sub New(Token As MetadataToken)
                MyBase.New(OpCode.OpCodes.castclass, Token)
            End Sub
        End Class

        Public Class mkrefany
            Inherits IL_MetadataToken
            Public Sub New([class] As MetadataToken)
                MyBase.New(OpCode.OpCodes.cpobj, [class])
            End Sub
        End Class
        Public Class newobj
            Inherits IL_MetadataToken
            Public Sub New(ctor As MetadataToken)
                MyBase.New(OpCode.OpCodes.newobj, ctor)
            End Sub
        End Class
        Public Class newarr
            Inherits IL_MetadataToken
            Public Sub New(etype As MetadataToken)
                MyBase.New(OpCode.OpCodes.newarr, etype)
            End Sub
        End Class
        Public Class cpobj
            Inherits IL_MetadataToken
            Public Sub New(Token As MetadataToken)
                MyBase.New(OpCode.OpCodes.cpobj, Token)
            End Sub
        End Class
        Public Class isinst
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.isinst)
            End Sub
        End Class
        Public Class conv_r_un
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_r_un)
            End Sub
        End Class

        Public Class ldfld
            Inherits IL_MetadataToken
            Public Sub New(field As MetadataToken)
                MyBase.New(OpCode.OpCodes.ldfld, field)
            End Sub
        End Class
        Public Class ldflda
            Inherits IL_MetadataToken
            Public Sub New(field As MetadataToken)
                MyBase.New(OpCode.OpCodes.ldflda, field)
            End Sub
        End Class
        Public Class stfld
            Inherits IL_MetadataToken
            Public Sub New(field As MetadataToken)
                MyBase.New(OpCode.OpCodes.stfld, field)
            End Sub
        End Class
        Public Class stobj
            Inherits IL_MetadataToken
            Public Sub New(field As MetadataToken)
                MyBase.New(OpCode.OpCodes.stobj, field)
            End Sub
        End Class
        Public Class ldsfld
            Inherits IL_MetadataToken
            Public Sub New(field As MetadataToken)
                MyBase.New(OpCode.OpCodes.ldsfld, field)
            End Sub
        End Class
        Public Class ldsflda
            Inherits IL_MetadataToken
            Public Sub New(field As MetadataToken)
                MyBase.New(OpCode.OpCodes.ldsflda, field)
            End Sub
        End Class
        Public Class ldstr
            Inherits IL_MetadataToken
            Public Sub New([string] As MetadataToken)
                MyBase.New(OpCode.OpCodes.ldstr, [string])
            End Sub
        End Class
        Public Class stsfld
            Inherits IL_MetadataToken
            Public Sub New(field As MetadataToken)
                MyBase.New(OpCode.OpCodes.stsfld, field)
            End Sub
        End Class
        Public Class unbox
            Inherits IL_MetadataToken
            Public Sub New(valuetype As MetadataToken)
                MyBase.New(OpCode.OpCodes.stsfld, valuetype)
            End Sub
        End Class

        Public Class conv_ovf_i1_un
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_ovf_i1_un)
            End Sub
        End Class
        Public Class conv_ovf_i2_un
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_ovf_i2_un)
            End Sub
        End Class
        Public Class conv_ovf_i4_un
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_ovf_i4_un)
            End Sub
        End Class
        Public Class conv_ovf_i8_un
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_ovf_i8_un)
            End Sub
        End Class
        Public Class conv_ovf_u1_un
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_ovf_u1_un)
            End Sub
        End Class
        Public Class conv_ovf_u2_un
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_ovf_u2_un)
            End Sub
        End Class
        Public Class conv_ovf_u4_un
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_ovf_u4_un)
            End Sub
        End Class
        Public Class conv_ovf_u8_un
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_ovf_u8_un)
            End Sub
        End Class
        Public Class conv_ovf_i_un
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_ovf_i_un)
            End Sub
        End Class
        Public Class conv_ovf_u_un
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_ovf_u_un)
            End Sub
        End Class
        Public Class box
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.box)
            End Sub
        End Class

        Public Class ldlen
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldlen)
            End Sub
        End Class

        Public Class ldelem_i1
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldelem_i1)
            End Sub
        End Class
        Public Class ldelem_u1
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldelem_u1)
            End Sub
        End Class
        Public Class ldelem_i2
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldelem_i2)
            End Sub
        End Class
        Public Class ldelem_u2
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldelem_u2)
            End Sub
        End Class
        Public Class ldelem_i4
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldelem_i4)
            End Sub
        End Class
        Public Class ldelem_u4
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldelem_u4)
            End Sub
        End Class
        Public Class ldelem_i8
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldelem_i8)
            End Sub
        End Class
        Public Class ldelem_u8
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldelem_u8)
            End Sub
        End Class
        Public Class ldelem_i
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldelem_i)
            End Sub
        End Class
        Public Class ldelem_r4
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldelem_r4)
            End Sub
        End Class
        Public Class ldelem_r8
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldelem_r8)
            End Sub
        End Class
        Public Class ldelem_ref
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldelem_ref)
            End Sub
        End Class
        Public Class stelem_i
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.stelem_i)
            End Sub
        End Class
        Public Class stelem_i1
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.stelem_i1)
            End Sub
        End Class
        Public Class stelem_i2
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.stelem_i2)
            End Sub
        End Class
        Public Class stelem_i4
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.stelem_i4)
            End Sub
        End Class
        Public Class stelem_i8
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.stelem_i8)
            End Sub
        End Class
        Public Class stelem_r4
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.stelem_r4)
            End Sub
        End Class
        Public Class stelem_r8
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.stelem_r8)
            End Sub
        End Class

        Public Class ldelem
            Inherits IL_MetadataToken
            Public Sub New(typeTok As MetadataToken)
                MyBase.New(OpCode.OpCodes.ldelem, typeTok)
            End Sub
        End Class
        Public Class ldelema
            Inherits IL_MetadataToken
            Public Sub New(typeTok As MetadataToken)
                MyBase.New(OpCode.OpCodes.ldelema, typeTok)
            End Sub
        End Class

        Public Class ldtoken
            Inherits IL_MetadataToken
            Public Sub New(token As MetadataToken)
                MyBase.New(OpCode.OpCodes.ldtoken, token)
            End Sub
        End Class

        Public Class ldvirtftn
            Inherits IL_MetadataToken
            Public Sub New(method As MetadataToken)
                MyBase.New(OpCode.OpCodes.ldvirtftn, method)
            End Sub
        End Class

        Public Class unbox_any
            Inherits IL_MetadataToken
            Public Sub New(typeTok As MetadataToken)
                MyBase.New(OpCode.OpCodes.ldvirtftn, typeTok)
            End Sub
        End Class
        Public Class conv_ovf_i1
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_ovf_i1)
            End Sub
        End Class
        Public Class conv_ovf_u1
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_ovf_u1)
            End Sub
        End Class
        Public Class conv_ovf_i2
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_ovf_i2)
            End Sub
        End Class
        Public Class conv_ovf_u2
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_ovf_u2)
            End Sub
        End Class
        Public Class conv_ovf_i4
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_ovf_i4)
            End Sub
        End Class
        Public Class conv_ovf_u4
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_ovf_u4)
            End Sub
        End Class
        Public Class conv_ovf_i8
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_ovf_i8)
            End Sub
        End Class
        Public Class conv_ovf_u8
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_ovf_u8)
            End Sub
        End Class

        Public Class ckfinite
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.ckfinite)
            End Sub
        End Class

        Public Class Refanytype
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.refanytype_)
            End Sub
        End Class
        Public Class conv_u2
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_u2)
            End Sub
        End Class
        Public Class conv_u1
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_u1)
            End Sub
        End Class
        Public Class conv_i
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_i)
            End Sub
        End Class
        Public Class conv_u
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_u)
            End Sub
        End Class
        Public Class conv_ovf_i
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_ovf_i)
            End Sub
        End Class
        Public Class conv_ovf_u
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.conv_ovf_u)
            End Sub
        End Class
        Public Class add_ovf
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.add_ovf)
            End Sub
        End Class
        Public Class add_ovf_un
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.add_ovf_un)
            End Sub
        End Class
        Public Class mul_ovf
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.mul_ovf)
            End Sub
        End Class
        Public Class mul_ovf_un
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.mul_ovf_un)
            End Sub
        End Class
        Public Class sub_ovf
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.sub_ovf)
            End Sub
        End Class
        Public Class sub_ovf_un
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.sub_ovf_un)
            End Sub
        End Class
        Public Class ceq
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.ceq)
            End Sub
        End Class
        Public Class cgt
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.cgt)
            End Sub
        End Class
        Public Class cgt_un
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.cgt_un)
            End Sub
        End Class
        Public Class clt
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.clt)
            End Sub
        End Class
        Public Class clt_un
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.clt_un)
            End Sub
        End Class
        Public Class ldftn
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.ldftn)
            End Sub
        End Class


        Public Class ldc_i4_s
            Inherits IL.Value_UInt08
            Public Sub New(num As Byte)
                MyBase.New(OpCode.OpCodes.ldarg, num)
            End Sub
        End Class
        Public Class ldloc
            Inherits IL.Value_UInt16
            Public Sub New(num As UInt16)
                MyBase.New(OpCode.OpCodes.ldloc, num)
            End Sub
        End Class
        Public Class ldloc_s
            Inherits IL.Value_UInt08
            Public Sub New(num As Byte)
                MyBase.New(OpCode.OpCodes.ldloc_s, num)
            End Sub
        End Class
        Public Class ldarg
            Inherits IL.Value_UInt16
            Public Sub New(num As UInt16)
                MyBase.New(OpCode.OpCodes.ldarg, num)
            End Sub
        End Class
        Public Class ldarga
            Inherits IL.Value_UInt16
            Public Sub New(num As UInt16)
                MyBase.New(OpCode.OpCodes.ldarga, num)
            End Sub
        End Class
        Public Class leave
            Inherits IL.Value_Int32
            Public Sub New(num As Int32)
                MyBase.New(OpCode.OpCodes.leave, num)
            End Sub
        End Class
        Public Class leave_s
            Inherits IL.Value_Int08
            Public Sub New(num As SByte)
                MyBase.New(OpCode.OpCodes.leave_s, num)
            End Sub
        End Class
        Public Class starg
            Inherits Value_UInt16
            Public Sub New(num As UInt16)
                MyBase.New(OpCode.OpCodes.starg, num)
            End Sub
        End Class

        Public Class ldloca
            Inherits Value_UInt16
            Public Sub New(indx As UInt16)
                MyBase.New(OpCode.OpCodes.ldloca, indx)
            End Sub
        End Class
        Public Class stloc
            Inherits Value_UInt16
            Public Sub New(indx As UInt16)
                MyBase.New(OpCode.OpCodes.stloc, indx)
            End Sub
        End Class
        Public Class localloc
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.localloc)
            End Sub
        End Class
        Public Class endfilter
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.endfilter)
            End Sub
        End Class
        Public Class endfault
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.endfault)
            End Sub
        End Class
        Public Class endfinally
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.endfinally)
            End Sub
        End Class
        Public Class unaligned_
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.unaligned_)
            End Sub
        End Class
        Public Class volatile_
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.volatile_)
            End Sub
        End Class
        Public Class [throw]
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.throw)
            End Sub
        End Class
        Public Class tail_
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.tail_)
            End Sub
        End Class
        Public Class initobj
            Inherits IL_MetadataToken
            Public Sub New(typeTok As MetadataToken)
                MyBase.New(OpCode.OpCodes.initobj, typeTok)
            End Sub
        End Class
        Public Class initclass
            Inherits IL_MetadataToken
            Public Sub New([class] As MetadataToken)
                MyBase.New(OpCode.OpCodes.initobj, [class])
            End Sub
        End Class
        Public Class refanyval
            Inherits IL_MetadataToken
            Public Sub New([type] As MetadataToken)
                MyBase.New(OpCode.OpCodes.refanyval, [type])
            End Sub
        End Class
        Public Class constraied
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.constrained)
            End Sub
        End Class
        Public Class cpblk
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.cpblk)
            End Sub
        End Class
        Public Class initblk
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.initblk)
            End Sub
        End Class
        Public Class no_
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.no_)
            End Sub
        End Class
        Public Class rethrow
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.rethrow)
            End Sub
        End Class
        Public Class sizeof
            Inherits IL_MetadataToken
            Public Sub New(typeTok As MetadataToken)
                MyBase.New(OpCode.OpCodes.sizeof, typeTok)
            End Sub
        End Class
        Public Class stelem
            Inherits IL_MetadataToken
            Public Sub New(typeTok As MetadataToken)
                MyBase.New(OpCode.OpCodes.sizeof, typeTok)
            End Sub
        End Class
        Public Class refanytype_
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.refanytype_)
            End Sub
        End Class
        Public Class readonly_
            Inherits IL_Instruction
            Public Sub New()
                MyBase.New(OpCode.OpCodes.readonly_)
            End Sub
        End Class
        Public Class switch
            Inherits IL_Instruction
            Private ReadOnly Property Labels As New List(Of Int32)
            Sub New(n As UInt32, cases As List(Of Int32))
                MyBase.New(OpCode.OpCodes.switch)
                Labels.Capacity = n
                Labels.AddRange(cases)
            End Sub
            Public Overrides Function GetBytes() As IEnumerable(Of Byte)
                Dim b = Labels.SelectMany(Function(s As Int32) BitConverter.GetBytes(s))
                Dim n = BitConverter.GetBytes(CUInt(Labels.Count))


                Return MyBase.GetBytes().Concat(n).Concat(b).ToArray
            End Function
            Public Overrides Function Size() As Integer
                Return MyBase.Size() + (Label.Size * Labels.Count) + 4
            End Function
        End Class
    End Namespace
End Namespace
