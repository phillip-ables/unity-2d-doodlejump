using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(Rigidbody2D))]
public class Man : MonoBehaviour {
    Rigidbody2D rb;
    public float movementSpeed = 10f;
    private float movement = 0f;
    

	void Start () {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update () {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
	}

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }
}
