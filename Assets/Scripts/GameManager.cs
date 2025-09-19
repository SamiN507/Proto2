using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int points;
    public int money;
    public int health = 100;

    public int pointsPerClick = 10;
    public int moneyPerClick = 1;

    public TextMeshProUGUI pointsText;
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI healthText;

    public void AddPoint()
    {
        points += pointsPerClick;
        money += moneyPerClick;
        UpdateUI();
    }

    void UpdateUI()
    {
        if (pointsText != null) pointsText.text = $"Pisteet: {points}";
        if (moneyText != null) moneyText.text = $"Raha: {money}€";
        if (healthText != null) healthText.text = $"Terveys: {health}";
    }

    public void UpgradeClick(int cost, int extraPoints)
    {
        if (extraPoints <= 0) return;

        pointsPerClick += extraPoints;
    }
    public void UpgradeMoney(int extraMoney)
    {
        moneyPerClick += extraMoney;
    }
}

