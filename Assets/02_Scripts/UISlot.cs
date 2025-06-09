using System;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    private Item slotItem;
    [SerializeField] private Image itemIcon;
    [SerializeField] private GameObject equipIcon;
    [SerializeField] private Button equipBtn;

    public bool isEquipped = false;

    private GameManager gameManager;
    
    private void Start()
    {
        gameManager = GameManager.Instance;
        equipBtn.onClick.AddListener(EquipBtn);
    }

    public void EquipBtn()
    {
        if (!isEquipped)
        {
            gameManager.Player.Equip(slotItem);
            equipIcon.SetActive(true);
            isEquipped = true;
        }
        else
        {
            gameManager.Player.UnEquip(slotItem);
            equipIcon.SetActive(false);
            isEquipped = false;
        }
    }
    
    public void SetItem(Item item)
    {
        slotItem = item;
    }
    
    public void RefreshUI()
    {
        if (slotItem == null)
        {
            itemIcon = null;
        }
        else
        {
            itemIcon.sprite = slotItem.Icon;
        }
    }

    public void ToggleEquipIcon(bool isEnable)
    {
        equipIcon.SetActive(isEnable);
    }
    
    
}
