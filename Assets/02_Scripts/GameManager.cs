using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private CharacterData playerData;
    private Character player;
    public Character Player => player;
    
    private UIManager uiManager;
    
    private void Start()
    {
        uiManager = UIManager.Instance;
        SetData(playerData);
    }

    private void SetData(CharacterData data)
    {
        player = new Character(data);
        uiManager.MainMenu.SetPlayerInfo(player);
        uiManager.Status.SetPlayerStat(player);
    }
}
