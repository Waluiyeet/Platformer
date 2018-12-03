using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victory_royal : MonoBehaviour
{
    public string levelToLoad;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player") // Om objektet koliderar med ett objekt som har taggen player 
        {
            SceneManager.LoadScene(levelToLoad); // Så laddar den in leveln den ska ladda in
            print("you won wow"); // Och skriver "you won wow" i consollen
        }
    }
}
