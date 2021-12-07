using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundChanger : MonoBehaviour
{
    GameObject[] Director;
    bool randomBool;
    private Rigidbody2D rb2;
    GameObject[] Activator;

    void Start()
    {
        Director = GameObject.FindGameObjectsWithTag("JLBackgroundactivator");
        InvokeRepeating("ChangePattern", 0, 2f);
        Activator = GameObject.FindGameObjectsWithTag("Activator");
        Activator[0].SetActive(false);
    }

    private void Update()
    {
        if (GameManager.pattern == 0)
        {
            Director[0].SetActive(true);
            Director[1].SetActive(false);
            Activator[0].SetActive(true);
        }
        if (GameManager.pattern == 1)
        {
            Director[0].SetActive(false);
            Director[1].SetActive(true);
        }
        if (GameManager.pattern == 2)
        {
            Director[0].SetActive(false);
            Director[1].SetActive(false);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameManager.pattern = 0;
        }
    }
}
