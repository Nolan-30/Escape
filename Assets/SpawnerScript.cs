using UnityEngine;

public class SpawnerScript : MonoBehaviour
{

    public GameObject itemBomb;   // rouge
    public GameObject itemBigBomb;   //   noir
    public GameObject itemHeal;   // vert
    public GameObject itemSpeed;  // jaune

    void Start()
    {
        // apparatition des differents items

        InvokeRepeating("SpawnBomb", 1f, 1f); // 1sec
        InvokeRepeating("SpawnBigBomb", 5f, 5f); // 5 sec
        InvokeRepeating("SpawnHeal", 15f, 15f); // 15 sec
        InvokeRepeating("SpawnSpeed", 20f, 20f); // 20 sec
    }

    // Fonctions de spawn spécifiques
    void SpawnBomb() { Apparition(itemBomb); }
    void SpawnBigBomb() { Apparition(itemBigBomb); }
    void SpawnHeal() { Apparition(itemHeal); }
    void SpawnSpeed() { Apparition(itemSpeed); }

    // La fonction qui gère la création physique dans le jeu
    void Apparition(GameObject objet)
    {
        if (objet != null)
        {
            float xAleatoire = Random.Range(-8f, 8f);
            // On fait spawner un peu plus haut (Y = 7) pour qu'ils tombent bien
            Vector3 position = new Vector3(xAleatoire, 7f, 0f);
            Instantiate(objet, position, Quaternion.identity);
        }
    }
}