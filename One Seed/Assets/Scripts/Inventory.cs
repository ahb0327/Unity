using System.Collections.Generic;

public class Inventory
{
    private List<Item> item = new List<Item>();
    private Dictionary<string, Item> itemPresets = new Dictionary<string, Item>();

    public void SetPreset(string name, Item preset)
    {
        itemPresets[name] = preset;
    }

    public void AddNew(string name)
    {
        Item preset = itemPresets[name];

        Item newItem = new Item(preset);
    }
}