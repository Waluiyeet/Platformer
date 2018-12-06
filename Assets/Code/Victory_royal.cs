using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory_royal : MonoBehaviour
{
    public string levelToLoad;

    private void OnTriggerEnter2D(Collider2D collision)
    {
            // Om objektet koliderar med ett objekt som har taggen player 
        if (collision.tag == "Player") 
        {
            // Så laddar den in leveln den ska ladda in
            SceneManager.LoadScene(levelToLoad); 
            // Och skriver "you won wow" i consollen
            print("you won wow"); 
        }
    }
}
