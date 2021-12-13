using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shotgunmovement : MonoBehaviour
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

            transform.localPosition = new Vector3 (0.4f , 0, 0);
            transform.GetComponent<SpriteRenderer>().flipX = true;
            GameManager.fireDirection = 1;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
          transform.localPosition = new Vector3 (-0.4f , 0 , 0);
            transform.GetComponent<SpriteRenderer>().flipX = false;
            GameManager.fireDirection = -1;
        }
        
    }
}
