using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flipitlol : MonoBehaviour
{
    public Animator a;
    [SerializeField] Rigidbody2D _PlayerRigidbody;
    public bool JumpUp = false;
    public bool JumpDown = false;
    public bool grounded = true;
    public JLMovement move;
    // Start is called before the first frame update
    void Start()
    {
        //a = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        a.SetFloat("Yvelocity", _PlayerRigidbody.velocity.y);
        print(_PlayerRigidbody.velocity.y);

        a.SetBool("groundcheck", move.groundcheck());

        float horizValue = Input.GetAxis("Horizontal");
        if (horizValue == 0)
        {
            a.SetBool("Moving", false);
        }
        else
        {
            a.SetBool("Moving", true);
        }
        if (Input.GetAxis("Horizontal") > 0)
        {

            transform.GetComponent<SpriteRenderer>().flipX = true;

        }
        if (Input.GetAxis("Horizontal") < 0)
        {

            transform.GetComponent<SpriteRenderer>().flipX = false;

        }
        if (_PlayerRigidbody.velocity.y > 0.01)
        {
            JumpUp = true;
            JumpDown = false;
        }
        else if (_PlayerRigidbody.velocity.y < -0.01)
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
