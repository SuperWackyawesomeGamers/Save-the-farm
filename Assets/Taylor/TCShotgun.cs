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
   
    // Start is called before the first frame update
    void Start()
    {
        
       
    }

    // Update is called once per frame
    void Update()
    {
       


        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(2.2f, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(1.8f, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(1.8f, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(1.6f, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(2.4f, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(1.40f, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(2.1f, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(1.96f, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(1.60f, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(1.75f, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(1.5f, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(.77f, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(1, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(1.1f, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(1.31f, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(.94f, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(.88f, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(1.33f, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(1.20f, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(1.05f, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(1.16f, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(.60f, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(1.25f, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(1.5f, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(.77f, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(1, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if (Input.GetKeyDown(KeyCode.R) && bulletCount < 1)
        {
            bulletCount = 52;


        }


    }


}