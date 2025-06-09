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

    // 메인메뉴로 가는 버튼 작동하는 함수
    private void ExitBtn()
    {
        uiManager.MainMenu.OpenMainMenu();
        gameObject.SetActive(false);
    }  
    
    // 플레이어 스탯 정보 스탯창에 반영
    public void SetPlayerStat(Character player)
    {
        atkVal.text = $"{player.EquippedAtk}";
        defVal.text = $"{player.EquippedDef}";
        hpVal.text = $"{player.EquippedHp}";
        critVal.text = $"{player.EquippedCrit}";
    }
}
