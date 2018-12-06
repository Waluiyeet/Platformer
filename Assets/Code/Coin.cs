using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public int Score = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // Kollar om det objektet koliderar med har taggen Player
        if (collision.tag == "Player")
        {
            //skapar en temporär variabel "controller" och sätt den till resultatet av sökningen efter sökningen efter objektet med taggen "GameController"
            //skapar en temporär variabel "tracker" och sätter den till resultatet av sökningen efter komponenten "ScoreTracker"
            GameObject controller = GameObject.FindWithTag("GameController");
            if (controller != null)
            {
                ScoreTracker tracker = controller.GetComponent<ScoreTracker>();
                if (tracker != null)
                {
                    tracker.TotalScore += Score;
                }
                else
                {
                    Debug.LogError("Scoretracker saknas på gamecontroller");
                }
            }
            else
            {
                // Om inte sakerna inanför ifen existeras görs detta
                Debug.LogError("Gamecontroller finns inte");
            }
        }
        // Förstör objektet och eftersom den är längst ner i scriptet så görs denna funktionen sist för om den skulle vara högre upp 
        Destroy(gameObject);
    }
}
