using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Game");
    }

    public void MainMenu()
    {
        Scene manager = SceneManager.GetActiveScene();
        SceneManager.LoadScene("Menu principal");
    }
}
