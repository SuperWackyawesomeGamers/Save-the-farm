using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class bosshealth : MonoBehaviour
{

    public int maxHealth = 100;
    public int currentHealth;
    public Slider healthBar;
    public Rigidbody2D rb2;
    public Movement m;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        currentHealth = 400;
        healthBar.GetComponent<Healthbarslider>().SetMaxHealth(maxHealth);
        rb2 = GetComponent<Rigidbody2D>();
        m = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if(currentHealth <= 0)
        {
            GameManager.deathcount = 5;
            Destroy(gameObject);
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            TakeDamage(400);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.GetComponent<Healthbarslider>().SetHealth(currentHealth);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            TakeDamage(12);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Bullet")
        {
            TakeDamage(2);
        }
    }
}