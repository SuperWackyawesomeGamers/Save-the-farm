﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flipit2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Horizontal") > 0)
        {

            transform.GetComponent<SpriteRenderer>().flipX = true;

        }
        if (Input.GetAxis("Horizontal") < 0)
        {

            transform.GetComponent<SpriteRenderer>().flipX = false;

        }
    }
}
