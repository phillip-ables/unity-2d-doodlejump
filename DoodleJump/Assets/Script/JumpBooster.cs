using UnityEngine;

public class JumpBooster : MonoBehaviour {
    public float boostedJump = 20f;
    private Rigidbody2D person2D;

    void Start () {
		
	}

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.relativeVelocity.y < 0)
        {
            Debug.Log("Colliding from above!!!");
        }
    }
}
