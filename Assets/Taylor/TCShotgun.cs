using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TCShotgun : MonoBehaviour
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
            for (int i = 0; i < 12; i++)
            {
              Shoot();
            }
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(reloadtimer());
        }
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();
        float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotation_z);
    }
    IEnumerator reloadtimer()
    {
        yield return new WaitForSeconds(.5f);
        bulletCount = 24;
    }
    void Shoot()
    {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            spray = Random.Range(-2.5f, 7.5f);
            bulletspeed = Random.Range(10, 15);
            rb2bullet.AddForce(bulletSpeed * (transform.right + new Vector3(bulletspeed, spray, 0)));
           
            bulletCount--;
    }

}