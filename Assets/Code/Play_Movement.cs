using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class Play_Movement : MonoBehaviour
{
    [Range(0, 20)]
    public float moveSpeed;
    public GroundedCheck GroundedCheck;
    public static Play_Movement current;
    public GodMode Godmode;
    public float jumphight;
    private Rigidbody2D rbody;
    public bool dead = false;

    // Use this for initialization
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        current = this;
    }

    // Update is called once per frame
    void Update()
    {

        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rbody.velocity.y); //gör så att man rör sig om man trycker på a, d, högerpil eller vänsterpil genom att lägger på en hastighet åt höger eller vänster beroende på vilken knapp du trycker ner

        //när du trycker ner W så kollar den om IsGrounded är mer än 0 eller om God är sann
        if (Input.GetKeyDown(KeyCode.W) && (GroundedCheck.IsGrounded > 0 || Godmode.God == true)) 
        {
            //och om de kriterierna ovan är ifyllda så sätter vi en kraft på spelaren uppåt så det värkar som att hoppa
            rbody.AddForce(new Vector2(rbody.velocity.x, jumphight), ForceMode2D.Impulse); 
        }
    }
}
