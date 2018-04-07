using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]//theres is always going to be a rigidbody along with the script
public class Player : MonoBehaviour {
    public float movementSpeed = 10f;

    Rigidbody2D rb;
    float movement = 0f;

    void Start () {
        rb = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
	}

    //you dont want to do movement in update
    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }
}
