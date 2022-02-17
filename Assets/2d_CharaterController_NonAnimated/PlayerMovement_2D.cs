using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_2D : MonoBehaviour
{   
    [Header("Input settings:")]
    public float speedMultiplier = 5.0f;

    [Space]
    [Header("Character Stats:")]
    public Vector2 movementDirection;
    public float movementSpeed;

    [Space]
    [Header("References:")]
    public Rigidbody2D rb;
    
    
    // Update is called once per frame
    void Update()
    {
        movementDirection = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        movementSpeed = Mathf.Clamp(movementDirection.magnitude, 0.0f, 1.0f);
        movementDirection.Normalize();
        Move();
      


    }

    void Move()
    {
        rb.velocity = movementDirection * movementSpeed * speedMultiplier;
    }

   

}
