using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int hp = 10; // PV

    // declenchement de la fonction des que le joueur touche un item
    void OnCollisionEnter2D(Collision2D collision)
    {
        // On vérifie si joueur touche bien un "Item"
        if (collision.gameObject.name.Contains("Item"))
        {
            hp -= 2; // on enelve de hp
            Debug.Log("Aïe ! PV restants : " + hp);

            // destruction du cube rouge
            Destroy(collision.gameObject);


            if (hp <= 0)
            {
                Debug.Log("GAME OVER !");

            }
        }
    }
}