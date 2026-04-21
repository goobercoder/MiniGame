using UnityEngine;

public class TrumpControl : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate() 
    {
        float input = Input.GetAxisRaw("Horizontal");

        float y = rb.position.y;

        rb.linearVelocity = new Vector2(0, input * speed * -1);
    }
}