using UnityEngine;
using TMPro; // Utilisation du texte UI

public class PlayerHealth : MonoBehaviour
{
    public int hp = 10;
    public TextMeshProUGUI textePV;

    void Start()
    {
        MettreAJourUI(); // affiche els hp au lancement du jeu
    }

    // Declenchement de la fonction des que le joueur touche un objet
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name.Contains("Item"))
        {
            hp -= 2;
            MettreAJourUI();
            Destroy(collision.gameObject);

            if (hp <= 0)
            {
                GameOver(); // appl de la fonction
            }
        }
    }

    void GameOver()
    {
        // changement du txt_HP pr gameover
        textePV.text = "GAME OVER !";

        // 2. On fige le temps (le jeu s'arrête littéralement)
        Time.timeScale = 0;

        Debug.Log("Le jeu est arrêté !");
    }
    // rafraichir le temps
    void MettreAJourUI()
    {
        if (textePV != null)
        {
            textePV.text = "HP : " + hp;
        }
    }
}