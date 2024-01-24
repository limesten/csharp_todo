public class Program
{
    public static void Main(string[] args)
    {
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
                    Console.WriteLine("Add");
                    break;
                case "2":
                    Console.WriteLine("View");
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



