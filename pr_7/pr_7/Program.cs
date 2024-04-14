Console.WriteLine( "Введите число: ");
String babo = Console.ReadLine();
char[] bebr = babo.ToCharArray();
Array.Reverse(bebr);
Console.WriteLine("Строка задом наперед: ");
Console.WriteLine(bebr);