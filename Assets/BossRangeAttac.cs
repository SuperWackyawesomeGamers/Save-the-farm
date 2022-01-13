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
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        rb2 = Bullet.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (notCalled)
        {
            
            
            StartCoroutine(bossShoot());
        }
        timer = Random.Range(2, 5);
    }
    IEnumerator bossShoot()
    {   
        
        notCalled = false;
        while (true)
        {
            for (int i = -1; i < 2; i++)
            {
                GameObject bullet = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
                //bullet.transform.up = bullet.transform.position - Player.transform.position;
                bullet.GetComponent<Rigidbody2D>().velocity = (Player.transform.position - bullet.transform.position ).normalized * bulletSpeed;
                //bullet.transform.position = new Vector3(bullet.transform.position.x, bullet.transform.position.y, 50);
                bullet.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, i * 100));
            }

            yield return new WaitForSeconds(timer);

        }
    }
}
