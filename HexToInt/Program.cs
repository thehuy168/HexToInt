// See https://aka.ms/new-console-template for more information
Console.WriteLine("input Hexadeximon");
string? hexval = Console.ReadLine();
if (hexval == null)
{
    hexval = "0";
}
try
{
    Console.WriteLine("Hexadecimal number: " + hexval);
    int decValue = int.Parse(hexval, System.Globalization.NumberStyles.HexNumber);
    Console.WriteLine("Convert to-");
    Console.WriteLine("Decimal number: " + decValue);
}
catch
{
    Console.WriteLine($"{hexval}" + "  is not hexadeximon format");

}
