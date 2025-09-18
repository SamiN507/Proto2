using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int points;
    public int money;
    public int health = 100;

    public TextMeshProUGUI pointsText;
    public TextMeshProUGUI moneyText;
    public TextMeshProUGUI healthText;

    public void AddPoint()
    {
        points++;
        money++;
        UpdateUI();
    }

    void UpdateUI()
    {
        if (pointsText != null) pointsText.text = $"Pisteet: {points}";
        if (moneyText != null) moneyText.text = $"Raha: {money}";
        if (healthText != null) healthText.text = $"Terveys: {health}";
    }
}

