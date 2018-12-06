using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GodMode : MonoBehaviour
{
    public float jumphight;
    private readonly Rigidbody2D rbody;
    public bool God;

    void Update()
    {
        //kollar om man trycker ner Backspace
        if ((Input.GetKeyDown(KeyCode.KeypadEnter)) && (Input.GetKeyDown(KeyCode.Backspace)))
        {
            //Sätter God till motsaten av vad det är
            God = !God;
        }
        if (God == true)
        {
            //ändrar tagen till Ground
            gameObject.tag = "Ground";
        }
        //kollar om man är gud
        if (God == false)
        {
            //gör så att objektets tag är player
            gameObject.tag = "Player";
        }
    }
}
