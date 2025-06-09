using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [Header("Button")]
    [SerializeField] private Button exitBtn;

    private UIManager uiManager;
    
    private void Start()
    {
        uiManager = UIManager.Instance;
        exitBtn.onClick.AddListener(ExitBtn);   
    }

    private void ExitBtn()
    {
        uiManager.MainMenu.OpenMainMenu();
        gameObject.SetActive(false);
    }  
}
