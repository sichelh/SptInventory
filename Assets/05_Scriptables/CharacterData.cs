using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "Character/Data")]
public class CharacterData : ScriptableObject
{
    public string Id;
    public int Level;
    public float CurExp;
    public float MaxEXp;
    public float Gold;
    public float Atk;
    public float Def;
    public float Hp;
    public float Crit;
}
