﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : MonoBehaviour
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

        if( (Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed *  ( GameManager.fireDirection *   transform.right + new Vector3(0,spray,0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(0, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(0, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(0, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(0, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(0, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(0, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(0, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(0, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(0, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(0, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(0, spray, 0)));
            Destroy(b, 0.4f);
            bulletCount--;
        }
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)) && bulletCount > 0)
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            float spray = Random.Range(-0.5f, 0.5f);
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(0, spray, 0)));
            Destroy(b, 0.4f);
             bulletCount--;
        }
        if (Input.GetKeyDown(KeyCode.R) && bulletCount < 1)
        {
            bulletCount = 26;
        }
    }
}