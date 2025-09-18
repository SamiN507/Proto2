using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    public OnClickLeuka playerClicker;
    public int cost = 50;
    public int extraPoints = 5;
    public Button button;

    void Start()
    {
        if (button != null)
            button.onClick.AddListener(BuyUpgrade);
    }

    void BuyUpgrade()
    {
        if (playerClicker.money >= cost)
        {
            playerClicker.money -= cost;
            playerClicker.UpdateMoneyUI();

            playerClicker.gameManager.pointsPerClick += extraPoints;

            Debug.Log("Upgradesit Leuan! Uudet pisteet per leuka: " + playerClicker.gameManager.pointsPerClick);
        }
        else
        {
            Debug.Log("Liian köyhä!");
        }
    }
}
