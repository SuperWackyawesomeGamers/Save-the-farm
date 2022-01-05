using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossRangeAttac : MonoBehaviour
{
    private Rigidbody2D rb2;
    public GameObject Bullet;
    public GameObject FirePoint;
    public float bulletSpeed;
   
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") )
        {
            print(1);

            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            b.transform.LookAt(Player.transform.position);
            b.GetComponent<Rigidbody2D>().velocity = (Player.transform.position - b.transform.position).normalized * bulletSpeed;
            b.transform.position = new Vector3(b.transform.position.x, b.transform.position.y, 0);
            
        }
        if (Input.GetButtonDown("Fire1"))
        {
            print(1);

            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-5, 5);
            b.transform.LookAt(Player.transform.position);
            b.GetComponent<Rigidbody2D>().velocity = (Player.transform.position - b.transform.position).normalized * bulletSpeed;
            b.transform.position = new Vector3(b.transform.position.x, b.transform.position.y, 0);
            rb2bullet.AddForce(new Vector2(0, 100));
        }

        if (Input.GetButtonDown("Fire1"))
        {
            print(1);

            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-5, 5);
            b.transform.LookAt(Player.transform.position);
            b.GetComponent<Rigidbody2D>().velocity = (Player.transform.position - b.transform.position).normalized * bulletSpeed;
            b.transform.position = new Vector3(b.transform.position.x, b.transform.position.y, 0);
            rb2bullet.AddForce(new Vector2(0, -100));
           
        }
    }
}
