using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JLBackGroundMovement : MonoBehaviour
{
    public Transform targetTransform;
    Vector3 tempVec3 = new Vector3();

    void LateUpdate()
    {
        tempVec3.x = targetTransform.position.x * 0.8f;
        tempVec3.y = this.transform.position.y;
        tempVec3.z = this.transform.position.z;
        this.transform.position = tempVec3;
    }
}
