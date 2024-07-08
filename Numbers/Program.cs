// An unassigned integer is a positive whole number or 0.
uint naturalNumber = 23;
// An integer is a negative or positive whole number or 0.
int integerNumber = -23;
float realNumber = 2.3f;
double anotheRealNumber = 2.3;

Console.WriteLine(integerNumber);
Console.WriteLine(realNumber);
Console.WriteLine(anotheRealNumber);
Console.WriteLine(naturalNumber);
Console.WriteLine();

int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;
Console.WriteLine($"{decimalNotation == binaryNotation}");
Console.WriteLine($"{decimalNotation == hexadecimalNotation}");
Console.WriteLine(($"{decimalNotation:N0}"));
Console.WriteLine($"{binaryNotation:N0}");
Console.WriteLine($"{hexadecimalNotation:N0}");
//output the variable value in hexidecimal.
Console.WriteLine($"{decimalNotation:X}");
Console.WriteLine($"{binaryNotation:X}");
Console.WriteLine($"{hexadecimalNotation:X}");

Console.WriteLine();

Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers in the range {int.MinValue:N0} to {int.MaxValue} ");
Console.WriteLine(($"double uses {sizeof(double)} bytes and can store numbers in the range {double.MaxValue:N0} to {double.MaxValue}"));
Console.WriteLine($"decimal uses {sizeof(int)} bytes and can store numbers {decimal.MinValue:N0} to {decimal.MaxValue:N0}");

Console.WriteLine("Using doubles:");
double a = 0.1;
double b = 0.2;

if (a + b == 0.3)
{
    Console.WriteLine($"{a} + {b} equals {0.3}");
}
else
{
    Console.WriteLine($"{a} + {b} does NOT equal {0.3}");
}

Console.WriteLine("Using decimals:");
decimal c = 0.1M;
decimal d = 0.2M;

if (c + d == 0.3M)
{
    Console.WriteLine($"{c} + {d} equals {0.3M}");
}
else
{
    Console.WriteLine($"{c} + {d} does NOT equal {0.3M}");
}

unsafe
{
    Console.WriteLine($"Half uses {sizeof(Half)} bytes and can store numbers in the range {Half.MinValue:N0} to {Half.MaxValue:N0}");
    Console.WriteLine($"Int128 uses {sizeof(Int128)} bytes and can store numbers in the range {Int128.MinValue:N0} to {Int128.MaxValue:N0}");
}