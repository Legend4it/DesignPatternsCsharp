Console.WriteLine("Enter Type:");

var input = Console.ReadLine();
input=char.ToUpper(input![0]) +input.Substring(1);

switch (input)
{
    case "Pdf":
        Console.WriteLine($"Type is: {input}");
        break;
    case "File":
        Console.WriteLine($"Type is: {input}");
        break;
    case "Console":
        Console.WriteLine($"Type is: {input}");
        break;
    default:
        break;
}

Console.ReadLine();
