using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfCam : MonoBehaviour
{

    public Camera cam; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = (cam.transform.position - this.transform.position).magnitude;
        Debug.Log(distance);
        if (distance > 13.5f)
        {
            Destroy(this.gameObject);
        }
    }
}
