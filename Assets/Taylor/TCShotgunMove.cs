﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TCShotgunMove: MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {

            transform.localPosition = new Vector3(.4f, .15f, 0);
            transform.GetComponent<SpriteRenderer>().flipX = true;
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.localPosition = new Vector3(-.4f, .15f, 0);
            transform.GetComponent<SpriteRenderer>().flipX = false;
           
        }

    }
}