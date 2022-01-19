using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathcountcheck2 : MonoBehaviour
{
    public GameObject[] Enemy;
    public GameObject[] healthbar;
    // Start is called before the first frame update
    void Start()
    {
        //Enemy = GameObject.FindGameObjectsWithTag("Enemy");
        Enemy[0].SetActive(false);
        healthbar[0].SetActive(false);
    }
    // Update is called once per frame
    private void Update()
    {
        if (GameManager.deathcount == 4)
        {
            Enemy[0].SetActive(true);
            healthbar[0].SetActive(true);
        }
        if (GameManager.deathcount == 5)
        {
            healthbar[0].SetActive(false);
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameManager.deathcount = 4;
        }
    }
}
