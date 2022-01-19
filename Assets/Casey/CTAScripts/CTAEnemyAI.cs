using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTAEnemyAI : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;
    public CTAEnemyHealth EnemyHealthBar;
    private GameObject DropItem;
    public bool ded = false;
    public CircleCollider2D ccc;
    public BoxCollider2D bc;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        EnemyHealthBar.SetMaxHealth(maxHealth);
        DropItem = GameObject.Find("Bean");
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            TakeDamage(1);
        }
        if (currentHealth <= 0)
        {
            ded = true;
            bc.enabled = false;
            ccc.enabled = false;
            Instantiate(DropItem, this.transform.position, Quaternion.identity);
            Destroy (this.gameObject, 5);
            
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
