using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetInvis : MonoBehaviour
{

    void Start()
    {
        // Gör så att när spelet startar så stänger den av spriterendereren för objektet och det gör så att den är osynlig men den är fortfarande kvar i världen
        GetComponent<SpriteRenderer>().enabled = false;
    }
}
