using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    [Header("Info")]
    [SerializeField] private TextMeshProUGUI atkVal;
    [SerializeField] private TextMeshProUGUI defVal;
    [SerializeField] private TextMeshProUGUI hpVal;
    [SerializeField] private TextMeshProUGUI critVal;
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
    
    public void SetPlayerStat(Character player)
    {
        atkVal.text = $"{player.Atk}";
        defVal.text = $"{player.Def}";
        hpVal.text = $"{player.Hp}";
        critVal.text = $"{player.Crit}";
    }
}
