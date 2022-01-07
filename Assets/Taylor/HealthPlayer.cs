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
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }

    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;
        

        healthBar.GetComponent<Healthbarslider>().SetHealth(currentHealth);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("test");
            if (m == GetComponent<Movement>().dashOK == false) 
            {
                TakeDamage(12);
            }
            
            rb2.velocity = Vector2.zero;
            rb2.AddForce(new Vector2(-(collision.transform.position - transform.position).x * 5, 6), ForceMode2D.Impulse);
            m.RegSpeed = 0;
            m.dashspeed = 0;
            m.MovementSpeed = 0;
            StartCoroutine("ResetMoveSpeed");
        }
    }



    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log(GetComponent<Movement>().dashOK);
            if (m == GetComponent<Movement>().dashOK == false)
            {
                TakeDamage(12);
            }

            rb2.velocity = Vector2.zero;
            rb2.AddForce(new Vector2(-(collision.transform.position - transform.position).x * 5, 6), ForceMode2D.Impulse);
            m.RegSpeed = 0;
            m.dashspeed = 0;
            m.MovementSpeed = 0;
            StartCoroutine("ResetMoveSpeed");
        }
    }



    IEnumerator ResetMoveSpeed()
    {
        yield return new WaitForSeconds(.75f);
        m.RegSpeed = 4;
        m.dashspeed = 8;
        m.MovementSpeed = 4;
    }

}
