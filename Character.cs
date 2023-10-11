namespace InlämningsUppgiftÄventyret
{
    public class Character
    {
        public string Name;
        public List<Item> Items;
        public Character (string name)
        {
            Name = name;
            Items = new List<Item>();
        }
    }
}
