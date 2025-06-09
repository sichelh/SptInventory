using UnityEngine;

public enum EItemType
{
    Equipable,
    Usable
}

public class Item
{
    public string Name { get; private set; }
    public EItemType Type { get; private set; }
    public Sprite Icon { get; private set; }
    public float Atk { get; private set; }
    public float Def { get; private set; }
    public float Hp { get; private set; }
    public float Crit { get; private set; }

    public Item(ItemData data)
    {
        Type = data.Type;
        Name = data.Name;
        Icon = data.Icon;
        Atk = data.Atk;
        Def = data.Def;
        Hp = data.Hp;
        Crit = data.Crit;
    }
}
