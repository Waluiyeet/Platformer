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
        rbody = GetComponent<Rigidbody2D>();
        Move(true);
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.O))
        {
            Move(true);
        }
    }

    void Move(bool Flip)
    {
        isleft = !isleft;
        if (Flip == true)

            if (isleft == true)
            {
                rbody.velocity = new Vector2(-SPEED, rbody.velocity.y);
                transform.localScale = new Vector3(1, 1, 1);
            }
            else
            {
                rbody.velocity = new Vector2(SPEED, rbody.velocity.y);
                transform.localScale = new Vector3(-1, 1, 1); //gör så att bilden och hitboxen på fienden eller det rörande objektet
            }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "InvisWall") //den registrerar om fienden slår emot de onsynliga väggarna
        {
            Move(true);
        }
    }
}
