using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JLMovement : MonoBehaviour
{
    public float accel = 8;
    private Rigidbody2D rb2;
    private SpriteRenderer sr;
    public float jumpStrength = 400;
    public bool grounded;
    public float speedCap = 6;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {
            sr.flipX = false;
            rb2.AddForce(new Vector2(accel, 0));
        }

        if (Input.GetAxis("Horizontal") < 0)
        {
            sr.flipX = true;
            rb2.AddForce(new Vector2(-accel, 0));
        }
        if (Input.GetButtonDown("Jump") && grounded == true)
        {
            rb2.AddForce(new Vector2(0, jumpStrength));
        }
        if (rb2.velocity.x > speedCap)
        {
            rb2.velocity = new Vector2(speedCap, rb2.velocity.y);
        }
        if (rb2.velocity.x < -speedCap)
        {
            rb2.velocity = new Vector2(-speedCap, rb2.velocity.y);
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        grounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        grounded = false;
    }
}
