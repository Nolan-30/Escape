using UnityEngine;
// deplacement du perso
public class Mouvement : MonoBehaviour
{
    public float vitesse = 10f;

    void Update()
    {
        // recuperation  des flèches du clavier 
        float horizontal = Input.GetAxis("Horizontal");


        // deplcaement du perso sur l'axe X(gauche droite)
        transform.Translate(horizontal * vitesse * Time.deltaTime, 0, 0);
    }
}