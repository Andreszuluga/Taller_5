using DoubleList;

var list = new DoubleLinkedList<string>();
var option = string.Empty;
var value = string.Empty;

do
{
    option = Menu();
    switch (option)
    {
        case "1":
            Console.Write("Enter value: ");
            value = Console.ReadLine() ?? string.Empty;
            list.Add(value);
            break;
        case "2":
            Console.WriteLine(list.ToString());
            break;
        case "3":
            Console.WriteLine(list.ToStringReverse());
            break;
        case "4":
            list.SortDescending();
            Console.WriteLine("List sorted in descending order.");
            break;
        case "5":
            Console.WriteLine($"The mode(s) are: {list.ShowModes()}");
            break;
        case "6":
            Console.WriteLine(list.ShowGraphic());
            break;
        case "7":
            Console.Write("Enter value: ");
            value = Console.ReadLine() ?? string.Empty;
            Console.WriteLine(list.Exists(value) ? "¡Exists!" : "¡Doesn't exist!");
            break;
        case "8":
            Console.Write("Enter value: ");
            value = Console.ReadLine() ?? string.Empty;
            list.RemoveOccurrence(value);
            Console.WriteLine($"Removed one occurrence of {value}.");
            break;
        case "9":
            Console.Write("Enter value: ");
            value = Console.ReadLine() ?? string.Empty;
            int removed = list.RemoveAllOccurrences(value);
            break;
        case "0":
            Console.WriteLine("Exiting...");
            break;
        default:
            Console.WriteLine("Invalid option. Try again.");
            break;
    }
} while (option != "0");

string Menu()
{
    Console.WriteLine("1. Add. ");
    Console.WriteLine("2. Show list forward. ");
    Console.WriteLine("3. Show list backward. ");
    Console.WriteLine("4. Sort descending. ");
    Console.WriteLine("5. Show modes. ");
    Console.WriteLine("6. Show graphic.");
    Console.WriteLine("7. Exists. ");
    Console.WriteLine("8. Remove an occurrence. ");
    Console.WriteLine("9. Remove all occurrences. ");
    Console.WriteLine("0. Exit. ");
    Console.Write("Enter your option: ");
    return Console.ReadLine() ?? string.Empty;
}
