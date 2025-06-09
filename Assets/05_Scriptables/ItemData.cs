using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemData
{
    public string Name;
    public EItemType Type;
    public Sprite Icon;
    public float Atk;
    public float Def;
    public float Hp;
    public float Crit;
}

[CreateAssetMenu(fileName = "ItemDataList", menuName = "Item/Item List")]
public class ItemDataList : ScriptableObject
{
    public List<ItemData> items;
}