using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hurter : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // om objektet slår emot ett objekt som har tagen player 
        if (collision.gameObject.tag == "Player") 
        {
#if !DEBUG
            //Stänger ner spelet när man inte är i editorn
            Application.Quit(); 
#endif
            // Letar upp vad leveln du är på heter och laddar in den fungerar enbart om man är i editorn
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); 
        }
    }
}
