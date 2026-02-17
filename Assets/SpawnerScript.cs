using UnityEngine;
using System.Collections;

public class SpawnerScript : MonoBehaviour
{
    public GameObject itemPrefab;
    public float tempsEntreSpawn = 1.0f; // chaque cube apparaitre tt les 1sec

    void Start()
    {
        InvokeRepeating("Spawn", 0f, tempsEntreSpawn);
    }

    // C'est cette version UNIQUE que tu dois garder
    void Spawn()
    {
        // Au lieu de créer les objets ici, on lance la "séquence de pluie"
        StartCoroutine(PluieDeCubes());
    }

    // C'est notre séquence "au ralenti"
    IEnumerator PluieDeCubes()
    {
        for (int i = 0; i < 6; i++)
        {
            float xAleatoire = Random.Range(-9f, 9f);
            Vector3 position = new Vector3(xAleatoire, transform.position.y, 0);
            Instantiate(itemPrefab, position, Quaternion.identity);

            // le code attend 1sec avant de continuer la boucle 
            yield return new WaitForSeconds(1.0f);
        }
    }
}