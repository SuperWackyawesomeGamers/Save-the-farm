using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class FastBean : MonoBehaviour
{
    public CTAPlayerMove CTA;
    public float targetTime = 200.0f;
    private bool powerOff = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print(targetTime);
        if (powerOff == true)
        {
            CTA.MovementSpeed = 4;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject);
        {
            CTA.MovementSpeed += 1;
            Destroy(this.gameObject);
            powerOff = false;
            targetTime -= Time.deltaTime;

            if (targetTime <= 0.0f)
            {
                timerEnded();
            }
        }
    }
    void timerEnded()
    {
        powerOff = true;
    }
}
