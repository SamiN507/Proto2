using UnityEngine;

public class ChinupEvents : MonoBehaviour
{
    public GameManager gameManager;

    public void OnChinup()
    {
        if (gameManager != null)
            gameManager.AddPoint();
    }
}
