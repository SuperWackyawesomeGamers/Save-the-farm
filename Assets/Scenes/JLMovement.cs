using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JLMovement : MonoBehaviour
{
    [SerializeField] private float dashMultiplier = 5.0f;
    float dashTime = 0;
    float dashStartTime = 0;
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

    // Start is called before the first frame update
    private void Start()
    {
        MovementSpeed = RegSpeed;
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void Update()
    {
        Grounded = Mathf.Abs(_rigidbody.velocity.y) < 0.0001f;
        if (Grounded)
        {
            jumpCount = 0;
        }

        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (Input.GetButtonDown("Jump") && jumpCount <= 1)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            jumpCount++;
        }
        if (Input.GetKeyDown(KeyCode.LeftShift) && Incooldown == false)
        {
            dashStartTime = Time.time;

        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            float currentDashTime = 0;

            dashTime = Time.time - dashStartTime;
            dashTime = Mathf.Clamp(dashTime, 1, 2);
            currentDashTime = dashTime * dashMultiplier;

            MovementSpeed = currentDashTime;
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
