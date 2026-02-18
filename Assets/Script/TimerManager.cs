using UnityEngine;
using TMPro; 
using UnityEngine.Events; // Pour prévenir le GameManager quand c'est fini

public class TimerManager : MonoBehaviour
{
    [Header("Réglages du Temps")]
    public float timeRemaining = 30f;
    private bool timerIsRunning = false;

    [Header("Références UI")]
    public TextMeshProUGUI timerText;

    [Header("Événements")]
    public UnityEvent onTimerEnd; // Cela permettra de déclencher des actions dans Unity

    void Start()
    {
        timerIsRunning = true;
    }

    

    void UpdateDisplay(float timeToDisplay)
    {
        // On divise toujours par 60 pour obtenir les minutes réelles
        float minutes = Mathf.FloorToInt(timeToDisplay / 60); 
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        
        // Cela affichera "00:30", "00:29", etc.
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                UpdateDisplay(timeRemaining);
            }
            else
            {
                timeRemaining = 0;
                timerIsRunning = false;
                UpdateDisplay(timeRemaining);
                
                
                ArreterLeJeu(); 
              

                if (onTimerEnd != null)
                    onTimerEnd.Invoke();
            }
        }
    }

    void ArreterLeJeu()
    {
        Time.timeScale = 0f; // Cela fige TOUS les mouvements basés sur le temps
        Debug.Log("Le jeu est figé !");
    }
}