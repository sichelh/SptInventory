using System;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    private Item slotItem;
    [Header("Icon")]
    [SerializeField] private Image itemIcon;
    [SerializeField] private GameObject equipIcon;
    [Header("Button")]
    [SerializeField] private Button equipBtn;

    private GameManager gameManager;
    private UIManager uiManager;

    private void Awake()
    {
        gameManager = GameManager.Instance;
        uiManager = UIManager.Instance;
    }

    private void Start()
    {
        // 슬롯 클릭하면 장착되도록
        equipBtn.onClick.AddListener(OnEquipBtn);
    }

    public void OnEquipBtn()
    {
        gameManager.Player.ToggleEquip(slotItem);
        RefreshUI(); // 상태 최신화
        uiManager.Inventory.RefreshAllSlots();
    }
    
    // 슬롯 아이템에 아이템 Data 연결
    public void SetItem(Item item)
    {
        slotItem = item;
        RefreshUI(); // 상태 최신화
    }
    
    public void RefreshUI()
    {
        if (slotItem != null)
        {
            // 슬롯에 아이템이 있으면 아이콘 추가
            itemIcon.sprite = slotItem.Icon;

            // Equip Icon 온오프
            ToggleEquipIcon(gameManager.Player.IsEquipped(slotItem));
        }

    }

    // Equip 표시와 장착중 판별
    private void ToggleEquipIcon(bool isEnable)
    {
        equipIcon.SetActive(isEnable);
    }
    
    
}
