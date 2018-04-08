using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour {
    private SpriteRenderer personSpriteR;
    private SpriteRenderer carSpriteR;
    private Rigidbody2D rb;
    private float jumpPOWA = 11f;

    public Sprite crushed;
    public Sprite jump;
    public Sprite stand;
    public Sprite car;

    private void OnCollisionEnter2D(Collision2D collision)
    {

        //what data do you need that is being passed in?
        if (collision.relativeVelocity.y < 0f)
        {
            SpriteRenderer carSpriteR = gameObject.GetComponent<SpriteRenderer>();
            SpriteRenderer personSpriteR = collision.collider.GetComponent<SpriteRenderer>();
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            //you still need to typecast it
            //what is colliding in the collision?
            if (rb != null)
            {

                carSpriteR.sprite = crushed;
                personSpriteR.sprite = stand;

                Vector2 velocity = rb.velocity;
                velocity.y = jumpPOWA;
                rb.velocity = velocity;
            }
            StartCoroutine("SpriteChangeDelay", collision);
            //if (collision.gameObject.transform.position.y != 0)
        }
        
    }
    
    private IEnumerator SpriteChangeDelay(Collision2D collision)
    {
        yield return new WaitForSeconds(0.13f);

        Rigidbody2D rbCar = collision.gameObject.AddComponent<Rigidbody2D>();
        SpriteRenderer personSpriteR = collision.collider.GetComponent<SpriteRenderer>();

        personSpriteR.sprite = jump;
        yield return null;
    }
}
