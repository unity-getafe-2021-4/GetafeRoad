using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{
    public float distance;
    void Update()
    {
        float z = transform.position.z + (distance * Time.deltaTime);
        transform.position = 
            new Vector3(
                transform.position.x,
                transform.position.y,
                z);
    }
}
