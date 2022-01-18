using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditsUp : MonoBehaviour
{
    private bool CRINGE = false;
    float yaxis;
    public Rigidbody2D rb2;
    public float Yp;
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent <Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Yp = rb2.position.y;
        if (Input.GetAxisRaw("Mouse ScrollWheel") > 0 && Yp > -20f)
        {
            transform.position -= new Vector3(0, 1, 0);
        }
        else if (Input.GetAxisRaw("Mouse ScrollWheel") < 0 && Yp < 20)
        {
            transform.position += new Vector3(0, 1, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("creditsstop"))
        {

            CRINGE = true;
        }
        
    }
}
