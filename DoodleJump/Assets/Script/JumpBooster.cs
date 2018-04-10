using UnityEngine;

public class JumpBooster : MonoBehaviour {
    public float boostedJump = 20f;

    void Start () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.relativeVelocity.y < 0)
        {
            Rigidbody2D person2D = collision.collider.GetComponent<Rigidbody2D>();
            if(person2D != null)
            {
                Vector2 velocity = person2D.velocity;
                velocity.y = boostedJump;
                person2D.velocity = velocity;
            }
        }
    }
}
