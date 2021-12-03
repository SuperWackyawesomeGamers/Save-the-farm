using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CTAanimatorController : MonoBehaviour
{
    public static CTAanimatorController instance;

    Transform myTrans;
    Animator myAnim;
    Vector3 artScaleCache;

    // Start is called before the first frame update
    void Start()
    {
        myTrans = this.transform;
        myAnim = this.gameObject.GetComponent<Animator>();
        instance = this;
        artScaleCache = myTrans.LocalScale;
    }
    void FlipArt(float currentSpeed)
    {
        if((currentSpeed < 0 && artScaleCache.x == 1)||
            (currentSpeed > 0 && artScaleCache.x == -1))
        {
            artScaleCache.x *= -1;
            myTans.localScale = artScaleCache;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
