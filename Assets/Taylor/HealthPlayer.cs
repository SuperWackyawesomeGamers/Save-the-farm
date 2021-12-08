using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPlayer : MonoBehaviour
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
        currentHealth = 100;
        healthBar.GetComponent<Healthbarslider>().SetMaxHealth(maxHealth);
        rb2 = GetComponent<Rigidbody2D>();
        m = GetComponent<Movement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            TakeDamage(1);
        }
        
            bool Grounded = Mathf.Abs(rb2.velocity.y) < 0.0001f;
            if (Grounded)
            {
                m.RegSpeed = 4;
                m.dashspeed = 8;
            m.MovementSpeed = 4;
            }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        

        healthBar.GetComponent<Healthbarslider>().SetHealth(currentHealth);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            rb2.velocity = Vector2.zero;


            rb2.AddForce(new Vector2(-(collision.transform.position - transform.position).x * 4, 7), ForceMode2D.Impulse);
            m.RegSpeed = 0;
            m.dashspeed = 0;
            m.MovementSpeed = 0;
     
        }
    }

}
