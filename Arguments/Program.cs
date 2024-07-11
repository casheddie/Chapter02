using System.ComponentModel.DataAnnotations;

WriteLine($"There are {args.Length} arguments.");
foreach (string arg in args)
{
    WriteLine(arg);
}

if (args.Length < 3)
{
    WriteLine("You must specify two coloros");
    WriteLine("dotnet run red yellow 50");
    return; // Stop Running
}

ForegroundColor = (ConsoleColor)Enum.Parse(enumType: typeof(ConsoleColor),
    value: args[1], ignoreCase: true);
try
{
    CursorSize = int.Parse(args[2]);
}
catch (PlatformNotSupportedException)
{
    WriteLine("The current platform does not support changing the size of the cursor.");
 
}

    
