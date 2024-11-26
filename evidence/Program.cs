using evidence;

static void Main(string[] args)
{
    Console.Title = "Pojištění";
    Knihovna knihovna = new Knihovna();
    Menu.StartMenu(knihovna);
}
Main(args);