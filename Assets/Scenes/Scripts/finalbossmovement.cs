using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finalbossmovement : MonoBehaviour
{
    private bool dirRight = true;
    public float speed = 2.0f;
    public float JumpForce;
    private Rigidbody2D rigidbody;
    public GameObject Bullet;
    public GameObject FirePoint;
    public float bulletSpeed;
    public GameObject Firedirection;
    public int currentHealth;
    public int maxHealth = 1000;

    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        GameManager.Bossdiection = -1;
        currentHealth = maxHealth;
    }
    void Update()
    {
        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime * 2);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime * 2);

        if (transform.position.x >= 13f)
        {
            dirRight = false;
            rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float findplayer = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.Bossdiection * transform.right + new Vector3(0, findplayer, 0)));
            Destroy(b, 5f);
            GameManager.Bossdiection = 1;
        }

        if (transform.position.x <= -13f)
        {
            dirRight = true;
            rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float findplayer = Random.Range(-0.5f, 0.5f);
            GameObject player = GameObject.FindGameObjectWithTag("Player");
            rb2bullet.AddForce(bulletSpeed * (GameManager.Bossdiection * transform.right + new Vector3(0, findplayer, 0)));
            Debug.Log("Hi");
            Destroy(b, 5f);
            GameManager.Bossdiection = -1;
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Bullet")
        {
            TakeDamage(2);
        }
        if (currentHealth <= 0)
        {
            SceneManager.LoadScene("Main menu");
        }

    }
    void TakeDamage(int damage)
    {
        currentHealth -= damage;
    }
}
