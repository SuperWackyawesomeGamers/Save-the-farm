using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    private void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        GameManager.Bossdiection = -1;
    }
    void Update()
    {
        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime * 2);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime * 2);

        if (transform.position.x >= 7.0f)
        {
            dirRight = false;
            rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.Bossdiection * transform.right + new Vector3(0, spray, 0)));
            Destroy(b, 1f);
            GameManager.Bossdiection = 1;
        }

        if (transform.position.x <= -7)
        {
            dirRight = true;
            rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.Bossdiection * transform.right + new Vector3(0, spray, 0)));
            Destroy(b, 1f);
            GameManager.Bossdiection = -1;
        }
    }
}
