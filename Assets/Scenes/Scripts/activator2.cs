using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activator2 : MonoBehaviour
{
    GameObject[] Director;
    bool randomBool;
    private Rigidbody2D rb2;
   

    void Start()
    {
        Director = GameObject.FindGameObjectsWithTag("JLBackgroundactivator");
        GameManager.pattern = 2;
        
        InvokeRepeating("ChangePattern", 0, 2f);
    }

    private void Update()
    {
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameManager.pattern = 1;
        }
    }
}
