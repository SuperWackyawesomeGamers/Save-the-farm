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
      
    }

    // Update is called once per frame
    void Update()
    {

        if (notCalled)
        {
            
            
            StartCoroutine(bossShoot());
        }
        spray = Random.Range(2, 5);
    }
    IEnumerator bossShoot()
    {   
        
        notCalled = false;
        while (true)
        {
            

            Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Bullet.transform.up = Player.transform.position - Bullet.transform.position;
            rb2.velocity = (Player.transform.position - Bullet.transform.position).normalized * bulletSpeed;
            Bullet.transform.position = new Vector3(Bullet.transform.position.x, Bullet.transform.position.y, 50);
            rb2.AddForce(new Vector2(0, 0));

            Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Bullet.transform.up = Player.transform.position - Bullet.transform.position;
            rb2.velocity = (Player.transform.position - Bullet.transform.position).normalized * bulletSpeed;
            Bullet.transform.position = new Vector3(Bullet.transform.position.x, Bullet.transform.position.y, 50);
            rb2.AddForce(new Vector2(0, 100));           

            Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Bullet.transform.up = Player.transform.position - Bullet.transform.position;
            rb2.velocity = (Player.transform.position - Bullet.transform.position).normalized * bulletSpeed;
            Bullet.transform.position = new Vector3(Bullet.transform.position.x, Bullet.transform.position.y, 50);
            rb2.AddForce(new Vector2(0, -100));

            yield return new WaitForSeconds(spray);

        }
    }
}
