using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossRangeAttac : MonoBehaviour
{
    public Rigidbody2D rb2;
    public GameObject Bullet;
    public GameObject FirePoint;
    public float bulletSpeed;
   
    public GameObject Player;
    private bool notCalled = true;
    float spray;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = Bullet.GetComponent<Rigidbody2D>();

        Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
        Bullet.transform.LookAt(Player.transform.position);
        rb2.velocity = (Player.transform.position - Bullet.transform.position).normalized * bulletSpeed;
        Bullet.transform.position = new Vector3(Bullet.transform.position.x, Bullet.transform.position.y, 0);
        rb2.AddForce(new Vector2(15, 0));

        Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
        Bullet.transform.LookAt(Player.transform.position);
        rb2.velocity = (Player.transform.position - Bullet.transform.position).normalized * bulletSpeed;
        Bullet.transform.position = new Vector3(Bullet.transform.position.x, Bullet.transform.position.y, 0);
        rb2.AddForce(new Vector2(15, 100));

        Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
        Bullet.transform.LookAt(Player.transform.position);
        rb2.velocity = (Player.transform.position - Bullet.transform.position).normalized * bulletSpeed;
        Bullet.transform.position = new Vector3(Bullet.transform.position.x, Bullet.transform.position.y, 0);
        rb2.AddForce(new Vector2(15, -100));
    }

    // Update is called once per frame
    void Update()
    {

        if (notCalled)
        {
            
            spray = Random.Range(2, 5);
            //StartCoroutine(bossShoot());
        }
       
    }
    IEnumerator bossShoot()
    {
        notCalled = false;
        while (true)
        {
           

            Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Bullet.transform.LookAt(Player.transform.position);
            rb2.velocity = (Player.transform.position - Bullet.transform.position).normalized * bulletSpeed;
            Bullet.transform.position = new Vector3(Bullet.transform.position.x, Bullet.transform.position.y, 0);
            rb2.AddForce(new Vector2(15, 0));

            Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Bullet.transform.LookAt(Player.transform.position);
            rb2.velocity = (Player.transform.position - Bullet.transform.position).normalized * bulletSpeed;
            Bullet.transform.position = new Vector3(Bullet.transform.position.x, Bullet.transform.position.y, 0);
            rb2.AddForce(new Vector2(15, 100));           

            Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Bullet.transform.LookAt(Player.transform.position);
            rb2.velocity = (Player.transform.position - Bullet.transform.position).normalized * bulletSpeed;
            Bullet.transform.position = new Vector3(Bullet.transform.position.x, Bullet.transform.position.y, 0);
            rb2.AddForce(new Vector2(15, -100));

            yield return new WaitForSeconds(spray);

        }
    }
}
