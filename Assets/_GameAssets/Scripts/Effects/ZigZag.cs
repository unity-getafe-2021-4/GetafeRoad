using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZigZag : MonoBehaviour
{
    public float speed;
    public float range;
    float initialY;
    float y;

    private void Awake()
    {
        initialY = transform.position.y;
        y = initialY;
    }

    void Update()
    {
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

    }
}
