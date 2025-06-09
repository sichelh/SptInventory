using UnityEngine;

public class Character : MonoBehaviour
{
    public string ID { get; private set; }
    public int Level { get; private set; }
    public float Exp { get; private set; }
    public float MaxExp { get; private set; }
    public float Gold { get; private set; }
    public float Atk { get; private set; }
    public float Def { get; private set; }
    public float Hp { get; private set; }
    public float Crit { get; private set; }
}
