using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {
    private SpriteRenderer spriteR;
    private Rigidbody2D rb;
    private float jumpPOWA = 8f;

    public Sprite crushed;
    public Sprite car;
    public Sprite jump;
    public Sprite stand;


    private void Start()
    {
        spriteR.sprite = car;
        spriteR.sprite = crushed;
        spriteR.sprite = jump;
        spriteR.sprite = stand;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //what data do you need that is being passed in?
        if (collision.relativeVelocity.y < 0.0f)
        {
            SpriteRenderer spriteR = gameObject.GetComponent<SpriteRenderer>();
            //you still need to typecast it
            //what is colliding in the collision?
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Debug.Log("BAmb");
                spriteR.sprite = crushed;   
            }
        }
        
    }
}
