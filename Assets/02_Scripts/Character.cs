using System.Collections.Generic;
using System.Linq;

public class Character
{
    public string Id { get; private set; }
    public string Class { get; private set; }
    public string Description { get; private set; }
    public int Level { get; private set; }
    public float CurExp { get; private set; }
    public float MaxExp { get; private set; }
    public float Gold { get; private set; }
    
    // Stat
    public float Atk { get; private set; }
    public float Def { get; private set; }
    public float Hp { get; private set; }
    public float Crit { get; private set; }

    public List<Item> Inventory{ get; private set; }
    private List<Item> equipped = new List<Item>();
    
    public float EquippedAtk => Atk + equipped.Sum(i => i.Atk);
    public float EquippedDef => Def + equipped.Sum(i => i.Def);
    public float EquippedHp => Hp + equipped.Sum(i => i.Hp);
    public float EquippedCrit => Crit + equipped.Sum(i => i.Crit);
    
    // 생성자 data 넣기
    public Character(CharacterData data)
    {
        Id = data.Id;
        Class = data.Class;
        Description = data.Description;
        Level = data.Level;
        CurExp = data.CurExp;
        MaxExp = data.MaxEXp;
        Gold = data.Gold;
        Atk = data.Atk;
        Def = data.Def;
        Hp = data.Hp;
        Crit = data.Crit;
        Inventory = new List<Item>();
    }

    public void AddItem(Item item)
    {
        if (item == null) return;
        
        // 인벤토리에 아이템 추가
        Inventory.Add(item);
    }
    
    public void ToggleEquip(Item item)
    {
        // 장착중이면 장착해제
        if (IsEquipped(item))
        {
            UnEquip(item);
        }
        else // 장착중이 아니면 장착
        {
            Equip(item);
        }
    }

    private void Equip(Item item)
    {
        if (!IsEquipped(item))
        {
            // 같은 타입 아이템 확인
            Item sameType = equipped.FirstOrDefault(i => i.Type == item.Type);

            // 같은 타입 아이템이 있으면 제거 후 장착
            if (sameType != null)
            {
                equipped.Remove(sameType);
            }
        
            // 장착 - 장착 리스트에 추가
            equipped.Add(item);
        }
    }

    private void UnEquip(Item item)
    {
        // 장착해제 - 장착 리스트에서 제거
        equipped.Remove(item);
    }

    public bool IsEquipped(Item item)
    {
        // 장착 리스트에 아이템 있는지 확인
        return equipped.Contains(item);
    }

    
}
