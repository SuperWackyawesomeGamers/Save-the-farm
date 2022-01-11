﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JLMovement : MonoBehaviour
{
    Animator a;
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
    bool grounded = false;
    public int jumpCount;
    public int maxHealth = 100;
    public int currentHealth;
    public CTAHealthBar healthBar;

    private Rigidbody2D _rigidbody;

    // Start is called before the first frame update
    private void Start()
    {

        currentHealth = maxHealth;
        healthBar.SetMAxHealth(maxHealth);
        MovementSpeed = RegSpeed;
        _rigidbody = GetComponent<Rigidbody2D>();
        a = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        a.SetFloat("Yvelocity", _rigidbody.velocity.y);

        grounded = Physics2D.BoxCast(transform.position - new Vector3(0, 0.52f, 0), new Vector2(0.1f, 0.1f), 0, Vector2.down, 1, LayerMask.GetMask("Ground"));

        a.SetBool("Grounded", grounded);

        float horizValue = Input.GetAxis("Horizontal");
        if (horizValue == 0)
        {
            a.SetBool("Moving", false);
        }
        else
        {
            a.SetBool("Moving", true);
        }
        grounded = Mathf.Abs(_rigidbody.velocity.y) < 0.0001f;
        if (grounded)
        {
            jumpCount = 0;
        }

        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
        if (Input.GetAxis("Horizontal") > 0)
        {

            transform.GetComponent<SpriteRenderer>().flipX = true;

        }
        if (Input.GetAxis("Horizontal") < 0)
        {

            transform.GetComponent<SpriteRenderer>().flipX = false;

        }
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
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            TakeDamage(20);
        }
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("Main menu");
        }
    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
