using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    public static void StartGame () {
        SceneManager.LoadScene("MainGame");
    }
    public static void ReturnGame()
    {

    }
}
