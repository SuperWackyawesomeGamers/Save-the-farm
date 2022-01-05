using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pitchgun : MonoBehaviour
{
    private Rigidbody2D rb2;
    public GameObject Bullet;
    public GameObject FirePoint;
    public float bulletSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetButtonDown("Fire1") || Input.GetKeyDown(KeyCode.P)))
        {
            GameObject b = Instantiate(Bullet, FirePoint.transform.position, Quaternion.identity);
            Rigidbody2D rb2bullet = b.GetComponent<Rigidbody2D>();
            rb2bullet.AddForce(bulletSpeed * (GameManager.fireDirection * transform.right + new Vector3(0, 0, 0)));
            Destroy(b, 0.4f);
            
        }
    }
}
