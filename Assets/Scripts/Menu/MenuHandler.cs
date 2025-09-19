using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuHandler : MonoBehaviour
{
    [SerializeField] private GameObject gameMenu;
    public static void StartGame () {
        SceneManager.LoadScene("MainGame");
    }
    public void ReturnGame()
    {
        HideMenu();
        SceneManager.SetActiveScene(SceneManager.GetActiveScene());
    }
    public static void returnMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public static void EndGame()
    {

    }
    public void ShowMenu()
    {
        gameMenu.SetActive(true);
    }
    public void HideMenu()
    {
        gameMenu.SetActive(false);
    }
}
