
    WriteLine(
        "-----------------------------------------------------------------------------------------------------------------------------");
    WriteLine("{0,-20} {1,4} {2,20} {3,20}", "Type", "Byte(s) of Memory", "Min", "Max");
    WriteLine(
        "-----------------------------------------------------------------------------------------------------------------------------");
    WriteLine(format: "{0,-20} {1,4} {2,20} {3,20}", "sbyte", $"{sizeof(sbyte)}", $"{sbyte.MinValue:N0}",
        $"{sbyte.MaxValue:N0}");
    WriteLine(format: "{0,-20} {1,4} {2,20} {3,20}", "byte", $"{sizeof(byte)}", $"{byte.MinValue:N0}",
        $"{byte.MaxValue:N0}");
    WriteLine(format: "{0,-20} {1,4} {2,20} {3,20}", "short", $"{sizeof(short)}", $"{short.MinValue:N0}",
        $"{short.MaxValue:N0}");
    WriteLine(format: "{0,-20} {1,4} {2,20} {3,20}", "ushort", $"{sizeof(ushort)}", $"{ushort.MinValue:N0}",
        $"{ushort.MaxValue:N0}");
    WriteLine(format: "{0,-20} {1,4} {2,20} {3,20}", "int", $"{sizeof(int)}", $"{int.MinValue:N0}",
        $"{int.MaxValue:N0}");
    WriteLine(format: "{0,-20} {1,4} {2,20} {3,20}", "uint", $"{sizeof(uint)}", $"{uint.MinValue:N0}",
        $"{uint.MaxValue:N0}");
    WriteLine(format: "{0,-20} {1,4} {2,20} {3,20}", "long", $"{sizeof(long)}", $"{long.MinValue:N0}",
        $"{long.MaxValue:N0}");
    WriteLine(format: "{0,-20} {1,4} {2,20} {3,20}", "ulong", $"{sizeof(ulong)}", $"{ulong.MinValue:N0}",
        $"{ulong.MaxValue:N0}");
   // WriteLine(format: "{0,-20} {1,4} {2,20} {3,20}", "Half", $"{sizeof(Half)}", $"{Half.MinValue:N0}",  $"{Half.MaxValue:N0}");
   // WriteLine(format: "{0,-20} {1,4} {2,20} {3,20}", "Int128", $"{sizeof(Int128)}", $"{Int128.MinValue:N0}",$"{Int128.MaxValue:N0}");
   // WriteLine(format: "{0,-20} {1,4} {2,20} {3,20}", "UIint128", $"{sizeof(UInt128)}", $"{UInt128.MinValue:N0}",$"{UInt128.MaxValue:N0}");
    WriteLine(format: "{0,-20} {1,4} {2,20} {3,20}", "double", $"{sizeof(double)}", $"{double.MinValue:N0}",
        $"{double.MaxValue:N0}");
    WriteLine(format: "{0,-20} {1,4} {2,20} {3,20}", "decimal", $"{sizeof(decimal)}", $"{decimal.MinValue:N0}",
        $"{decimal.MaxValue:N0}");



