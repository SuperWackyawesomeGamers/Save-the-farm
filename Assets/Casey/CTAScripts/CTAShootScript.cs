﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTAShootScript : MonoBehaviour
{
    public Transform Gun;

    Vector2 direction;

    public GameObject Bullet;
    public float BulletSpeed;
    public Transform ShootPoint;
    public float fireRate;
    float ReadyforNextShot;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update ()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = mousePos - (Vector2)Gun.position;
        FaceMouse();

        if (Input.GetMouseButton(0))
        {
            if(Time.time > ReadyforNextShot)
            {
                ReadyforNextShot = Time.time + 1 / fireRate;
                Shoot();
            }
        }
    }

    void FaceMouse()
    {
        Gun.transform.right = direction;
    }
    void Shoot()
    {
        GameObject BulletIns = Instantiate(Bullet, ShootPoint.position, ShootPoint.rotation);
        BulletIns.GetComponent<Rigidbody2D>().AddForce(BulletIns.transform.right * BulletSpeed);
        Destroy(BulletIns, 1f);
    }
}
