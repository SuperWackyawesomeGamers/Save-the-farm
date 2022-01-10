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

            Vector3 heading = transform.position - player.transform.position;


            //rb2bullet.AddForce(bulletSpeed * (GameManager.Bossdiection * transform.right + new Vector3(0, findplayer, 0)));
            rb2bullet.AddForce(bulletSpeed * (GameManager.Bossdiection * transform.right - 0.05f* heading));
            Debug.Log("Hi");
            Destroy(b, 5f);
            GameManager.Bossdiection = -1;
        }
    }
}
