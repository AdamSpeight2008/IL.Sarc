Module Module1

    Sub Main()
        Dim prog As New IL.ILCode
        prog.Add(IL.Sarc.Asm.ldloc_0)
        prog.Add(IL.Sarc.Asm.ldloc_1)
        prog.Add(IL.Sarc.Asm.add)
        prog.Add(IL.Sarc.Asm.stloc_0)
        prog.Add(IL.Sarc.Asm.break)
        prog.Add(IL.Sarc.Asm.rethrow)
        prog.Add(IL.Sarc.Asm.switch(CUInt(3), New List(Of Integer)({1, 2, 3})))
        Console.WriteLine(prog.GetSize)
        For Each b In prog.GetBytes
            Console.Write($"{b,3:X2}")
        Next
        Console.WriteLine()
        Dim ln = 0
        For Each l In prog.Asm
            Dim bytecode = String.Join(Of String)(" ", l.GetBytes.Select(Function(b) $"{b:x2}"))
            Console.Write($"{ln:x4}:  ")
            Console.ForegroundColor = ConsoleColor.Blue
            Console.BackgroundColor = ConsoleColor.White
            Console.Write($"{bytecode,-16}")
            Console.BackgroundColor = ConsoleColor.Black

            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine($"  {l}")
            ln += 1
        Next

        Console.WriteLine()
        Console.WriteLine()

        Dim bs As New ByteSource(prog.GetBytes)
        Dim dc As New ByteCode_Decoder()
        Dim res = dc.Decode(bs.GetReader)
        For Each l In res.Asm
            Dim bytecode = String.Join(Of String)(" ", l.GetBytes.Select(Function(b) $"{b:x2}"))
            Console.Write($"{ln:x4}:  ")
            Console.ForegroundColor = ConsoleColor.Blue
            Console.BackgroundColor = ConsoleColor.White
            Console.Write($"{bytecode,-16}")
            Console.BackgroundColor = ConsoleColor.Black

            Console.ForegroundColor = ConsoleColor.White
            Console.WriteLine($"  {l}")
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