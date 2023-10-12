namespace InlämningsUppgiftÄventyret
{
    internal class Dragon
    {

        public string Name;
        public Dragon(string name)
        {
            Name = name;
        }
        public bool GoToDragon(Character character)
        {
            Console.Clear();
            Console.WriteLine("You went to the " + Name + ".");
            Console.WriteLine("Do you want to fight or talk to the " + Name + "?");
            string answer = Console.ReadLine().ToLower();
                                        
            if (answer == "fight")
            {
                if (character.Items.Count() == 3)
                {
                    Console.Clear();
                    Console.WriteLine("You slayed the " + Name + "! The princess is safe!");
                    Console.ReadKey();
                }
                    
                return false;
            }
            else if (answer == "talk")
            {
                Console.Clear();
                Console.WriteLine("You got the princess back, it was a nice " + Name + ". All it took to save her was a conversation!");
                Console.ReadKey();
                return false;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("You need to make a choice, fight or talk. You ran away in fear, come back and try again.");
                Console.ReadKey();
                return true;
            }
        }
    }
}
