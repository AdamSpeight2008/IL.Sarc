Module Module1

    Sub Main()
        Dim prog As New IL.ILCode
        prog.Add(IL.Sarc.Asm.ldloc_0)
        prog.Add(IL.Sarc.Asm.ldloc_1)
        prog.Add(IL.Sarc.Asm.add)
        prog.Add(IL.Sarc.Asm.stloc_0)
        Console.WriteLine(prog.GetSize)
        For Each b In prog.GetBytes
            Console.Write($"{b,3:X2}")
        Next
        Console.WriteLine()
        Dim ln = 0
        For Each l In prog.Asm
            Console.WriteLine($"{ln:x4}  {l}")
            ln += 1
        Next
    End Sub

End Module


Namespace Global.IL


    Public MustInherit Class IL_Node

    End Class




    Public Class Label
        Public Shared ReadOnly Property Size As Integer = 4
    End Class



End Namespace