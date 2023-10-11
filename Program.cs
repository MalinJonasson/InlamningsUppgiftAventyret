namespace InlämningsUppgiftÄventyret
{
    public class Äventyret
    {
        static void Main(string[] args)
        {
            List<Location> locations = SetupLocations();
            Character character = new Character("Knight");

            Console.WriteLine("The prinsess needs saving, she's been taken by the dragon!");
            Console.WriteLine("You need to collect items in order to save her. To choose an alternative, press enter.");
            Console.ReadKey();

            int menuChoice;
            bool run = true;
            do
            {
                MenuStarter(character);

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

                if (menuChoice == 1)
                {
                    
                    if (character.Items.Contains(locations[0].LocationItem))
                    {
                        Console.Clear();
                        Console.WriteLine("You've already collected a horse");
                        Console.ReadKey();

                        continue;
                    }

                    Console.Clear();
                    character.Items.Add(locations[0].LocationItem);
                    Console.WriteLine("You collected a horse");
                    Console.ReadKey();
                    
                }
                else if (menuChoice == 2)
                {
                    if (character.Items.Contains(locations[1].LocationItem))
                    {
                        Console.Clear();
                        Console.WriteLine("You've already collected a sword");
                        Console.ReadKey();

                        continue;
                    }

                    Console.Clear();
                    character.Items.Add(locations[1].LocationItem);
                    Console.WriteLine("You collected a sword");
                    Console.ReadKey();
                }
                else if (menuChoice == 3)
                {
                    if (character.Items.Contains(locations[2].LocationItem))
                    {
                        Console.Clear();
                        Console.WriteLine("You've already collected a shield");
                        Console.ReadKey();

                        continue;
                    }

                    Console.Clear();
                    character.Items.Add(locations[2].LocationItem);
                    Console.WriteLine("You collected a shield");
                    Console.ReadKey();
                }
                else if (menuChoice == 4)
                {
                    Console.Clear();
                    Console.WriteLine("You went to the dragon");
                    Console.WriteLine("Do you want to fight or talk to the dragon?");
                    string answer = Console.ReadLine().ToLower();

                    if (answer == "fight")
                    {
                        if(character.Items.Count() == 3)
                        {
                            Console.WriteLine("You slayed the dragon! The princess is safe");
                            Console.ReadKey();
                        }
                        run = false;
                    }
                    else if(answer == "talk")
                    {
                        Console.WriteLine("You got the princess back, it was a nice dragon. All it took to save her was a conversation");
                        Console.ReadKey();
                        run = false;
                    }
                }
                else if (menuChoice == 5)
                {
                    Console.Clear();
                    Console.WriteLine("You went home");
                    Console.ReadKey();
                    run = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Either you wrote to many numbers or a number that doesn't exists.");
                    Console.ReadKey();
                }


            } while (run);

            
        }
        private static void MenuStarter(Character character)
        {
            Console.Clear();
            Console.Write("Current Character Inventory: ");
            foreach (Item item in character.Items)
            {
                Console.Write(item.Name + " ");
            }
            Console.WriteLine("\n\nMenu:");
            Console.WriteLine("1. Go to the stables to collect a horse");
            Console.WriteLine("2. Go to the forge to collect a sword");
            Console.WriteLine("3. Go to the guard house to collect a shield");
            Console.WriteLine("4. Go to the dragon");
            Console.WriteLine("5. Go home.");
            

        }
        private static List<Location> SetupLocations()
        {

            return new List<Location>
            {
                new Location("Stable", new Item("Horse")),
                new Location("Forge", new Item ("Sword")),
                new Location("Guard house", new Item("Shield"))
            };
        }
        
    }
}