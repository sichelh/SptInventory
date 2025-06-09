using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    [Header("Info")]
    [SerializeField] private TextMeshProUGUI id;
    [SerializeField] private TextMeshProUGUI goldVal;
    [SerializeField] private TextMeshProUGUI levelVal;
    [Header("Button")]
    [SerializeField] private Button statusBtn;
    [SerializeField] private Button inventoryBtn;

    private UIManager uiManager;
    
    private void Start()
    {
        uiManager = UIManager.Instance;
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
    }

    private void OpenInventory()
    {
        uiManager.Inventory.gameObject.SetActive(true);
        ToggleMainMenuBtn(false);
    }

    private void ToggleMainMenuBtn(bool isEnable)
    {
        statusBtn.gameObject.SetActive(isEnable);
        inventoryBtn.gameObject.SetActive(isEnable);
    }

    private void SetPlayerInfo(Character character)
    {
        id.text = character.Id;
        goldVal.text = character.Gold.ToString();
        levelVal.text = character.Level.ToString();
    }
}
