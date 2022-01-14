using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : MonoBehaviour
{
    private Rigidbody2D rb2;
    public GameObject Bullet;
    public GameObject FirePoint;
    public float bulletSpeed;
    public int bulletCount;
    float spray;
    float bulletspeed;



    void Update()
    {
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            for (int i = 0; i < 13; i++)
            {
                Shoot();
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(reloadtimer());
        }

    }
    IEnumerator reloadtimer()
    {
        yield return new WaitForSeconds(0.5f);
        bulletCount = 26;
    }
    void Shoot()
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            spray = Random.Range(-0.5f, 0.5f);
            bulletspeed = Random.Range(-100, 100);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(0, spray, 0)));
            rb2bullet.AddForce(new Vector3(bulletspeed, 0, 0));
           Destroy(b, 0.4f);
            bulletCount--;
        }
}
