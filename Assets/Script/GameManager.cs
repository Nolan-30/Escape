using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public void Restart()
    {
        Scene manager = SceneManager.GetActiveScene();
        SceneManager.LoadScene(manager.name);
    }

    public void MainMenu()
    {
        Scene manager = SceneManager.GetActiveScene();
        SceneManager.LoadScene("Menu principal");
    }
}
