using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UpgradeButton : MonoBehaviour
{
    public OnClickLeuka playerClicker;
    public int cost = 50;
    public int extraPoints = 5;
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
        if (playerClicker.money >= cost)
        {
            playerClicker.money -= cost;
            playerClicker.UpdateMoneyUI();

            playerClicker.gameManager.pointsPerClick += extraPoints;

            cost += 25;
            UpdateCostText();

            Debug.Log("Upgradesit Leuan! Uudet pisteet per leuka: " + playerClicker.gameManager.pointsPerClick);
        }
        else
        {
            Debug.Log("Liian köyhä!");
        }
    }

    void UpdateCostText()
    {
        if (costText != null)
            costText.text = $"Vahvempi leuka: {cost}€";
    }
}
