using UnityEngine;
using TMPro; // Utilisation du texte UI
using System.Collections; // pr mettre le boost de vitesse

public class PlayerHealth : MonoBehaviour
{
    public int hp = 10;
    public TextMeshProUGUI textePV;

    public AudioClip sonBombe;
    public AudioClip sonSoin;
    public AudioClip sonSpeed;

    private Mouvement scriptMouvement;

    void Start()
    {
        MettreAJourUI(); // affiche les hp au lancement du jeu
        // recuperation du script mouvement sur le joueur au tt debut
        scriptMouvement = GetComponent<Mouvement>();
    }

    // Declenchement de la fonction des que le joueur touche un objet
    void OnCollisionEnter2D(Collision2D collision)
    {
        string nomObjet = collision.gameObject.name;
        // Collision avec une bombe
        if (nomObjet.Contains("ItemBomb"))
        {
            hp -= 2;
            MettreAJourUI();
            Destroy(collision.gameObject);

            if (hp <= 0)
            {
                GameOver();
            }
        }
        // Collision avec une grosse bombe
        else if (nomObjet.Contains("ItemBigBomb"))
        {
            hp -= 7;
            MettreAJourUI();
            Destroy(collision.gameObject);

            if (hp <= 0)
            {
                GameOver();
            }
        }
        // Collision avec un item de heal
        else if (nomObjet.Contains("ItemHeal"))
        {
            hp += 4;
            if (hp > 10) hp = 10;
            MettreAJourUI();
            Destroy(collision.gameObject);
        }
        // Collision avec un item de speed
        else if (nomObjet.Contains("ItemSpeed"))
        {
            // On vérifie que le script mouvement existe avant de lancer le boost
            if (scriptMouvement != null)
            {
                StartCoroutine(BoostVitesse());
            }
            Destroy(collision.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // bombe normal
        if (other.CompareTag("ItemBomb"))
        {
            hp -= 2;
            AudioSource.PlayClipAtPoint(sonBombe, other.transform.position);
            Destroy(other.gameObject);
            MettreAJourUI();
            VerifierMort();
        }

        // boule de feu
        if (other.CompareTag("ItemBigBomb"))
        {
            hp -= 7;
            AudioSource.PlayClipAtPoint(sonBombe, other.transform.position);
            Destroy(other.gameObject);
            MettreAJourUI();
            VerifierMort();
        }

        // soin
        if (other.CompareTag("ItemHeal"))
        {
            hp += 4;
            if (hp > 10) hp = 10;
            AudioSource.PlayClipAtPoint(sonSoin, other.transform.position);
            Destroy(other.gameObject);
            MettreAJourUI();
        }

        // speed
        if (other.CompareTag("ItemSpeed"))
        {
            if (scriptMouvement != null)
            {
                AudioSource.PlayClipAtPoint(sonSpeed, other.transform.position);
                StartCoroutine(BoostVitesse());
            }
            Destroy(other.gameObject);
        }
    }


    // pour éviter de repeter le test de mort partout
    void VerifierMort()
    {
        if (hp <= 0)
        {
            GameOver();
        }
    }




    IEnumerator BoostVitesse()
    {
        float vitesseDeBase = scriptMouvement.vitesse;
        scriptMouvement.vitesse *= 2; // On double
        yield return new WaitForSeconds(5f); // On attend 5 sec
        scriptMouvement.vitesse = vitesseDeBase; // On remet la vitesse normale
    }

    void GameOver()
    {
        textePV.text = "GAME OVER !";
        Time.timeScale = 0; // Le jeu s'arrête
        Debug.Log("Le jeu est arrêté !");
    }

    void MettreAJourUI()
    {
        if (textePV != null)
        {
            textePV.text = "HP : " + hp;
        }
    }
}