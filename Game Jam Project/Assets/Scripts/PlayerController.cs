using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // // Variables:
    private Rigidbody2D rb; // // Reference to Rigidbody

    public float movementSpeed; // // Speed that player moves at
    private bool facingRight = true; // // Determines which way player is facing

    private float speedX;

    private float speedY;

    private float animalFeed;

    public Animal animal;


    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        // // Gets the direction that the player should move in
       speedX = Input.GetAxisRaw("Horizontal") * movementSpeed;
       speedY = Input.GetAxisRaw("Vertical") * movementSpeed;
       rb.velocity = new UnityEngine.Vector2(speedX, speedY);

        // // Makes sure that the player is facing the right direction
       if(speedX > 0 && !facingRight)
       {
            FlipCharacer();
       }
       else if (speedX < 0 && facingRight)
       {
            FlipCharacer();
       }

       // // Handles limits on players' movement to ensure that they don't walk off the screen
       if(transform.position.y <= -4.04f)
       {
            transform.position = new UnityEngine.Vector3(transform.position.x, -4.04f, 0);

       }
       else if (transform.position.y >= 3.98f)
       {
            transform.position = new UnityEngine.Vector3(transform.position.x, 3.98f, 0);
       }

       if (transform.position.x <= -11.67f)
       {
            transform.position = new UnityEngine.Vector3(-11.67f, transform.position.y, 0);
       }
       else if (transform.position.x >= 11.63f)
       {
            transform.position = new UnityEngine.Vector3(11.63f, transform.position.y, 0);
       }
    }

    private void FlipCharacer()
    {
        facingRight = !facingRight;
        transform.Rotate(0f, 180f, 0f);
    }

    private void OnCollisionEnter2D(Collider2D other)
    {
        if(other.CompareTag("Feed"))
        {
            animalFeed += 1;
        }
        else if(other.CompareTag("Animal") && animal.hungerLevels < 100)
        {
            // // Blah

        }
    }


}
