using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [Header("Info")]
    [SerializeField] private TextMeshProUGUI id;
    [SerializeField] private TextMeshProUGUI playerClass;
    [SerializeField] private TextMeshProUGUI description;
    [SerializeField] private TextMeshProUGUI goldVal;
    [SerializeField] private TextMeshProUGUI levelVal;
    [SerializeField] private TextMeshProUGUI expVal;
    [Header("Button")]
    [SerializeField] private Button statusBtn;
    [SerializeField] private Button inventoryBtn;

    private UIManager uiManager;
    private GameManager gameManager;
    
    private void Start()
    {
        uiManager = UIManager.Instance;
        gameManager = GameManager.Instance;
        statusBtn.onClick.AddListener(OpenStatus);
        inventoryBtn.onClick.AddListener(OpenInventory);
    }

    public void OpenMainMenu()
    {
        uiManager.MainMenu.gameObject.SetActive(true);
        ToggleMainMenuBtn(true);
    }

    private void OpenStatus()
    {
        uiManager.Status.gameObject.SetActive(true);
        ToggleMainMenuBtn(false);
        
        // Status 창 열 때마다 Stat 변화 반영
        uiManager.Status.SetPlayerStat(gameManager.Player);
    }

    private void OpenInventory()
    {
        uiManager.Inventory.gameObject.SetActive(true);
        ToggleMainMenuBtn(false);
    }

    // 메인메뉴에 있는 버튼 두개 토글
    private void ToggleMainMenuBtn(bool isEnable)
    {
        statusBtn.gameObject.SetActive(isEnable);
        inventoryBtn.gameObject.SetActive(isEnable);
    }

    // 메인메뉴에 있는 플레이어 정보 반영
    public void SetPlayerInfo(Character player)
    {
        id.text = $"{player.Id}";
        playerClass.text = $"{player.Class}";
        description.text = $"{player.Description}";
        levelVal.text = $"{player.Level}";
        goldVal.text = $"{player.Gold}";
        expVal.text = $"{player.CurExp} / {player.MaxExp}";
    }
}
