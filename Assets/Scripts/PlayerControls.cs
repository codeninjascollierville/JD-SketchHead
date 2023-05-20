﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerControls : MonoBehaviour
{
    //Rgidbody2D object that is stored
    [Header("Rigidbody")]
    public Rigidbody2D rb;
    [Header("Default Down Speed")]
    //Downward speed of the object
    public float downSpeed = 20f;
    [Header("Default Movement Speed")]
    //Movement speed of the object
    public float movementSpeed = 10f;
    [Header("Default Directional Movement Speed")]
    //Movement direction of the object
    public float movement = 0f;
    // Start is called before the first frame update
    void Start()
    {
        //variable equals to component Rigidbody2D
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //movement equals Horizontal movment
        //multiplied by the movement speed
        movement = Input.GetAxis("Horizontal") * movementSpeed;
        //If diretion on x axis is less than 0 
        if (movement < 0)
        {
            //object faces to the left
            this.GetComponent<SpriteRenderer>().flipX = false;
        }
        //if direction on x axis is greater than 0
        else
        {
            //object faces to the right
            this.GetComponent<SpriteRenderer>().flipX = true;
        }
    }

    //Fixedupdate called every fixed frame-rate frame
    void FixedUpdate()
    {
        //Vector2 which is (x,y) velocity
        //equals to the velocity of the rigidbody2D
        Vector2 velocity = rb.velocity;
        //veclocity of the x axis equals to
        //the direction movement on the x axis 
        //of the character.
        velocity.x = movement;
        //Rigidbody2D velocity equals to
        //Velocity of the object
        rb.velocity = velocity;
    }

    //Collision function
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //velocity with the downspeed
        rb.velocity = new Vector3(rb.velocity.x, downSpeed, 0);
    }
}
