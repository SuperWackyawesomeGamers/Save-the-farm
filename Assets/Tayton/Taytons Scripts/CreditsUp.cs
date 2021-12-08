using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsUp : MonoBehaviour
{
    float yaxis;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        yaxis = -10;
    }

    // Update is called once per frame
    void Update()
    {
        
        yaxis+=Speed;
        gameObject.transform.position = new Vector3(0, yaxis, 0);
    }
}
