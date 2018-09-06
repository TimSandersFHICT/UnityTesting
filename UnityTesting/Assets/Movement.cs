using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float speed;             //Floating point variable to store the player's movement speed.

    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
    private InputBehaviour _input;

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        _input = GetComponent<InputBehaviour>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        if (_input.Tap())
        {
            Touch touch = Input.GetTouch(0);
            Debug.Log(touch.position);
            rb2d.AddForce(touch.position * speed);
        }
        //Store the current horizontal input in the float moveHorizontal.
        float moveHorizontal = Input.GetAxis("Horizontal");

        //Store the current vertical input in the float moveVertical.
        float moveVertical = Input.GetAxis("Vertical");

        //Use the two store floats to create a new Vector2 variable movement.
        Vector2 movement = new Vector2(moveHorizontal, moveVertical);

        //Call the AddForce function of our Rigidbody2D rb2d supplying movement multiplied by speed to move our player.
        rb2d.AddForce(movement * speed);
    }
}
