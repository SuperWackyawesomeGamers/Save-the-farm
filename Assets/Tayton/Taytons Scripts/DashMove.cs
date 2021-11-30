using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashMove : MonoBehaviour
{
    [SerializeField]
    float speed = 0.1F;

    [SerializeField]
    float jumpForce = 15f;

    [SerializeField]
    float trampForce = 80f;

    [SerializeField]
    float dash = 0.5F;

    float dashmultiplier = 1.5f;
    bool grounded = true;
    bool dashing = false;
    float dashTime = 0;
    float startTime = 0;

    // Update is called once per frame
    void FixedUpdate()
    {

        //Player
        Rigidbody rb = GetComponent<Rigidbody>();

        //Get Horizontal Rotation from mouse
        float Hrot = 0;
        Hrot = Input.GetAxisRaw("Mouse X");

        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            startTime = Time.time;
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            dashTime = Time.time - startTime;
            //Maximum dashTime = 3 sec
            if (dashTime > 3)
            {
                dashTime = 3;
            }

            dashing = true;
        }

        if (dashing)
        {
            dashMove();
        }
        else
        {
            Move();
        }

        //Jump
        if (Input.GetKeyDown(KeyCode.Space) && grounded)
        {
            rb.AddForce(new Vector3(0, jumpForce, 0), ForceMode.Impulse);
        }
        transform.Rotate(new Vector3(0, Hrot, 0));

    }

    public void Move()
    {
        float Vmov = 0;
        float Hmov = 0;
        Vmov = Input.GetAxis("Vertical") * speed * dashmultiplier;
        Hmov = Input.GetAxis("Horizontal") * speed;
        transform.Translate(Hmov, 0, Vmov);
    }

    public void dashMove()
    {
        if (dashTime > 0)
        {
            float Vmov = 0;
            float Hmov = 0;
            Vmov = (speed + dash) * dashmultiplier;
            Hmov = Input.GetAxis("Horizontal") * speed;
            transform.Translate(Hmov, 0, Vmov);
            dashTime = dashTime - Time.deltaTime;
        }
        else
        {
            startTime = 0;
            dashTime = 0;
            dashing = false;
        }
    }
}
