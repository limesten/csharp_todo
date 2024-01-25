public class Program
{
    List<string> items = new List<string>();

    public void AddItem()
    {
        Console.WriteLine("Enter your todo item below:");
        var item = Console.ReadLine();
        if (string.IsNullOrEmpty(item))
        {
            Console.WriteLine("the item can not be empty, try again");
            return;
        }
        items.Add(item);
    }
    public void ViewItems()
    {
        for (var i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {items[i]}");
        }
    }

    public void EditItem()
    {
        Console.WriteLine("Enter the number of the item you want to edit:");
        for (var i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {items[i]}");
        }
        var choice = Console.ReadLine();
        if (string.IsNullOrEmpty(choice))
        {
            Console.WriteLine("Please enter a choice and try again.");
            return;
        }
        int index = int.Parse(choice) - 1;
        Console.WriteLine("Enter edited todo:");
        var newItem = Console.ReadLine();
        if (string.IsNullOrEmpty(newItem))
        {
            Console.WriteLine("the item can not be empty, try again");
            return;
        }
        items[index] = newItem;
    }

    public void DeleteItem()
    {
        Console.WriteLine("Enter the number of the item you want to delete:");
        for (var i = 0; i < items.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {items[i]}");
        }
        var choice = Console.ReadLine();
        if (string.IsNullOrEmpty(choice))
        {
            Console.WriteLine("Please enter a choice and try again.");
            return;
        }
        int index = int.Parse(choice) - 1;
        items.RemoveAt(index);
    }
    public static void Main(string[] args)
    {
        Program program = new Program();

        while (true)
        {
            Console.WriteLine("Enter a number from the choices below:");
            Console.WriteLine("1. Add todo");
            Console.WriteLine("2. View todos");
            Console.WriteLine("3. Edit a todo");
            Console.WriteLine("4. Remove a todo");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    program.AddItem();
                    break;
                case "2":
                    program.ViewItems();
                    break;
                case "3":
                    program.EditItem();
                    break;
                case "4":
                    program.DeleteItem();
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }

        }
    }
}



