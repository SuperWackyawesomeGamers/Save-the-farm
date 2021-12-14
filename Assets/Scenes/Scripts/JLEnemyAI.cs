using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JLEnemyAI : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public CTAEnemyHealth EnemyHealthBar;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        EnemyHealthBar.SetMaxHealth(maxHealth);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            TakeDamage(2);
        }
        if (currentHealth <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {


    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        EnemyHealthBar.SetHealth(currentHealth);
    }
}
