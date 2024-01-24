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
                    Console.WriteLine("Edit");
                    break;
                case "4":
                    Console.WriteLine("Remove");
                    break;
                default:
                    Console.WriteLine("Invalid");
                    break;
            }

        }
    }
}



