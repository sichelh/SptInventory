public class Character
{
    public string Id { get; private set; }
    public int Level { get; private set; }
    public float CurExp { get; private set; }
    public float MaxExp { get; private set; }
    public float Gold { get; private set; }
    
    // Stat
    public float Atk { get; private set; }
    public float Def { get; private set; }
    public float Hp { get; private set; }
    public float Crit { get; private set; }
    
    public Character(CharacterData data)
    {
        Id = data.Id;
        Level = data.Level;
        CurExp = data.CurExp;
        MaxExp = data.MaxEXp;
        Gold = data.Gold;
        Atk = data.Atk;
        Def = data.Def;
        Hp = data.Hp;
        Crit = data.Crit;
    }
}
