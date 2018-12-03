using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedCheck : MonoBehaviour
{
    public int IsGrounded; //en variabel som kollar om man är på marken

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Ger ett värde till IsGrounded
        IsGrounded++; 
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //tar bort värde från IsGrounded
        IsGrounded--; 
    }
}
