Namespace Global.IL

    Partial Class OpCode

        Public Class OpCodes
            Public Shared ReadOnly _OpCodes As New List(Of OpCode)
            Shared Sub New()
                '            _OpCodes = New List(Of OpCode)(256) From {
                '            {&H00, "nop"}, {&H01, "break"}, {&H02, "ldarg.0"}, {&H03, "ldarg.1"},
                '            {&H04, "ldarg.2"}, {&H05, "ldarg.3"}, {&H06, "ldloc.0"}, {&H07, "ldloc.1"},
                '            {&H08, "ldloc.2"}, {&H09, "ldloc.3"}, {&H0A, "stloc.0"}, {&H0B, "stloc.1"},
                '            {&H0C, "stloc.2"}, {&H0D, "stloc.3"}, {&H0E, "ldarg.s"}, {&H0F, "ldarga.s"},
                '            {&H10, "starg.s"}, {&H11, "ldloc.s"}, {&H12, "ldloca.s"}, {&H13, "stloc.s"},
                '            {&H14, "ldnull"}, {&H15, "ldc.id.m1"}, {&H15, "ldc.i4.M1"}, {&H16, "ldc.i4.0"},
                '            {&H17, "ldc.i4.1"}, {&H18, "ldc.i4.2"}, {&H19, "ldc.i4.3"}, {&H1A, "ldc.i4.4"},
                '            {&H1B, "ldc.i4.5"}, {&H1C, "ldc.i4.6"}, {&H1D, "ldc.i4.7"}, {&H1E, "ldc.i4.8"},
                '            {&H1F, "ldc.i4.s"}, {&H20, "ldc.i4"}, {&H21, "ldc.i8"}, {&H22, "ldc.r4"},
                '            {&H23, "ldc.r8"}, {&H25, "dup"}, {&H26, "pop"}, {&H27, "jmp"},
                '            {&H28, "call"}, {&H29, "calli"}, {&H2A, "ret"}, {&H2B, "br.s"},
                '            {&H2C, "brfalse.s"}, {&H2C, "brnull.s"}, {&H2C, "brzero.s"}, {&H2D, "brinst.s"},
                '            {&H2D, "brtrue.s"}, {&H2E, "beq.s"}, {&H2F, "bge.s"}, {&H30, "bgt.s"},
                '            {&H31, "ble.s"}, {&H32, "blt.s"}, {&H33, "bne.un.s"}, {&H34, "bge.un.s"},
                '            {&H35, "bgt.un.s"}, {&H36, "ble.un.s"}, {&H37, "blt.un.s"}, {&H38, "br"},
                '            {&H39, "brfalse"}, {&H39, "brnull"}, {&H39, "brzero"}, {&H3A, "brinist"},
                '            {&H3B, "beq"}, {&H3C, "bge"}, {&H3D, "bgt"}, {&H3E, "ble"},
                '            {&H3F, "blt"}, {&H40, "bne.un"}, {&H41, "bge.un"}, {&H42, "bgt.un"},
                '            {&H43, "ble.un"}, {&H44, "blt.un"}, {&H45, "switch"}, {&H46, "ldind.i1"},
                '            {&H47, "ldind.u1"}, {&H48, "ldind.i2"}, {&H49, "ldind.u2"}, {&H4A, "ldind.i4"},
                '            {&H4B, "ldind.u4"}, {&H4C, "ldind.i8"}, {&H4C, "ldind.u8"}, {&H4D, "ldind.1"},
                '            {&H4E, "ldind.r4"}, {&H4F, "ldind.r8"}, {&H50, "ldind.ref"}, {&H51, "stind.ref"},
                '            {&H52, "stind.i1"}, {&H53, "stind.i2"}, {&H54, "stind.i4"}, {&H55, "stind.i8"},
                '            {&H56, "stind.r4"}, {&H57, "stind.r8"}, {&H58, "add"}, {&H59, "sub"},
                '            {&H5A, "mul"}, {&H5B, "div"}, {&H5C, "div.un"}, {&H5D, "rem"},
                '            {&H5E, "rem.un"}, {&H5F, "and"}, {&H60, "or"}, {&H61, "xor"},
                '            {&H62, "shl"}, {&H63, "shr"}, {&H64, "shr.un"}, {&H65, "neg"},
                '            {&H66, "not"}, {&H67, "conv.i1"}, {&H68, "conv.i2"}, {&H69, "conv.i4"},
                '            {&H6A, "conv.i8"}, {&H6B, "conv.r4"}, {&H6C, "conv.r8"}, {&H6D, "conv.u4"},
                '            {&H6E, "conv.u8"}, {&H6F, "callvirt"}, {&H70, "cpobj"}, {&H71, "ldobj"},
                '            {&H72, "lrstr"}, {&H73, "newobj"}, {&H74, "castclass"}, {&H75, "isinst"},
                '            {&H76, "conv.r.un"}, {&H79, "unbox"}, {&H7A, "throw"}, {&H7B, "ldfld"},
                '            {&H7C, "ldflda"}, {&H7D, "stfld"}, {&H7E, "ldsfld"}, {&H7F, "ldsflda"},
                '            {&H80, "stsfld"}, {&H81, "stobj"}, {&H82, "conv.ovf.i1.un"}, {&H83, "conv.ovf.i2.un"},
                '            {&H84, "conv.ovf.i4.un"}, {&H85, "conv.ovf.i8.un"}, {&H86, "conv.ovf.u1.un"}, {&H87, "conv.ovf.u2.un"},
                '            {&H88, "conv.ovf.u4.un"}, {&H89, "conv.ovf.u8.un"}, {&H8A, "conv.ovf.i.un"}, {&H8B, "conv.ovf.u.un"},
                '            {&H8C, "box"}, {&H8D, "newarr"}, {&H8E, "ldlen"}, {&H8F, "ldelema"},
                '            {&H90, "ldelem.i1"}, {&H91, "ldelem.u1"}, {&H92, "ldelem.i2"}, {&H93, "ldelem.u2"},
                '            {&H94, "ldelem.i4"}, {&H95, "ldelem.u4"}, {&H96, "ldelem.i8"}, {&H96, "ldelem.u8"},
                '            {&H97, "ldelem.i"}, {&H98, "ldelem.r4"}, {&H99, "ldelem.r8"}, {&H9A, "ldelem.ref"},
                '            {&H9B, "stelem.i"}, {&H9C, "stelem.i1"}, {&H9D, "stelem.i2"}, {&H9E, "stelem.i4"},
                '            {&H9F, "stelem.i8"}, {&HA0, "stelem.r4"}, {&HA1, "stelem.r8"}, {&HA2, "stelem.ref"},
                '            {&HA3, "ldelem"}, {&HA4, "stelem"}, {&HA5, "unbox.any"}, {&HB3, "conv.ovf.i1"},
                '            {&HB4, "conv.ovf.u1"}, {&HB5, "conv.ovf.i2"}, {&HB6, "conv.ovf.u2"}, {&HB7, "conv.ovf.i4"},
                '            {&HB8, "conv.ovf.u4"}, {&HB9, "conv.ovf.i8"}, {&HBA, "conv.ovf.u8"}, {&HC2, "refanyval"},
                '            {&HC3, "ckfinite"}, {&HD0, "cldtoken"}, {&HD1, "conv.u2"}, {&HD2, "conv.u1"},
                '            {&HD3, "conv.i"}, {&HD4, "conv.ovf.i"}, {&HD5, "conv.ovf.u"}, {&HD6, "add.ovf"},
                '            {&HD7, "add.ovf.un"}, {&HD8, "sub.ovf"}, {&HD9, "sub.ovf.un"}, {&HDA, "mul.ovf"},
                '            {&HDB, "mul.ovf.un"}, {&HDC, "endfault"}, {&HDC, "endfinally"}, {&HDD, "leave"},
                '            {&HDE, "leave.s"}, {&HDF, "stind.i"}, {&HE0, "conv.u"}, {&HFE, &H00, "arglist"},
                '            {&HFE, &H01, "ceq"}, {&HFE, &H02, "cgt"}, {&HFE, &H03, "cgt.un"}, {&HFE, &H04, "clt"},
                '            {&HFE, &H05, "clt.un"}, {&HFE, &H06, "ldftn"}, {&HFE, &H07, "ldvirtftn"}, {&HFE, &H09, "ldarg"},
                '            {&HFE, &H0A, "ldarga"}, {&HFE, &H0B, "starg"}, {&HFE, &H0C, "ldloc"}, {&HFE, &H0D, "ldloca"},
                '            {&HFE, &H0E, "stloc"}, {&HFE, &H0F, "localloc"}, {&HFE, &H11, "endfilter"}, {&HFE, &H12, "unaligned."},
                '            {&HFE, &H13, "volatile."}, {&HFE, &H14, "tail."}, {&HFE, &H15, "initobj"}, {&HFE, &H16, "constrained"},
                '            {&HFE, &H17, "cpblk"}, {&HFE, &H18, "initblk"}, {&HFE, &H19, "no."}, {&HFE, &H1A, "rethrow"},
                '            {&HFE, &H1C, "sizeof"}, {&HFE, &H1D, "refanytype."}, {&HFE, &H1E, "readonly."}
                '}
            End Sub


            Public Shared ReadOnly Property nop As OpCode = New OpCode(&H00, "nop")
            Public Shared ReadOnly Property break As OpCode = New OpCode(&H01, "break")
            Public Shared ReadOnly Property ldarg_0 As OpCode = New OpCode(&H02, "ldarg.0")
            Public Shared ReadOnly Property ldarg_1 As OpCode = New OpCode(&H03, "ldarg.1")
            Public Shared ReadOnly Property ldarg_2 As OpCode = New OpCode(&H04, "ldarg.2")
            Public Shared ReadOnly Property ldarg_3 As OpCode = New OpCode(&H05, "ldarg.3")
            Public Shared ReadOnly Property ldloc_0 As OpCode = New OpCode(&H06, "ldloc.0")
            Public Shared ReadOnly Property ldloc_1 As OpCode = New OpCode(&H07, "ldloc.1")
            Public Shared ReadOnly Property ldloc_2 As OpCode = New OpCode(&H08, "ldloc.2")
            Public Shared ReadOnly Property ldloc_3 As OpCode = New OpCode(&H09, "ldloc.3")
            Public Shared ReadOnly Property stloc_0 As OpCode = New OpCode(&H0A, "stloc.0")
            Public Shared ReadOnly Property stloc_1 As OpCode = New OpCode(&H0B, "stloc.1")
            Public Shared ReadOnly Property stloc_2 As OpCode = New OpCode(&H0C, "stloc.2")
            Public Shared ReadOnly Property stloc_3 As OpCode = New OpCode(&H0D, "stloc.3")
            Public Shared ReadOnly Property ldarg_s As OpCode = New OpCode(&H0E, "ldarg.s")
            Public Shared ReadOnly Property ldarga_s As OpCode = New OpCode(&H0F, "ldarga.s")
            Public Shared ReadOnly Property starg_s As OpCode = New OpCode(&H10, "starg.s")
            Public Shared ReadOnly Property ldloc_s As OpCode = New OpCode(&H11, "ldloc.s")
            Public Shared ReadOnly Property ldloca_s As OpCode = New OpCode(&H12, "ldloca.s")
            Public Shared ReadOnly Property stloc_s As OpCode = New OpCode(&H13, "stloc.s")
            Public Shared ReadOnly Property ldnull As OpCode = New OpCode(&H14, "ldnull")
            Public Shared ReadOnly Property ldc_id_m1 As OpCode = New OpCode(&H15, "ldc.id.m1")
            Public Shared ReadOnly Property ldc_i4_M1 As OpCode = New OpCode(&H15, "ldc.i4.M1")
            Public Shared ReadOnly Property ldc_i4_0 As OpCode = New OpCode(&H16, "ldc.i4.0")
            Public Shared ReadOnly Property ldc_i4_1 As OpCode = New OpCode(&H17, "ldc.i4.1")
            Public Shared ReadOnly Property ldc_i4_2 As OpCode = New OpCode(&H18, "ldc.i4.2")
            Public Shared ReadOnly Property ldc_i4_3 As OpCode = New OpCode(&H19, "ldc.i4.3")
            Public Shared ReadOnly Property ldc_i4_4 As OpCode = New OpCode(&H1A, "ldc.i4.4")
            Public Shared ReadOnly Property ldc_i4_5 As OpCode = New OpCode(&H1B, "ldc.i4.5")
            Public Shared ReadOnly Property ldc_i4_6 As OpCode = New OpCode(&H1C, "ldc.i4.6")
            Public Shared ReadOnly Property ldc_i4_7 As OpCode = New OpCode(&H1D, "ldc.i4.7")
            Public Shared ReadOnly Property ldc_i4_8 As OpCode = New OpCode(&H1E, "ldc.i4.8")
            Public Shared ReadOnly Property ldc_i4_s As OpCode = New OpCode(&H1F, "ldc.i4.s")
            Public Shared ReadOnly Property ldc_i4 As OpCode = New OpCode(&H20, "ldc.i4")
            Public Shared ReadOnly Property ldc_i8 As OpCode = New OpCode(&H21, "ldc.i8")
            Public Shared ReadOnly Property ldc_r4 As OpCode = New OpCode(&H22, "ldc.r4")
            Public Shared ReadOnly Property ldc_r8 As OpCode = New OpCode(&H23, "ldc.r8")
            Public Shared ReadOnly Property dup As OpCode = New OpCode(&H25, "dup")
            Public Shared ReadOnly Property pop As OpCode = New OpCode(&H26, "pop")
            Public Shared ReadOnly Property jmp As OpCode = New OpCode(&H27, "jmp")
            Public Shared ReadOnly Property [call] As OpCode = New OpCode(&H28, "call")
            Public Shared ReadOnly Property calli As OpCode = New OpCode(&H29, "calli")
            Public Shared ReadOnly Property ret As OpCode = New OpCode(&H2A, "ret")
            Public Shared ReadOnly Property br_s As OpCode = New OpCode(&H2B, "br.s")
            Public Shared ReadOnly Property brfalse_s As OpCode = New OpCode(&H2C, "brfalse.s")
            Public Shared ReadOnly Property brnull_s As OpCode = New OpCode(&H2C, "brnull.s")
            Public Shared ReadOnly Property brzero_s As OpCode = New OpCode(&H2C, "brzero.s")
            Public Shared ReadOnly Property brinst_s As OpCode = New OpCode(&H2D, "brinst.s")
            Public Shared ReadOnly Property brtrue_s As OpCode = New OpCode(&H2D, "brtrue.s")
            Public Shared ReadOnly Property beq_s As OpCode = New OpCode(&H2E, "beq.s")
            Public Shared ReadOnly Property bge_s As OpCode = New OpCode(&H2F, "bge.s")
            Public Shared ReadOnly Property bgt_s As OpCode = New OpCode(&H30, "bgt.s")
            Public Shared ReadOnly Property ble_s As OpCode = New OpCode(&H31, "ble.s")
            Public Shared ReadOnly Property blt_s As OpCode = New OpCode(&H32, "blt.s")
            Public Shared ReadOnly Property bne_un_s As OpCode = New OpCode(&H33, "bne.un.s")
            Public Shared ReadOnly Property bge_un_s As OpCode = New OpCode(&H34, "bge.un.s")
            Public Shared ReadOnly Property bgt_un_s As OpCode = New OpCode(&H35, "bgt.un.s")
            Public Shared ReadOnly Property ble_un_s As OpCode = New OpCode(&H36, "ble.un.s")
            Public Shared ReadOnly Property blt_un_s As OpCode = New OpCode(&H37, "blt.un.s")
            Public Shared ReadOnly Property br As OpCode = New OpCode(&H38, "br")
            Public Shared ReadOnly Property brfalse As OpCode = New OpCode(&H39, "brfalse")
            Public Shared ReadOnly Property brnull As OpCode = New OpCode(&H39, "brnull")
            Public Shared ReadOnly Property brzero As OpCode = New OpCode(&H39, "brzero")
            Public Shared ReadOnly Property brinist As OpCode = New OpCode(&H3A, "brinist")
            Public Shared ReadOnly Property brtrue As OpCode = New OpCode(&H3A, "brtrue")
            Public Shared ReadOnly Property beq As OpCode = New OpCode(&H3B, "beq")
            Public Shared ReadOnly Property bge As OpCode = New OpCode(&H3C, "bge")
            Public Shared ReadOnly Property bgt As OpCode = New OpCode(&H3D, "bgt")
            Public Shared ReadOnly Property ble As OpCode = New OpCode(&H3E, "ble")
            Public Shared ReadOnly Property blt As OpCode = New OpCode(&H3F, "blt")
            Public Shared ReadOnly Property bne_un As OpCode = New OpCode(&H40, "bne.un")
            Public Shared ReadOnly Property bge_un As OpCode = New OpCode(&H41, "bge.un")
            Public Shared ReadOnly Property bgt_un As OpCode = New OpCode(&H42, "bgt.un")
            Public Shared ReadOnly Property ble_un As OpCode = New OpCode(&H43, "ble.un")
            Public Shared ReadOnly Property blt_un As OpCode = New OpCode(&H44, "blt.un")
            Public Shared ReadOnly Property switch As OpCode = New OpCode(&H45, "switch")
            Public Shared ReadOnly Property ldind_i1 As OpCode = New OpCode(&H46, "ldind.i1")
            Public Shared ReadOnly Property ldind_u1 As OpCode = New OpCode(&H47, "ldind.u1")
            Public Shared ReadOnly Property ldind_i2 As OpCode = New OpCode(&H48, "ldind.i2")
            Public Shared ReadOnly Property ldind_u2 As OpCode = New OpCode(&H49, "ldind.u2")
            Public Shared ReadOnly Property ldind_i4 As OpCode = New OpCode(&H4A, "ldind.i4")
            Public Shared ReadOnly Property ldind_u4 As OpCode = New OpCode(&H4B, "ldind.u4")
            Public Shared ReadOnly Property ldind_i8 As OpCode = New OpCode(&H4C, "ldind.i8")
            Public Shared ReadOnly Property ldind_u8 As OpCode = New OpCode(&H4C, "ldind.u8")
            Public Shared ReadOnly Property ldind_i As OpCode = New OpCode(&H4D, "ldind.i")
            Public Shared ReadOnly Property ldind_r4 As OpCode = New OpCode(&H4E, "ldind.r4")
            Public Shared ReadOnly Property ldind_r8 As OpCode = New OpCode(&H4F, "ldind.r8")
            Public Shared ReadOnly Property ldind_ref As OpCode = New OpCode(&H50, "ldind.ref")
            Public Shared ReadOnly Property stind_ref As OpCode = New OpCode(&H51, "stind.ref")
            Public Shared ReadOnly Property stind_i1 As OpCode = New OpCode(&H52, "stind.i1")
            Public Shared ReadOnly Property stind_i2 As OpCode = New OpCode(&H53, "stind.i2")
            Public Shared ReadOnly Property stind_i4 As OpCode = New OpCode(&H54, "stind.i4")
            Public Shared ReadOnly Property stind_i8 As OpCode = New OpCode(&H55, "stind.i8")
            Public Shared ReadOnly Property stind_r4 As OpCode = New OpCode(&H56, "stind.r4")
            Public Shared ReadOnly Property stind_r8 As OpCode = New OpCode(&H57, "stind.r8")
            Public Shared ReadOnly Property add As OpCode = New OpCode(&H58, "add")
            Public Shared ReadOnly Property [sub] As OpCode = New OpCode(&H59, "sub")
            Public Shared ReadOnly Property mul As OpCode = New OpCode(&H5A, "mul")
            Public Shared ReadOnly Property div As OpCode = New OpCode(&H5B, "div")
            Public Shared ReadOnly Property div_un As OpCode = New OpCode(&H5C, "div.un")
            Public Shared ReadOnly Property [rem] As OpCode = New OpCode(&H5D, "rem")
            Public Shared ReadOnly Property rem_un As OpCode = New OpCode(&H5E, "rem.un")
            Public Shared ReadOnly Property [and] As OpCode = New OpCode(&H5F, "and")
            Public Shared ReadOnly Property [or] As OpCode = New OpCode(&H60, "or")
            Public Shared ReadOnly Property [xor] As OpCode = New OpCode(&H61, "xor")
            Public Shared ReadOnly Property shl As OpCode = New OpCode(&H62, "shl")
            Public Shared ReadOnly Property shr As OpCode = New OpCode(&H63, "shr")
            Public Shared ReadOnly Property shr_un As OpCode = New OpCode(&H64, "shr.un")
            Public Shared ReadOnly Property neg As OpCode = New OpCode(&H65, "neg")
            Public Shared ReadOnly Property [not] As OpCode = New OpCode(&H66, "not")
            Public Shared ReadOnly Property conv_i1 As OpCode = New OpCode(&H67, "conv.i1")
            Public Shared ReadOnly Property conv_i2 As OpCode = New OpCode(&H68, "conv.i2")
            Public Shared ReadOnly Property conv_i4 As OpCode = New OpCode(&H69, "conv.i4")
            Public Shared ReadOnly Property conv_i8 As OpCode = New OpCode(&H6A, "conv.i8")
            Public Shared ReadOnly Property conv_r4 As OpCode = New OpCode(&H6B, "conv.r4")
            Public Shared ReadOnly Property conv_r8 As OpCode = New OpCode(&H6C, "conv.r8")
            Public Shared ReadOnly Property conv_u4 As OpCode = New OpCode(&H6D, "conv.u4")
            Public Shared ReadOnly Property conv_u8 As OpCode = New OpCode(&H6E, "conv.u8")
            Public Shared ReadOnly Property callvirt As OpCode = New OpCode(&H6F, "callvirt")
            Public Shared ReadOnly Property cpobj As OpCode = New OpCode(&H70, "cpobj")
            Public Shared ReadOnly Property ldobj As OpCode = New OpCode(&H71, "ldobj")
            Public Shared ReadOnly Property lrstr As OpCode = New OpCode(&H72, "lrstr")
            Public Shared ReadOnly Property newobj As OpCode = New OpCode(&H73, "newobj")
            Public Shared ReadOnly Property castclass As OpCode = New OpCode(&H74, "castclass")
            Public Shared ReadOnly Property isinst As OpCode = New OpCode(&H75, "isinst")
            Public Shared ReadOnly Property conv_r_un As OpCode = New OpCode(&H76, "conv.r.un")
            Public Shared ReadOnly Property unbox As OpCode = New OpCode(&H79, "unbox")
            Public Shared ReadOnly Property [throw] As OpCode = New OpCode(&H7A, "throw")
            Public Shared ReadOnly Property ldfld As OpCode = New OpCode(&H7B, "ldfld")
            Public Shared ReadOnly Property ldflda As OpCode = New OpCode(&H7C, "ldflda")
            Public Shared ReadOnly Property stfld As OpCode = New OpCode(&H7D, "stfld")
            Public Shared ReadOnly Property ldsfld As OpCode = New OpCode(&H7E, "ldsfld")
            Public Shared ReadOnly Property ldsflda As OpCode = New OpCode(&H7F, "ldsflda")
            Public Shared ReadOnly Property stsfld As OpCode = New OpCode(&H80, "stsfld")
            Public Shared ReadOnly Property stobj As OpCode = New OpCode(&H81, "stobj")
            Public Shared ReadOnly Property conv_ovf_i1_un As OpCode = New OpCode(&H82, "conv.ovf.i1.un")
            Public Shared ReadOnly Property conv_ovf_i2_un As OpCode = New OpCode(&H83, "conv.ovf.i2.un")
            Public Shared ReadOnly Property conv_ovf_i4_un As OpCode = New OpCode(&H84, "conv.ovf.i4.un")
            Public Shared ReadOnly Property conv_ovf_i8_un As OpCode = New OpCode(&H85, "conv.ovf.i8.un")
            Public Shared ReadOnly Property conv_ovf_u1_un As OpCode = New OpCode(&H86, "conv.ovf.u1.un")
            Public Shared ReadOnly Property conv_ovf_u2_un As OpCode = New OpCode(&H87, "conv.ovf.u2.un")
            Public Shared ReadOnly Property conv_ovf_u4_un As OpCode = New OpCode(&H88, "conv.ovf.u4.un")
            Public Shared ReadOnly Property conv_ovf_u8_un As OpCode = New OpCode(&H89, "conv.ovf.u8.un")
            Public Shared ReadOnly Property conv_ovf_i_un As OpCode = New OpCode(&H8A, "conv.ovf.i.un")
            Public Shared ReadOnly Property conv_ovf_u_un As OpCode = New OpCode(&H8B, "conv.ovf.u.un")
            Public Shared ReadOnly Property box As OpCode = New OpCode(&H8C, "box")
            Public Shared ReadOnly Property newarr As OpCode = New OpCode(&H8D, "newarr")
            Public Shared ReadOnly Property ldlen As OpCode = New OpCode(&H8E, "ldlen")
            Public Shared ReadOnly Property ldelema As OpCode = New OpCode(&H8F, "ldelema")
            Public Shared ReadOnly Property ldelem_i1 As OpCode = New OpCode(&H90, "ldelem.i1")
            Public Shared ReadOnly Property ldelem_u1 As OpCode = New OpCode(&H91, "ldelem.u1")
            Public Shared ReadOnly Property ldelem_i2 As OpCode = New OpCode(&H92, "ldelem.i2")
            Public Shared ReadOnly Property ldelem_u2 As OpCode = New OpCode(&H93, "ldelem.u2")
            Public Shared ReadOnly Property ldelem_i4 As OpCode = New OpCode(&H94, "ldelem.i4")
            Public Shared ReadOnly Property ldelem_u4 As OpCode = New OpCode(&H95, "ldelem.u4")
            Public Shared ReadOnly Property ldelem_i8 As OpCode = New OpCode(&H96, "ldelem.i8")
            Public Shared ReadOnly Property ldelem_u8 As OpCode = New OpCode(&H96, "ldelem.u8")
            Public Shared ReadOnly Property ldelem_i As OpCode = New OpCode(&H97, "ldelem.i")

            Public Shared ReadOnly Property ldelem_r4 As OpCode = New OpCode(&H98, "ldelem.r4")
            Public Shared ReadOnly Property ldelem_r8 As OpCode = New OpCode(&H99, "ldelem.r8")
            Public Shared ReadOnly Property ldelem_ref As OpCode = New OpCode(&H9A, "ldelem.ref")
            Public Shared ReadOnly Property stelem_i As OpCode = New OpCode(&H9B, "stelem.i")
            Public Shared ReadOnly Property stelem_i1 As OpCode = New OpCode(&H9C, "stelem.i1")
            Public Shared ReadOnly Property stelem_i2 As OpCode = New OpCode(&H9D, "stelem.i2")
            Public Shared ReadOnly Property stelem_i4 As OpCode = New OpCode(&H9E, "stelem.i4")
            Public Shared ReadOnly Property stelem_i8 As OpCode = New OpCode(&H9F, "stelem.i8")
            Public Shared ReadOnly Property stelem_r4 As OpCode = New OpCode(&HA0, "stelem.r4")
            Public Shared ReadOnly Property stelem_r8 As OpCode = New OpCode(&HA1, "stelem.r8")
            Public Shared ReadOnly Property stelem_ref As OpCode = New OpCode(&HA2, "stelem.ref")
            Public Shared ReadOnly Property ldelem As OpCode = New OpCode(&HA3, "ldelem")
            Public Shared ReadOnly Property stelem As OpCode = New OpCode(&HA4, "stelem")
            Public Shared ReadOnly Property unbox_any As OpCode = New OpCode(&HA5, "unbox.any")
            Public Shared ReadOnly Property conv_ovf_i1 As OpCode = New OpCode(&HB3, "conv.ovf.i1")
            Public Shared ReadOnly Property conv_ovf_u1 As OpCode = New OpCode(&HB4, "conv.ovf.u1")
            Public Shared ReadOnly Property conv_ovf_i2 As OpCode = New OpCode(&HB5, "conv.ovf.i2")
            Public Shared ReadOnly Property conv_ovf_u2 As OpCode = New OpCode(&HB6, "conv.ovf.u2")
            Public Shared ReadOnly Property conv_ovf_i4 As OpCode = New OpCode(&HB7, "conv.ovf.i4")
            Public Shared ReadOnly Property conv_ovf_u4 As OpCode = New OpCode(&HB8, "conv.ovf.u4")
            Public Shared ReadOnly Property conv_ovf_i8 As OpCode = New OpCode(&HB9, "conv.ovf.i8")
            Public Shared ReadOnly Property conv_ovf_u8 As OpCode = New OpCode(&HBA, "conv.ovf.u8")
            Public Shared ReadOnly Property refanyval As OpCode = New OpCode(&HC2, "refanyval")
            Public Shared ReadOnly Property ckfinite As OpCode = New OpCode(&HC3, "ckfinite")
            Public Shared ReadOnly Property cldtoken As OpCode = New OpCode(&HD0, "cldtoken")
            Public Shared ReadOnly Property conv_u2 As OpCode = New OpCode(&HD1, "conv.u2")
            Public Shared ReadOnly Property conv_u1 As OpCode = New OpCode(&HD2, "conv.u1")
            Public Shared ReadOnly Property conv_i As OpCode = New OpCode(&HD3, "conv.i")
            Public Shared ReadOnly Property conv_ovf_i As OpCode = New OpCode(&HD4, "conv.ovf.i")
            Public Shared ReadOnly Property conv_ovf_u As OpCode = New OpCode(&HD5, "conv.ovf.u")
            Public Shared ReadOnly Property add_ovf As OpCode = New OpCode(&HD6, "add.ovf")
            Public Shared ReadOnly Property add_ovf_un As OpCode = New OpCode(&HD7, "add.ovf.un")
            Public Shared ReadOnly Property sub_ovf As OpCode = New OpCode(&HD8, "sub.ovf")
            Public Shared ReadOnly Property sub_ovf_un As OpCode = New OpCode(&HD9, "sub.ovf.un")
            Public Shared ReadOnly Property mul_ovf As OpCode = New OpCode(&HDA, "mul.ovf")
            Public Shared ReadOnly Property mul_ovf_un As OpCode = New OpCode(&HDB, "mul.ovf.un")
            Public Shared ReadOnly Property endfault As OpCode = New OpCode(&HDC, "endfault")
            Public Shared ReadOnly Property endfinally As OpCode = New OpCode(&HDC, "endfinally")
            Public Shared ReadOnly Property leave As OpCode = New OpCode(&HDD, "leave")
            Public Shared ReadOnly Property leave_s As OpCode = New OpCode(&HDE, "leave.s")
            Public Shared ReadOnly Property stind_i As OpCode = New OpCode(&HDF, "stind.i")
            Public Shared ReadOnly Property conv_u As OpCode = New OpCode(&HE0, "conv.u")
            Public Shared ReadOnly Property arglist As OpCode = New OpCode(&HFE, &H00, "arglist")
            Public Shared ReadOnly Property ceq As OpCode = New OpCode(&HFE, &H01, "ceq")
            Public Shared ReadOnly Property cgt As OpCode = New OpCode(&HFE, &H02, "cgt")
            Public Shared ReadOnly Property cgt_un As OpCode = New OpCode(&HFE, &H03, "cgt.un")
            Public Shared ReadOnly Property clt As OpCode = New OpCode(&HFE, &H04, "clt")
            Public Shared ReadOnly Property clt_un As OpCode = New OpCode(&HFE, &H05, "clt.un")
            Public Shared ReadOnly Property ldftn As OpCode = New OpCode(&HFE, &H06, "ldftn")
            Public Shared ReadOnly Property ldvirtftn As OpCode = New OpCode(&HFE, &H07, "ldvirtftn")
            Public Shared ReadOnly Property ldarg As OpCode = New OpCode(&HFE, &H09, "ldarg")
            Public Shared ReadOnly Property ldarga As OpCode = New OpCode(&HFE, &H0A, "ldarga")
            Public Shared ReadOnly Property starg As OpCode = New OpCode(&HFE, &H0B, "starg")
            Public Shared ReadOnly Property ldloc As OpCode = New OpCode(&HFE, &H0C, "ldloc")
            Public Shared ReadOnly Property ldloca As OpCode = New OpCode(&HFE, &H0D, "ldloca")
            Public Shared ReadOnly Property stloc As OpCode = New OpCode(&HFE, &H0E, "stloc")
            Public Shared ReadOnly Property localloc As OpCode = New OpCode(&HFE, &H0F, "localloc")
            Public Shared ReadOnly Property endfilter As OpCode = New OpCode(&HFE, &H11, "endfilter")
            Public Shared ReadOnly Property unaligned_ As OpCode = New OpCode(&HFE, &H12, "unaligned.")
            Public Shared ReadOnly Property volatile_ As OpCode = New OpCode(&HFE, &H13, "volatile.")
            Public Shared ReadOnly Property tail_ As OpCode = New OpCode(&HFE, &H14, "tail.")
            Public Shared ReadOnly Property initobj As OpCode = New OpCode(&HFE, &H15, "initobj")
            Public Shared ReadOnly Property constrained As OpCode = New OpCode(&HFE, &H16, "constrained")
            Public Shared ReadOnly Property cpblk As OpCode = New OpCode(&HFE, &H17, "cpblk")
            Public Shared ReadOnly Property initblk As OpCode = New OpCode(&HFE, &H18, "initblk")
            Public Shared ReadOnly Property no_ As OpCode = New OpCode(&HFE, &H19, "no.")
            Public Shared ReadOnly Property rethrow As OpCode = New OpCode(&HFE, &H1A, "rethrow")
            Public Shared ReadOnly Property sizeof As OpCode = New OpCode(&HFE, &H1C, "sizeof")
            Public Shared ReadOnly Property refanytype_ As OpCode = New OpCode(&HFE, &H1D, "refanytype.")
            Public Shared ReadOnly Property readonly_ As OpCode = New OpCode(&HFE, &H1E, "readonly.")


        End Class

    End Class

End Namespace

