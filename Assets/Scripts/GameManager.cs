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
        health -= 1;
        UpdateUI();

        if (health <= 0)
            GameOver();
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
    public void BuyES(int cost, int healAmount)
    {
        if (money >= cost && health < 100)
        {
            money -= cost;
            health = Mathf.Min(health + healAmount, 100);
            UpdateUI();
            Debug.Log("Ostit ES:n! Pasi on taas valmis vetämään!");
        }
        else
        {
            Debug.Log("Liian köyhä tai täysi HP!");
        }
    }
    void GameOver()
    {
        Debug.Log("ES loppui! Pasi pyörtyi!");
        Time.timeScale = 0;
    }
}

