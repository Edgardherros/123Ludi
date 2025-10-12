using UnityEngine;

public class Moviment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    float maxSpeed = 10f;
     Rigidbody2D rb;
    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(new Vector2(-10f, 0f));
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(new Vector2(10f, 0f));
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            rb.AddForce((new Vector2(0f, 5f)), ForceMode2D.Impulse);
        }
        if (rb.linearVelocity.x >= maxSpeed)
        {
            rb.linearVelocity = new Vector2(maxSpeed, rb.linearVelocity.y);
        }
        if (rb.linearVelocity.x <= -maxSpeed)
        {
            rb.linearVelocity = new Vector2(-maxSpeed, rb.linearVelocity.y);
        }
    }
}
