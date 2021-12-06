using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundChanger : MonoBehaviour
{
    GameObject[] Director;
    bool randomBool;
    private Rigidbody2D rb2;
    public int pattern;

    void Start()
    {
        Director = GameObject.FindGameObjectsWithTag("JLBackgroundactivator");
        StartCoroutine("JLBackgroundactivator");
        pattern = 0;
        InvokeRepeating("ChangePattern", 0, 2f);
    }

    private void Update()
    {
        if (pattern == 0)
        {
            Director[0].SetActive(true);
            Director[1].SetActive(false);
        }
        if (pattern == 1)
        {
            Director[0].SetActive(false);
            Director[1].SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
            {
                pattern++;
            }
    }
}
