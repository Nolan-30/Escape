using UnityEngine;
using UnityEngine.SceneManagement; // change de scene 

public class MainMenu : MonoBehaviour
{
    public void Jouer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quitter()
    {
        Debug.Log("Le jeu se ferme !");
        Application.Quit(); // Ferme le jeu 
    }
}