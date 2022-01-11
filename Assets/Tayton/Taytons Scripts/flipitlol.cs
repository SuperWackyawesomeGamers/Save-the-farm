using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipitlol : MonoBehaviour
{
    Animator a;
    private Rigidbody2D _rigidbody;
    public bool JumpUp = false;
    public bool JumpDown = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        a.SetFloat("Yvelocity", _rigidbody.velocity.y);
        if (Input.GetAxis("Horizontal") > 0)
        {

            transform.GetComponent<SpriteRenderer>().flipX = true;

        }
        if (Input.GetAxis("Horizontal") < 0)
        {

            transform.GetComponent<SpriteRenderer>().flipX = false;

        }
        if (_rigidbody.velocity.y > 0.01)
        {
            JumpUp = true;
            JumpDown = false;
        }
        else if (_rigidbody.velocity.y < -0.01)
        {
            JumpDown = true;
            JumpUp = false;
        }
        else
        {
            JumpDown = false;
            JumpUp = false;
        }
    }
}
