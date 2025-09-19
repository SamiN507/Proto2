using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ESButton : MonoBehaviour
{
    public GameManager gameManager;
    public int cost = 20;
    public int healAmount = 20;
    public Button button;
    public TextMeshProUGUI costText;

    void Start()
    {
        button.onClick.AddListener(BuyES);

        UpdateCostText();
    }

    void BuyES()
    {
        gameManager.BuyES(cost, healAmount);
    }
    void UpdateCostText()
    {
        if (costText != null)
            costText.text = $"Osta ES ({healAmount}hp): {cost}€";
    }
}
