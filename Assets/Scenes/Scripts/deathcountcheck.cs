using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathcountcheck : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        GameManager.deathcount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.deathcount == 3)
        {
            Destroy(this.gameObject);
        }
        Debug.Log(GameManager.deathcount);
       
    }
}
