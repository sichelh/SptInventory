using UnityEngine;

public class GameManager : Singleton<GameManager>
{
    [Header("ScriptableObjects")]
    [SerializeField] private CharacterData playerData;
    [SerializeField] private ItemDataList itemDataList;
    private Character player;
    public Character Player => player;
    
    private UIManager uiManager;
    
    private void Start()
    {
        uiManager = UIManager.Instance;
        
        // ScriptableObject 누락 시 예외처리
        if (playerData == null || itemDataList == null)
        {
            Debug.LogError("ScriptableObject가 누락되었습니다.");
            return;
        }
        
        SetData(playerData);
    }

    private void SetData(CharacterData data)
    {
        // 플레이어 데이터 가져와서 ui에 set
        player = new Character(data);
        uiManager.MainMenu.SetPlayerInfo(player);
        uiManager.Status.SetPlayerStat(player);
        
        // 아이템 데이터 리스트에 있는 것들 모두 플레이어 인벤토리에 추가
        foreach (var item in itemDataList.items)
        {
            player.AddItem(new Item(item));
        }
    }
}
