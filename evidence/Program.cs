using evidence;

static void Main(string[] args)
{
    Console.Title = "Pojištění"; //Nadpis
    Knihovna knihovna = new Knihovna(); //Vytvoření třídy Knihovna
    Menu.StartMenu(knihovna); //Zavolání metody StartMenu
}
Main(args);