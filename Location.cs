namespace InlämningsUppgiftÄventyret
{
    public class Location
    {
        public string LocationName;
        public Item LocationItem { get; set; }

        public Location(string locationName, Item locationItem)
        {
            LocationName = locationName;
            LocationItem = locationItem;

        }

        public void CollectItem(List<Item> characterItems)
        {
            if (characterItems.Contains(LocationItem))
            {
                Console.Clear();
                Console.WriteLine("You've already collected a " + LocationItem.Name);
                Console.ReadKey();

            }
            else 
            {
                Console.Clear();
                characterItems.Add(LocationItem);
                Console.WriteLine("You went to the " + LocationName + " and collected a " + LocationItem.Name);
                Console.ReadKey();
            }   
            
        }
    }
}
