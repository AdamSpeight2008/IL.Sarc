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

            Public ReadOnly Property ret As New Instructions.ret()

            Public ReadOnly Property add As New Instructions.add()
            Public ReadOnly Property [sub] As New Instructions.sub()
            Public ReadOnly Property mul As New Instructions.mul()
            Public ReadOnly Property div As New Instructions.div()
            Public ReadOnly Property div_u As New Instructions.div_un()

            Public ReadOnly Property [rem] As New Instructions.[rem]()
            Public ReadOnly Property rem_un As New Instructions.rem_un()
            Public ReadOnly Property [or] As New Instructions.[or]()
            Public ReadOnly Property [xor] As New Instructions.[xor]()
            Public ReadOnly Property [and] As New Instructions.[and]()
            Public ReadOnly Property [not] As New Instructions.[not]()

            Public ReadOnly Property neg As New Instructions.neg()

            Public ReadOnly Property pop As New Instructions.pop()
            Public ReadOnly Property dup As New Instructions.dup()


        End Module
    End Namespace

    Namespace Instructions
            Public Class nop
                Inherits IL_Instruction

            Protected Friend Sub New()
                MyBase.New(OpCode.OpCodes.nop)
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
                Inherits IL_Instruction

            Protected Friend Sub New()
                MyBase.New(OpCode.OpCodes.ldarg_s)
            End Sub

        End Class
            Public Class ldarga_s
                Inherits IL_Instruction

            Protected Friend Sub New()
                MyBase.New(OpCode.OpCodes.ldarga_s)
            End Sub

        End Class

            Public Class starg_s
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.starg_s)
                End Sub

            End Class

            Public Class ldloc_s
                Inherits IL_Instruction

            Protected Friend Sub New()
                MyBase.New(OpCode.OpCodes.ldloc_s)
            End Sub

        End Class
            Public Class ldloca_s
                Inherits IL_Instruction

            Protected Friend Sub New()
                MyBase.New(OpCode.OpCodes.ldloca_s)
            End Sub

        End Class
            Public Class stloc_s
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.stloc_s)
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
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.ldc_i4)
                End Sub

            End Class
            Public Class ldc_i8
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.ldc_i8)
                End Sub

            End Class
            Public Class ldc_r4
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.ldc_r4)
                End Sub

            End Class
            Public Class ldc_r8
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.ldc_r8)
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
            Public Class jmp
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.jmp)
                End Sub

            End Class
            Public Class [call]
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.call)
                End Sub

            End Class
            Public Class calli
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.calli)
                End Sub

            End Class
            Public Class ret
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.ret)
                End Sub

            End Class
            Public Class br_s
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.br_s)
                End Sub

            End Class
            Public Class brfalse_s
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.brfalse_s)
                End Sub

            End Class
            Public Class brnull_s
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.brnull_s)
                End Sub

            End Class
            Public Class brzero_s
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.brzero_s)
                End Sub

            End Class
            Public Class brinst_s
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.brinst_s)
                End Sub

            End Class
            Public Class brtrue_s
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.brtrue_s)
                End Sub

            End Class
            Public Class beq_s
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.beq_s)
                End Sub

            End Class
            Public Class bge_s
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.bge_s)
                End Sub

            End Class
            Public Class bgt_s
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.bgt_s)
                End Sub

            End Class
            Public Class ble_s
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.ble_s)
                End Sub

            End Class

            Public Class blt_s
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.blt_s)
                End Sub

            End Class
            Public Class bne_un_s
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.bne_un_s)
                End Sub

            End Class
            Public Class bge_un_s
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.bge_un_s)
                End Sub

            End Class
            Public Class bgt_un_s
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.bgt_un_s)
                End Sub

            End Class
            Public Class ble_un_s
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.ble_un_s)
                End Sub

            End Class
            Public Class blt_un_s
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.blt_un_s)
                End Sub

            End Class
            Public Class br
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.br)
                End Sub

            End Class

            Public Class brfalse
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.brfalse)
                End Sub

            End Class

            Public Class brnull
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.brnull)
                End Sub

            End Class
            Public Class brzero
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.brzero)
                End Sub

            End Class
            Public Class brinist
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.brinist)
                End Sub

            End Class
            Public Class beq
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.beq)
                End Sub

            End Class
            Public Class bge
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.bge)
                End Sub

            End Class
            Public Class bgt
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.bgt)
                End Sub

            End Class
            Public Class ble
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.ble)
                End Sub

            End Class
            Public Class blt
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.blt)
                End Sub

            End Class

            Public Class bne_un
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.bne_un)
                End Sub

            End Class
            Public Class bge_un
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.bge_un)
                End Sub

            End Class
            Public Class bgt_un
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.bgt_un)
                End Sub

            End Class

            Public Class ble_un
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.ble_un)
                End Sub

            End Class
            Public Class blt_un
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.blt_un)
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
            Public Class ldind_1
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.ldind_1)
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
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.callvirt)
                End Sub

            End Class
            Public Class cpobj
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.cpobj)
                End Sub

            End Class
            Public Class ldobj
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.ldobj)
                End Sub

            End Class
            Public Class lrstr
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.lrstr)
                End Sub

            End Class
            Public Class newpobj
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.newobj)
                End Sub

            End Class
            Public Class castclass
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.castclass)
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
            Public Class unbox
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.unbox)
                End Sub

            End Class

            Public Class ldfld
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.ldfld)
                End Sub

            End Class
            Public Class ldflda
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.ldflda)
                End Sub

            End Class
            Public Class stfld
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.stfld)
                End Sub

            End Class
            Public Class ldsfld
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.ldsfld)
                End Sub

            End Class
            Public Class ldsflda
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.ldsflda)
                End Sub

            End Class
            Public Class stsfld
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.stsfld)
                End Sub

            End Class
            Public Class stobj
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.stobj)
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

            Public Class newarr
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.newarr)
                End Sub

            End Class

            Public Class ldlen
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.ldlen)
                End Sub

            End Class
            Public Class ldelema
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.ldelema)
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


            Public Class stelem
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.stelem)
                End Sub

            End Class
            Public Class ldelem
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.ldelem)
                End Sub

            End Class

            Public Class unbox_any
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.unbox_any)
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

            Public Class refanyval
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.refanyval)
                End Sub

            End Class
            Public Class ckfinite
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.ckfinite)
                End Sub

            End Class

            Public Class cldtoken
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.cldtoken)
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
            Public Class ldvirtftn
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.ldvirtftn)
                End Sub

            End Class
            Public Class ldarg
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.ldarg)
                End Sub

            End Class

            Public Class ldarga
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.ldarga)
                End Sub

            End Class

            Public Class starg
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.starg)
                End Sub

            End Class


            Public Class ldloc
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.ldloc)
                End Sub

            End Class

            Public Class ldloca
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.ldloca)
                End Sub

            End Class
            Public Class stloc
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.stloc)
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
            Public Class tail_
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.tail_)
                End Sub

            End Class

            Public Class initobj
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.initobj)
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

            Public Class initlk
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
                Inherits IL_Instruction

                Public Sub New()
                    MyBase.New(OpCode.OpCodes.sizeof)
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



        Public Class Switch
                Inherits IL_Instruction
                Private ReadOnly Property Labels As New List(Of Label)

                Sub New()
                    MyBase.New(OpCode.OpCodes.switch)
                End Sub
                Public Overrides Function Size() As Integer
                    Return MyBase.Size() + (Label.Size * Labels.Count) + 4
                End Function
            End Class
        End Namespace
    End Namespace
