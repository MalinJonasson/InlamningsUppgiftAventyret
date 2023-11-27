namespace InlämningsUppgiftÄventyret
{
    public class AdventureHandler
    {
        List<Location> Locations = new List<Location>();
        Character Character;
        Dragon Dragon;

        public AdventureHandler()
        {
            Locations.Add(new Location("Stable", new Item("Horse")));
            Locations.Add(new Location("Forge", new Item("Sword")));
            Locations.Add(new Location("Guard house", new Item("Shield")));
            Character = new Character("Knight");
            Dragon = new Dragon("Dragon");
        }

        public void Run()
        {
            Console.WriteLine("The prinsess needs saving, she's been taken by the " + Dragon.Name + "!");
            Console.WriteLine("You need to collect items in order to save her. To start the adventure, press enter.");
            Console.ReadKey();

            int menuChoice;
            bool run = true;
            do
            {
                MenuStarter();

                try
                {
                    menuChoice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.Clear();
                    Console.WriteLine("You can only write a number. Press enter to try again");
                    Console.ReadKey();
                    continue;
                }

                switch (menuChoice.ToString())
                {
                    case "1":
                    case "2":
                    case "3":
                        GoToLocation(menuChoice);
                        break;
                    case "4":
                        run = Dragon.GoToDragon(Character);
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("You went home");
                        run = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Either you wrote to many numbers or a number that doesn't exists.");
                        Console.ReadKey();
                        break;
                }
            } while (run);
        }
        private void MenuStarter()
        {
            Character.GetItems();

            Console.WriteLine("\n\nMenu:");
            Console.WriteLine("1. Go to the " + Locations[0].LocationName + " to collect a " + Locations[0].LocationItem.Name);
            Console.WriteLine("2. Go to the " + Locations[1].LocationName + " to collect a " + Locations[1].LocationItem.Name);
            Console.WriteLine("3. Go to the " + Locations[2].LocationName + " to collect a " + Locations[2].LocationItem.Name);
            Console.WriteLine("4. Go to the " + Dragon.Name);
            Console.WriteLine("5. Go home.");
        }
        private void GoToLocation(int choice)
        {
            int choiceIndex = choice - 1;
            Locations[choiceIndex].CollectItem(Character.Items);    
        }
    }
}

