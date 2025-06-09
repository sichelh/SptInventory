using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [Header("Button")]
    [SerializeField] private Button exitBtn;

    [Header("Slot")] 
    [SerializeField] private GameObject slotPrefab;
    [SerializeField] private Transform slotParent;
    
    private List<UISlot> slots = new List<UISlot>();

    private UIManager uiManager;
    private GameManager gameManager;
    
    private void Start()
    {
        uiManager = UIManager.Instance;
        gameManager = GameManager.Instance;
        exitBtn.onClick.AddListener(ExitBtn);
        InitInventoryUI();
    }

    // 메인메뉴로 가는 버튼 작동하는 함수
    private void ExitBtn()
    {
        uiManager.MainMenu.OpenMainMenu();
        gameObject.SetActive(false);
    }

    // 인벤토리 슬롯 초기화
    public void InitInventoryUI()
    {
        for (int i=0; i<gameManager.Player.Inventory.Count; i++)
        {
            GameObject slotGO = Instantiate(slotPrefab, slotParent);
            UISlot uiSlot = slotGO.GetComponent<UISlot>();
            slots.Add(uiSlot);
            uiSlot.SetItem(gameManager.Player.Inventory[i]);
        }
    }

    public void RefreshAllSlots()
    {
        for (int i=0; i<slots.Count; i++)
        {
            slots[i].RefreshUI();
        }
    }

}
