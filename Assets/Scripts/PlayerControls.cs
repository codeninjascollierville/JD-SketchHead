using System.Collections;
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
    }
}
