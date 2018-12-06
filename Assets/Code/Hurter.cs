using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Hurter : MonoBehaviour
{
    public bool TutorialDone = false;
    private readonly string Tutorial = SceneManager.GetActiveScene().name;

    private void Update()
    {

        if(Tutorial == "Level_0")
        { 
        }
        else
        {
            //ändrar TutorialDone till true
            TutorialDone = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // om objektet slår emot ett objekt som har tagen player 
        if (collision.gameObject.tag == "Player" && TutorialDone == true)
        {
            //#if !DEBUG
            //            //Stänger ner spelet när man inte är i editorn
            //            Application.Quit(); 
            //#endif
            // Letar upp vad leveln du är på heter och laddar in den fungerar enbart om man är i editorn
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
