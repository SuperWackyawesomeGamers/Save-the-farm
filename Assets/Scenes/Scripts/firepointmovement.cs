using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firepointmovement : MonoBehaviour
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

            transform.localPosition = new Vector3(0.5f, 0, 0);
            transform.rotation = Quaternion.Euler(0f, 0f , 0f);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.localPosition = new Vector3(-0.5f, 0, 0);
            transform.rotation = Quaternion.Euler(0f, 0f, 180f);
        }
    }
}
