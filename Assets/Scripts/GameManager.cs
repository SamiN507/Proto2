using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int points;
    public int health = 100;
    public int pointsPerClick = 10;

    public TextMeshProUGUI pointsText;
    public TextMeshProUGUI healthText;

    public void AddPoint()
    {
        points += pointsPerClick;
        UpdateUI();
    }

    void UpdateUI()
    {
        if (pointsText != null) pointsText.text = $"Pisteet: {points}";
        if (healthText != null) healthText.text = $"Terveys: {health}";
    }

    public void UpgradeClick(int cost, int extraPoints)
    {
        if (extraPoints <= 0) return;

        pointsPerClick += extraPoints;
    }
}

