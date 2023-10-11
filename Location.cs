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
    }
}
