using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    [Header("Button")]
    [SerializeField] private Button exitBtn;

    [Header("Slot")] 
    [SerializeField] private GameObject slotPrefab;
    [SerializeField] private Transform slotParent;

    [Header("Info")] [SerializeField] private TextMeshProUGUI itemNum;
    
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
        // 기존 슬롯 제거하여 중복 생성 방지
        foreach (var slot in slots)
        {
            Destroy(slot.gameObject);
        }
        slots.Clear();
        
        // 아이템 보유 수
        int myItemNum = gameManager.Player.Inventory.Count;
        itemNum.text = $"{myItemNum}";
        
        for (int i=0; i<myItemNum; i++)
        {
            GameObject slotGO = Instantiate(slotPrefab, slotParent);
            UISlot uiSlot = slotGO.GetComponent<UISlot>();
            slots.Add(uiSlot);
            uiSlot.SetItem(gameManager.Player.Inventory[i]);
        }
    }

    // 모든 슬롯 UI 업데이트
    public void RefreshAllSlots()
    {
        for (int i=0; i<slots.Count; i++)
        {
            slots[i].RefreshUI();
        }
    }

}
