using System;
using UnityEngine;

public class UIManager : Singleton<UIManager>
{
    [SerializeField] private UIMainMenu mainMenu;
    [SerializeField] private UIStatus status;
    [SerializeField] private UIInventory inventory;
    
    public UIMainMenu MainMenu => mainMenu;
    public UIStatus Status => status;
    public UIInventory Inventory => inventory;
    
}
