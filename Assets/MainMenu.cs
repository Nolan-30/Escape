using UnityEngine;
using UnityEngine.SceneManagement; 

public class MainMenu : MonoBehaviour
{
    public GameObject menuOptions;

    public void Jouer()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void OuvrirOptions()
    {
        menuOptions.SetActive(true); 
    }

    public void FermerOptions()
    {
        menuOptions.SetActive(false); 
    }

    public void Quitter()
    {
        Debug.Log("Le jeu se ferme !");
        Application.Quit(); 
    }
}