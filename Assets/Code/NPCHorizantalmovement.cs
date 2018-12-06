using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCHorizantalmovement : MonoBehaviour
{
    public float SPEED = 2f;
    public bool isleft = true;

    private Rigidbody2D rbody;

    void Start()
    {
        //gör så att objektet har en rigidbody
        rbody = GetComponent<Rigidbody2D>();
        //Move är true
        Move(true);
    }


    void Update()
    {   //om man trycker ner O
        if (Input.GetKeyDown(KeyCode.O))
        {
            //så ändras move till true
            Move(true);
        }
    }

    void Move(bool Flip)
    {   
        //Ändrar isleft till motsatt märde
        isleft = !isleft;
        if (Flip == true)
            //Kollar om isleft är true
            if (isleft == true)
            {
                // Om den är så ger den objektet -Speed för at förflyta objektet åt en riktning
                rbody.velocity = new Vector2(-SPEED, rbody.velocity.y);
                //och ändrar hur objektet är i världen
                transform.localScale = new Vector3(1, 1, 1);
            }
            //Om den inte är sann så händer det här istället
            else
            {
                // Om den är så ger den objektet -Speed för at förflyta objektet åt en riktning
                rbody.velocity = new Vector2(SPEED, rbody.velocity.y);
                //gör så att bilden och hitboxen på fienden eller det rörande objektet
                transform.localScale = new Vector3(-1, 1, 1); 
            }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //den registrerar om fienden slår emot de onsynliga väggarna
        if (collision.tag == "InvisWall") 
        {
            //Då är move true
            Move(true);
        }
    }
}
