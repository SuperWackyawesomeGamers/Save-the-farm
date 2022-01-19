using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspawn : MonoBehaviour
{

    public GameObject[] Enemy;
    // Start is called before the first frame update
    void Start()
    {
        //Enemy = GameObject.FindGameObjectsWithTag("Enemy");
        Enemy[0].SetActive(false);
        Enemy[1].SetActive(false);
        Enemy[2].SetActive(false);
        Enemy[3].SetActive(false);
        Enemy[4].SetActive(false);
        Enemy[5].SetActive(false);
    }
    private void Update()
    {
        if (GameManager.deathcount == 5)
        {
            Enemy[2].SetActive(true);
            Enemy[3].SetActive(true);
            Enemy[4].SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Enemy[0].SetActive(true);
            Enemy[1].SetActive(true);
            Enemy[2].SetActive(false);
            Enemy[3].SetActive(false);
            Enemy[4].SetActive(false);
        }
    }
}
