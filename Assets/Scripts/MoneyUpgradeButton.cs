using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoneyUpgradeButton : MonoBehaviour
{
    public GameManager gameManager;
    public int cost = 75;
    public int extraMoneyPerClick = 1;
    public Button button;
    public TextMeshProUGUI costText;

    void Start()
    {
        if (button != null)
            button.onClick.AddListener(BuyUpgrade);

        UpdateCostText();
    }

    void BuyUpgrade()
    {
        if (gameManager.money >= cost)
        {
            gameManager.money -= cost;
            gameManager.UpgradeMoney(extraMoneyPerClick);
            gameManager.AddPoint();

            cost += 50;
            UpdateCostText();

            Debug.Log($"Money per click upgraded! New value: {gameManager.moneyPerClick}");
        }
        else
        {
            Debug.Log("Liian köyhä!");
        }
    }

    void UpdateCostText()
    {
        if (costText != null)
            costText.text = $"MassiKeisari Pasi: {cost}€";
    }
}
