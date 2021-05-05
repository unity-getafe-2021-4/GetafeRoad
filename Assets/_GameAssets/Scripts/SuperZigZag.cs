using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperZigZag : MonoBehaviour
{
    public float speed;
    public float range;
    float initialY;
    float y;

    float totalTime = 0;

    private void Awake()
    {
        initialY = transform.position.y;
        y = initialY;
    }

    void Update()
    {
        totalTime+=Time.deltaTime;
        y += (Time.deltaTime * Mathf.Cos(totalTime))*speed;
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
        /*
        y += speed * Time.deltaTime;
        if (y > initialY + range)
        {
            y = initialY + range;
            speed = -speed;
        }
        else if (y < initialY)
        {
            y = initialY;
            speed = -speed;
        }
        transform.position = new Vector3(transform.position.x, y, transform.position.z);
        */
    }
}
