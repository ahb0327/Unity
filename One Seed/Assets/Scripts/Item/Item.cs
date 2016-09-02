public class Item
{
	public Item(int id, string name)
    {
        ID = id;
        Name = name;
    }
    
    public Item(Item original)
    {
        ID = original.ID;
        Name = original.Name;
    }

    public int ID { get; set; }
    public string Name { get; set; }
}