public class TodoItem
{
    public string? Description { get; set; }

    public TodoItem(string description)
    {
        Description = description;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        string? todo = null;

        while (string.IsNullOrEmpty(todo))
        {
            Console.WriteLine("Input todo item:");
            todo = Console.ReadLine();
            if (string.IsNullOrEmpty(todo))
            {
                Console.WriteLine("Todo item can not be empty.");
            }
        }

        var todoItem = new TodoItem(todo);
        Console.WriteLine(todoItem.Description);
    }
}



