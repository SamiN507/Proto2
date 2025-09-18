using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int points;
    public int health = 100;

    public TextMeshProUGUI pointsText;
    public TextMeshProUGUI healthText;

    public void AddPoint()
    {
        points += 10;
        UpdateUI();
    }

    void UpdateUI()
    {
        if (pointsText != null) pointsText.text = $"Pisteet: {points}";
        if (healthText != null) healthText.text = $"Terveys: {health}";
    }
}

