using UnityEngine;
using UnityEngine.UI;

public class ExpBar : MonoBehaviour
{
    private GameManager gameManager;
    private Image statBarImage;

    private void Awake()
    {
        statBarImage = GetComponent<Image>();
        gameManager = GameManager.Instance;
    }

    void Start()
    {
        UpdateBar();
    }

    private void UpdateBar()
    {
        if (gameManager.Player == null) return;
        statBarImage.fillAmount = gameManager.Player.CurExp / gameManager.Player.MaxExp;
    }
}
