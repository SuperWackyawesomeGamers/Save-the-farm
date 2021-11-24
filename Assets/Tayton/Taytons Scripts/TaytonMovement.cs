using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaytonMovement : MonoBehaviour
{
    public float RegSpeed = 1;
    public float dashspeed = 12;
    public bool Incooldown;
    public bool dashOK;
    public float MovementSpeed;
    public float JumpForce = 1;

    private Rigidbody2D _rigidbody;

    // Start is called before the first frame update
    private void Start()
    {
        MovementSpeed = RegSpeed;
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }
        if (Input.GetKeyDown(KeyCode.LeftShift)&& Incooldown == false)
        {
            MovementSpeed = dashspeed;
            dashOK = true;
            Invoke("ResetDash", 0.5f);
            Incooldown = true;
            Invoke("ResetCooldown", 2.0f);
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

