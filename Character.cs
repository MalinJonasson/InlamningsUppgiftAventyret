namespace InlämningsUppgiftÄventyret
{
    public class Character
    {
        public string Name;
        public List<Item> Items = new();
        public Character (string name)
        {
            Name = name;
        }

        public void GetItems()
        {
            Console.Clear();
            Console.Write("Current Character Inventory: ");

            foreach (Item item in Items)
            {
                Console.Write(item.Name + " ");
            }

        }
    }
}
