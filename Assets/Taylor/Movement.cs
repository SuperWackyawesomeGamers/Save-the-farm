using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public bool DoubleCheck;
    public float RegSpeed = 1;
    public float dashspeed = 12;
    public bool Incooldown;
    public bool dashOK;
    public float MovementSpeed;
    public float JumpForce = 1;
    public bool Grounded;
    public int jumpCount;

    private Rigidbody2D _rigidbody;

    SpriteRenderer sr;

    // Start is called before the first frame update
    private void Start()
    {
        MovementSpeed = RegSpeed;
        _rigidbody = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        Debug.Log("MOVEMENT????");
    }

    // Update is called once per frame
    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        if(movement > 0)
        {
            sr.flipX = true;
        }
        if (movement < 0)
        {
            sr.flipX = false;
        }

        Grounded = Mathf.Abs(_rigidbody.velocity.y) < 0.0001f;
        if (Grounded)
        {
            jumpCount = 0;

        }

       
        if (Input.GetButtonDown("Jump") && jumpCount <= 1)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            jumpCount++;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift) && Incooldown == false)
        {
            MovementSpeed = dashspeed;
            dashOK = true;
            Invoke("ResetDash", 0.5f);
            Incooldown = true;
            Invoke("ResetCooldown", 1.0f);

        }
       
    }
    private void ResetDash()
    {
        dashOK = false;
        MovementSpeed = RegSpeed;
    }
    private void ResetCooldown()
    {
        Incooldown = false;
    }
}

